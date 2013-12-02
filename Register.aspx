<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
          form {
            background-image: url("Images/psychology-pic.jpg");
            width: 900px;
            height: 300px;
           
        }
        .createUser {
            margin-left: 500px;
            border: double blue;
             margin-left:507px;
            background-color:#90a6ec;
            opacity:0.9;
            height:300px;
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
    <form id="form1" runat="server">
    <div>
        <asp:CreateUserWizard ID="CreateUserWizard1" CssClass="createUser"  runat ="server" OnCreatedUser="CreateUserWizard1_CreatedUser">
            <WizardSteps>
                <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                </asp:CompleteWizardStep>
            </WizardSteps>
        </asp:CreateUserWizard>
    </div>
    </form>
</body>
</html>
