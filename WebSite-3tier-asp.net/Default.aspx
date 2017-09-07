<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <th>Student ID</th>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td>

                        <asp:Label ID="LabelID" runat="server" ForeColor="Red"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <th>Student Name</th>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    <td>

                        <asp:Label ID="LabelName" runat="server" ForeColor="Red" Text=""></asp:Label>

                    </td>
                </tr>

                <tr>
                    <th>Student Gender</th>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox></td>
                    <td>

                        <asp:Label ID="LabelGender" runat="server" ForeColor="Red" ></asp:Label>

                    </td>
                </tr>
                <tr>
                    <th>Student Country</th>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>

                    <td>

                        <asp:Label ID="LabelCountry" runat="server" ForeColor="Red" Text=""></asp:Label>

                    </td>
                </tr>

                <tr>
                    <th colspan="3">
                        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />

                    </th>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
