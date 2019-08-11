using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aspose.Slides;

namespace SlideViewer
{
    public partial class index : System.Web.UI.Page
    {
        static string SourcePath;
        static string OutputPath;
        static string DocumentName = "";
        static string OutputFolderForFile;
        static Presentation presentation;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // set output directories
                OutputPath = Server.MapPath("~/output/");
                SourcePath = Server.MapPath("~/storage/");


                DocumentName = SliderViewer.Global.SelectedFile;
                //Load Presentation
                LoadPresentation();

                // get document info
                GetDocumentInfo();
            }
        }

        private void LoadPresentation()
        {
           // DocumentName = SliderViewer.Global.SelectedFile;
          //  DocumentName = SourcePath + @"sample.pptx";
            //            presentation = new Presentation(DocumentName);
            try
            {
                presentation = new Presentation(SourcePath + SliderViewer.Global.SelectedFile);
            }
            catch(Exception e)
            {

            }

            }
        private void GetDocumentInfo()
        {
            try
            {
                lblTotalPages.Text = presentation.Slides.Count.ToString();

            }
            catch
            {

            }
        }

        [System.Web.Services.WebMethod]
        public static string GetPage(string value)
        {
            try
            {

                OutputFolderForFile = Path.Combine(OutputPath, Path.GetFileNameWithoutExtension(DocumentName));
                if (!Directory.Exists(OutputFolderForFile))
                {
                    Directory.CreateDirectory(OutputFolderForFile);
                }


                float ScaleFactor = 1;
                var image = presentation.Slides[Convert.ToInt32(value) - 1].GetThumbnail(ScaleFactor, ScaleFactor);

                string ImagePath = Path.Combine(@"output", Path.GetFileNameWithoutExtension(DocumentName), string.Format("img{0}.png", value));

                string file = Path.Combine(OutputFolderForFile, string.Format("img{0}.png", value));

                if (!File.Exists(file))
                {
                    SaveAsImage(image, file);
                }

                ImagePath = Path.Combine(@"output", Path.GetFileNameWithoutExtension(DocumentName), string.Format("img{0}.png", value));

                return ImagePath;
            }
            catch(Exception e)
            {
                return "";
            }

        }
        private static void SaveAsImage(Stream st, string path)
        {
            // extract the image from stream
            System.Drawing.Image img = System.Drawing.Image.FromStream(st);

            //save the image in the form of jpeg
            img.Save(path, ImageFormat.Png);
        }

        private static void SaveAsImage(System.Drawing.Bitmap img, string path)
        {

            //save the image in the form of jpeg
            img.Save(path, ImageFormat.Png);
        }
    }
}