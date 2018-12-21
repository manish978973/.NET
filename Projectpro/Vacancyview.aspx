<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vacancyview.aspx.cs" Inherits="Projectpro.Vacancyview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server"> 
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" >

  <Columns>
      <asp:TemplateField HeaderText="VaccancyName">
          <ItemTemplate>
              <asp:Label ID="Vacname" runat="server"  Text='<%#Eval("name") %>'></asp:Label>
          </ItemTemplate>
      </asp:TemplateField>


      <asp:TemplateField HeaderText="City">
          <ItemTemplate>
              <asp:Label ID="Vaccity" runat="server" Text='<%#Eval("place") %>'></asp:Label>
          </ItemTemplate>
       </asp:TemplateField>

      <asp:TemplateField HeaderText="Country">
          <ItemTemplate>
              <asp:Label ID="Vaccountry" runat="server" Text='<%#Eval("country") %>'></asp:Label>
          </ItemTemplate>
     </asp:TemplateField>

     </Columns>
 </asp:GridView>

        <asp:Button Text="Export to Excel" runat="server" OnClick="Unnamed_Click" />

        </form>
   </div>
    
</body>
</html>
