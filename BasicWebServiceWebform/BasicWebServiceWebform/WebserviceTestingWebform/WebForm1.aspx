﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebserviceTestingWebform.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>,
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>First number</td>
                <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Second number</td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></td>
                <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
        </table>
    </div>
        
    </form>
</body>
</html>
