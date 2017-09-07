<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" >
        function ValidateForm() {
            var ret = true;

            if (document.getElementById("TextBox1").valueOf() == "") {
                document.getElementById("LabelID").innerText == "ID is needed";
                ret = false;
            }
        }
            </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
