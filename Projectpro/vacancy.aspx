<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vacancy.aspx.cs" Inherits="Projectpro.WebForm1"  %>

<!DOCTYPE html>

<html ng-app xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  


    <script src="https://www.c-sharpcorner.com/UploadFile/Downloads/cd7c2e/12-17-2013/angular.min.js"></script>

        <script>

        function x($scope) {

            $scope.firstPassword = 'morocco';

          

            $scope.func = function () {

            

                if ($scope.firstPassword == 'morocco')
                {
                    alert("Success");
                }

            }

        }

    </script>

</head>

<body>
    <form id="form1" runat="server">
    <div>
    
    <h1 align="center">ADD VACANCY</h1>

        <asp:Panel runat="server">
        <asp:Table runat="server" align="center">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="name" runat="server" Text="Name"></asp:Label>
                </asp:TableCell> 
                <asp:TableCell>
                    <asp:TextBox ID="ttname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="fir" runat="server" ControlToValidate="ttname"  ForeColor="Red" ErrorMessage="*" Display="Dynamic" ValidationGroup="uuu"></asp:RequiredFieldValidator>

                </asp:TableCell>

            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                <label>Place </label>
                </asp:TableCell>
                <asp:TableCell>
                 <asp:TextBox ID="ttplace" runat="server"  ng-model="firstPassword"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="sec" ControlToValidate="ttplace" ForeColor="Red" ErrorMessage="*" ValidationGroup="uuu" Display="Dynamic"></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>




            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="country" Text="Country" runat="server"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="ttcountry" runat="server"></asp:TextBox>
                </asp:TableCell>

            </asp:TableRow>

            </asp:Table>
            <div align="center">
            <asp:Button ID="subbutton" runat="server" text="Submit" Width="100px" OnClick="subbutton_Click" ng-click="func()" />
                <asp:Button ID="viewlist" runat="server" Text="View" OnClick="viewlist_Click" />
                </div>
    </asp:Panel>
    </div>
    </form>

</body>
</html>
