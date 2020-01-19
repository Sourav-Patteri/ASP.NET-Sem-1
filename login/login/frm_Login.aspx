<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frm_Login.aspx.vb" Inherits="login.frm_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="padding: 10% 10% 10% 10%", "backgrounf-color: blue">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        User Name:
                    </td>    
                    <td>
                        <asp:TextBox ID="username" runat="server"></asp:TextBox>
                    </td>
                     <td>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username is required" ControlToValidate="username"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                         Password:
                    </td>    
                    <td>
                        <asp:TextBox ID="pass" runat="server"></asp:TextBox>
                    </td>
                    <td>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password is required.." ControlToValidate="pass"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="login_btn" runat="server" Text="Login" />
                    </td>    
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
