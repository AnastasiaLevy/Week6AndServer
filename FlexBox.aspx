<!DOCTYPE html>
<html>
<head>
<style> 
div
{
    margin-top: 70px;
    margin-left:40px;
    display:-moz-box; /* Firefox */
    display:-webkit-box; /* Safari and Chrome */
    display:-ms-flexbox; /* Internet Explorer 10 */
    display:inline-flexbox;
    width:900px;
    height:300px;
    border:double solid black; 
    background-image:url("Images/psychology-pic.jpg");
    position:relative; 
  
}

#p1
{
    -moz-box-flex:1.0; /* Firefox */
    -webkit-box-flex:1.0; /* Safari and Chrome */
    -ms-flex:2.0; /* Internet Explorer 10 */
    box-flex:2.0;
    border:1px solid red;
    margin:40px 40px 40px 40px;
    position: relative;
}

#p2
{
    -moz-box-flex:2.0; /* Firefox */
    -webkit-box-flex:2.0; /* Safari and Chrome */
    -ms-flex:2.0; /* Internet Explorer 10 */
    box-flex:1.0;
    box-shadow:10px 10px 10px #ADD8E6 ;
    border:2px solid blue;
    margin:50px 50px 50px 50px;
    position: relative;
        
}
    p:hover:not(p1) {
        transform: scale(1.2, 1.2);
        -moz-transform: scale(1.2, 1.2);
        -ms-transform: scale(1.2, 1.2);
        -webkit-transform: scale(1.2, 1.2);
        -o-transform: scale(1.2, 1.2);
        background-color: azure;
        opacity: 0.5;
        -webkit-animation: hinge;
         animation:hinge;
    }
@-webkit-keyframes hinge {
	0% { -webkit-transform: rotate(0); -webkit-transform-origin: top left; -webkit-animation-timing-function: ease-in-out; }	
	20%, 60% { -webkit-transform: rotate(80deg); -webkit-transform-origin: top left; -webkit-animation-timing-function: ease-in-out; }	
	40% { -webkit-transform: rotate(60deg); -webkit-transform-origin: top left; -webkit-animation-timing-function: ease-in-out; }	
	80% { -webkit-transform: rotate(60deg) translateY(0); opacity: 1; -webkit-transform-origin: top left; -webkit-animation-timing-function: ease-in-out; }	
	100% { -webkit-transform: translateY(700px); opacity: 0; }
}
.hinge {
	-webkit-animation-name: hinge;
	-moz-animation-name: hinge;
	-o-animation-name: hinge;
	animation-name: hinge;
}



    
    #p3 {
        -moz-box-flex: 2.0; /* Firefox */
        -webkit-box-flex: 2.0; /* Safari and Chrome */
        -ms-flex: 2.0; /* Internet Explorer 10 */
        box-flex: 1.0;
        box-shadow:10px 10px 10px #FEF1B5;
        border: 2px solid yellow;
        margin:50px 50px 50px 50px;
        position: relative;
    }
     #p4 {
        -moz-box-flex: 2.0; /* Firefox */
        -webkit-box-flex: 2.0; /* Safari and Chrome */
        -ms-flex: 2.0; /* Internet Explorer 10 */
        box-flex: 1.0;
        
        box-shadow:10px 10px 10px #BDA0CB;
        border: 2px solid purple;
        margin:50px 50px 50px 50px;
        position: relative;
    }
    h2 {
        font-family: 'Browallia New';
        color: blue;
        text-align:center;
    }

    </style>
</head>

  
<body>
<h2>
Welcome to Psychology Research Methods
   </h2>

<div>

<p id="p2">Update <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Default2.aspx">Profile</asp:HyperLink></p>
<p id ="p3">View <asp:HyperLink ID="HyperLink1" runat="server">Class</asp:HyperLink></p>
<p id="p4">View <asp:HyperLink ID="HyperLink3" runat="server">Exams</asp:HyperLink></p>

</div>

    

</body>
</html>


