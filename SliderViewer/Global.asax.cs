using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace SliderViewer
{
    public class Global : System.Web.HttpApplication
    {
        public static string SelectedFile = "";

        protected void Application_Start(object sender, EventArgs e)
        {
            // set license
            Aspose.Slides.License licSlides = new Aspose.Slides.License();
            //licSlides.SetLicense(@"C:\Aspose Data\2019\Aspose.Total.NET.lic");
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}