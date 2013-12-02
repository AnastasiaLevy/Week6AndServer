<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

  form
{
    margin-top: 70px;
    margin-left:40px;
    display:-moz-box;  
    display:-webkit-box;   
    display:-ms-flexbox;   
    display:inline-flexbox;
    width:900px;
    height:300px;
    border:thick solid black;
    background-image:url("Images/psychology-pic.jpg");
    position:relative; 
    
  
}
     div5
     {
    -moz-box-flex:1.0;  
    -webkit-box-flex:1.0;  
    -ms-flex:2.0; 
    box-flex:2.0;
    border:1px solid blue;
    margin:40px 40px 40px 40px;
    position:absolute;
}

        .style1 {
            margin-left: 40px;
            margin-top:80px;
            width:220px;
            height:130px;
            border:double blue;
            position:relative;
            opacity:1;
            background-color:#bef1f7;
            box-shadow:10px 10px 10px #394df6;
     
        }

        .auto-style1 {
            Width:180px;
            margin:10px 10px 10px 10px;
            position:relative;

        }
        
        .auto-style2 {
            height: 93px;
            width: 83px;
        }
        p {
            font-family: 'Browallia New';
            font-size: 24px;
            color:blue;
            
        }
        .style1:hover {
            transform: scale(1.3, 1.3);
            -moz-transform: scale(1.3, 1.3);
            -ms-transform: scale(1.3, 1.3);
            -webkit-transform: scale(1.3, 1.3);
            -o-transform: scale(1.3, 1.3);
            box-shadow:13px 13px 13px gray;
            background-color:#dff3f6;
            

           
        }
         h2 {
        font-family: 'Browallia New';
        color: blue;
        text-align:center;
    }
        .button {
            margin-top: 280px;
            background-color:#649ab6;
            border:double blue;
            text-shadow:5px 5px 5px black;
            
            
        }
            .button:hover {
                transform: scale(1.3, 1.3);
                -moz-transform: scale(1.3, 1.3);
                -ms-transform: scale(1.3, 1.3);
                -webkit-transform: scale(1.3, 1.3);
                -o-transform: scale(1.3, 1.3);
                box-shadow: 13px 13px 13px gray;
                background-color: #dff3f6;
                font: 20px;
            }
        .done {
            background-color: purple;
            margin-left:0px;
        }
        
    </style>
</head>
<body>
    <h2>
Welcome to Psychology Research Methods
   </h2>
    
    <form id="main" runat="server">
    <div id="1" class="style1">
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" placeholder="Enter your First Name" ></asp:TextBox>
        <br />
        <br />
<asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1" placeholder="Enter your Last Name"></asp:TextBox>
        <br />
        <br />
        </div>
        <div id="2" class="style1">
            <p>Choose your lab</p>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style1" DataSourceID="ObjectDataSource1" DataTextField="Schedule" DataValueField="Id">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ReturnList" TypeName="BusinessLayer"></asp:ObjectDataSource>
            
         </div>
        
        <div id="3" class ="style1">
            
        <img src="Images/imageplaceh.jpg" class="auto-style2" /> <input id="File1" type="file" <asp:Label ID="Label1" runat="server" Text="Not done yet"></asp:Label></div>
        
        <asp:Button ID="Button1" class="button" runat="server" Text="Submit" OnClick="Button1_Click" />
       
        </form>
    
</body>
</html>
