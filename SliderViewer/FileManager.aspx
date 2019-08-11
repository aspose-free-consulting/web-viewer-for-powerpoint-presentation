<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileManager.aspx.cs" Inherits="SliderViewer.FileManager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>File Manger</title>
    <script src="scripts/jquery-3.3.1.js" type="text/javascript"></script>
    <script src="scripts/jquery-3.3.1.min.js" type="text/javascript"></script>

    <script src="scripts/bootstrap.min.js" type="text/javascript"></script>
    <script src="scripts/bootstrap.js" type="text/javascript"></script>
    <link href="Content/bootstrap.min.css" type="text/css" rel="stylesheet" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js" type="text/javascript"></script>
<style>
a {
  text-decoration: none;
  display: inline-block;
  padding: 8px 16px;
}

a:hover {
  background-color: #ddd;
  color: black;
}

.previous {
  background-color: #f1f1f1;
  color: black;
}

.next {
  background-color: #f1f1f1;
  color: black;
}

.round {
  border-radius: 50%;
}
}
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         
<div class="navbar navbar-inverse navbar-fixed-top">
 <div align="left" style="margin-top: 2%">
    <asp:FileUpload ID="FileUpload1" runat="server" />
        <div>

        </div>
    <div align="left" style="margin-top: 2%">
    <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="UploadFile" />
    <hr />
    </div>
 </div>
 </div> 
    <div class="container body-content">
        <div align="left" style="margin-top: 15%"> 
        
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" EmptyDataText = "No files uploaded" Width="286px">
        <Columns>
            <asp:BoundField DataField="Text" HeaderText="File Name" />

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID = "lnkDelete" Text = "Delete" CommandArgument = '<%# Eval("Value") %>' runat = "server" OnClick = "DeleteFile" />
                </ItemTemplate>
            </asp:TemplateField>
                <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnkView" Text = "View" CommandArgument = '<%# Eval("Value") %>' runat="server" OnClick = "ViewFile"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        
     </div> 

   </div> 
</form>

</body>
    
</html>

