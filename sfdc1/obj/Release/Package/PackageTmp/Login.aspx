<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="sfdc1.Login" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="materialize.min.css" rel="stylesheet" />
    <script src="jq.js"></script>
    <link href="font.css" rel="stylesheet" />
    <script src="materialize.min.js"></script>
    <script>
        $(document).ready(function () {
            $('.parallax').parallax();
            $('.modal-trigger').leanModal();
            $('select').material_select();
        });
    </script>
    <style>
        nav ul a {
            text-shadow: 0px 0px 10px black;
            font-weight: 500;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="parallax-container">
                <div class="parallax">
                    <img src="1.jpg" height="800" />
                </div>
                <nav style="background-color: rgba(255,255,255,0.3)">
                    <div class="nav-wrapper">
                        <a href="#" class="brand-logo right">
                            <img src="logo-web-light@1x.png" height="34" /></a>
                        <ul id="nav-mobile" class="left hide-on-med-and-down">
                            <li><a href="Login.aspx">Login/Signup</a></li>
                        </ul>
                    </div>
                </nav>
            </div>
            <div class="section white">
                <div class="row container">
                    <h2 class="header">Enter your unique ID</h2>
                    <div class="input-field col s8">
                        <input runat="server" id="uniqueID" type="text" class="validate" />
                        <label for="uniqueID">UNIQUE ID</label>
                    </div>
                    <div class="input-field col s4">
                        <asp:LinkButton OnClick="Unnamed_Click" runat="server" CssClass="btn-floating btn-large waves-effect waves-light red"><i class="material-icons">send</i></asp:LinkButton>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col s2" style="height: 10px;"></div>
                <div class="col s8">
                    <table class="striped hoverable">
                        <tbody runat="server" id="tbody">
                            
                        </tbody>
                    </table>
                </div>
                <div class="col s2" style="height: 10px;"></div>
            </div>
        </div>
    </form>
</body>
</html>
