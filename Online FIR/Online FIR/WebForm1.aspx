<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Online_FIR.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to Facebook</title>

</head>
<body>
    <div class="mainContainerDiv">
        <div class="headerDiv">
            <div class="leftSideDiv">
                <asp:Label ID="lblFacebook" CssClass="titleFacebook" runat="server">
                    facebook
                </asp:Label>
            </div>
            <form runat="server">
            <div class="rightSideDiv">
                <div class="col1Div">
                    <div class="row1Div">
                        Email or Phone
                    </div> 
                    <div class="row2Div">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </div>

                    <div class="row3Div">

                    </div>
                </div>
                <div class="col2Div">
                    <div class="row1Div">
                        Password
                    </div> 
                    <div class="row2Div">
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </div>

                    <div class="row3Div">

                    </div>
                </div>
                <div class="col3Div">
                    <asp:Button ID="btnLogin" runat="server" Text="Log In" />
                </div>
            </div>
           </form>
        </div>

        <div class="contentDiv">

        </div>
        
        <div class="footerDiv">

        </div>
    </div>

    <link href="Stylesheet/homeStyle.css" rel="stylesheet" />
</body>
</html>
