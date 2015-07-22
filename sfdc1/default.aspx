<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="sfdc1._default" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UBER - Akshay, Kunal, Niveditta</title>
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
                    <h2 class="header">Book a ride</h2>
                    <div class="row">
                        <div class="col s12">
                            <div class="row">
                                <div class="input-field col s6">
                                    <i class="material-icons prefix">person</i>
                                    <input id="name" runat="server" type="text" />
                                    <label for="icon_prefix">Name</label>
                                </div>
                                <div class="input-field col s6">
                                    <i class="material-icons prefix">phone</i>
                                    <input id="contact" runat="server" type="tel" />
                                    <label for="icon_telephone">Contact Number</label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col s12">
                            <div class="row">
                                <div class="input-field col s6">
                                    <i class="material-icons prefix">mail</i>
                                    <input id="email" runat="server" type="email" />
                                    <label for="icon_telephone">Email</label>
                                </div>
                                <div class="input-field col s6">
                                    <i class="material-icons prefix">map</i>
                                    <input id="dest" runat="server" type="tel" />
                                    <label for="icon_telephone">Destination</label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col s12">
                            <a class="waves-effect waves-light btn modal-trigger" style="width:100%" href="#modal1">Book A Ride</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="parallax-container">
                <div class="parallax">
                    <img src="1.jpg" />
                </div>
            </div>
        </div>
        <footer class="page-footer teal" style="margin-top: 0px">
            <div class="container">
                <div class="row">
                    <div class="col l6 s12">
                        <h5 class="white-text">UBER Inc.</h5>
                        <p class="grey-text text-lighten-4">Uber is evolving the way the world moves. By seamlessly connecting riders to drivers through our apps, we make cities more accessible, opening up more possibilities for riders and more business for drivers. From our founding in 2009 to our launches in hundreds of cities today, Uber's rapidly expanding global presence continues to bring people and their cities closer.</p>
                    </div>
                    <div class="col l4 offset-l2 s12">
                        <h5 class="white-text">Links</h5>
                        <ul>
                            <li><a class="grey-text text-lighten-3" href="#!">About Us</a></li>
                            <li><a class="grey-text text-lighten-3" href="#!">Contact</a></li>
                            <li><a class="grey-text text-lighten-3" href="#!">Feedback</a></li>
                            <li><a class="grey-text text-lighten-3" href="#!">Join Us</a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="footer-copyright">
                <div class="container">
                    © 2015 Copyright
            <a class="grey-text text-lighten-4 right" href="#!">Akshay Kumar Gupta, Nivedita Batra, Kunal Sachdeva</a>
                </div>
            </div>
        </footer>

        <!-- Modal Structure -->
        <div id="modal1" class="modal bottom-sheet">
            <div class="modal-content">
                <h4>Payment Details</h4>
                    <div class="row" style="margin:0">
                        <div class="input-field col s4">
                            <i class="material-icons prefix">payment</i>
                            <input id="CardNo" runat="server" type="text" class="validate" />
                            <label for="icon_prefix2">Card Number</label>
                        </div>
                        <div class="input-field col s4">
                            <select runat="server" id="cardType">
                                <option value="Visa" selected="selected">Visa</option>
                                <option value="Maestro">Maestro</option>
                            </select>
                            <label>Select Card</label>
                        </div>
                        <div class="input-field col s4">
                            <select runat="server" id="bankName">
                                <option value="Axis Bank" selected="selected">Axis Bank</option>
                                <option value="Bank of Baroda">Bank of Baroda</option>
                                <option value="HDFC">HDFC</option>
                                <option value="Indian Bank">Indian Bank</option>
                                <option value="Punjab National Bank">Punjab National Bank</option>
                                <option value="State Bank of India">State Bank of India</option>
                            </select>
                            <label>Select Bank</label>
                        </div>
                    </div>
            </div>
            <div class="modal-footer">
                <asp:LinkButton runat="server" ID="booking_btn" OnClick="booking_btn_Click" CssClass="modal-action modal-close waves-effect waves-green btn-flat">BOOK</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
