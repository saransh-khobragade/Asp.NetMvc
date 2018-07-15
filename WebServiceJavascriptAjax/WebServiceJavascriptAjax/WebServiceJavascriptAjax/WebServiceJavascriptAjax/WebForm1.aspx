<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebServiceJavascriptAjax.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript" language="javascript">
        function GetEmployeeById() 
        {
            var id = document.getElementById("TextBox1").value;
            WebServiceJavascriptAjax.EmployeeService.GetEmployeeById(id,
            GetEmployeeByIdSuccessCallback, GetEmployeeByIdFailedCallback);
        }

        function GetEmployeeByIdSuccessCallback(result)
        {
            document.getElementById("TextBox2").value = result["ename"];
            document.getElementById("TextBox3").value = result["salary"];
            document.getElementById("TextBox4").value = result["mgrid"];
        }

        function GetEmployeeByIdFailedCallback(errors) 
        {
            alert(errors.get_message());
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/EmployeeService.asmx" />
            </Services>
        </asp:ScriptManager>

        <table>
            <tr>
                <td>ID</td><td><asp:TextBox ID="TextBox1" runat="server" value="1"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Employee Name</td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Salary</td><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Manager ID</td><td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            </tr>

        </table>
        <input id="Button1" type="button" value="Get info of Employee" onclick="GetEmployeeById()" />
    </div>
    </form>
</body>
</html>
