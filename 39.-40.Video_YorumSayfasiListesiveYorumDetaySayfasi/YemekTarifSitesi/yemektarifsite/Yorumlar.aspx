<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Yorumlar.aspx.cs" Inherits="Yorumlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style4 {
            background-color: #C0C0C0;
        }

        .auto-style5 {
            text-align: left;
            width: 280px;
        }

        .auto-style6 {
            text-align: right;
        }

        .auto-style7 {
            font-size: large;
        }

        .auto-style8 {
            text-align: right;
            width: 70px;
        }

        .auto-style9 {
            font-weight: bold;
            font-size: x-large;
        }

        .auto-style10 {
            width: 30px;
        }

        .auto-style11 {
            width: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style4" Height="35px">
        <table class="auto-style1">
            <tr>
                <td class="auto-style10"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style9" Height="30px" Text="+" Width="30px" OnClick="Button1_Click" />
                </strong></td>
                <td class="auto-style11"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style9" Height="30px" Text="-" Width="30px" OnClick="Button2_Click" />
                </strong></td>
                <td>ONAYLANAN YORUM LİSTESİ</td>
            </tr>
        </table>
        <br />
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="450px">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style7" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                        </td>
                        <td class="auto-style8">
                            <%--<a href="Yemekler.aspx?Yemekid=<%# Eval("Yemekid") %>&islem=sil">--%>
                            <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/icons/delete2.png" Width="30px" />
                            </a>
                        </td>
                        <td class="auto-style6">
                            <a href="YorumDetay.aspx?Yorumid=<%# Eval("Yorumid") %>">
                                <asp:Image ID="Image3" runat="server" Height="40px" ImageUrl="~/icons/update2.png" Width="40px" />
                            </a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel3" runat="server" CssClass="auto-style4" Height="35px">
        <table class="auto-style1">
            <tr>
                <td class="auto-style10"><strong>
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style9" Height="30px" Text="+" Width="30px" OnClick="Button3_Click" />
                </strong></td>
                <td class="auto-style11"><strong>
                    <asp:Button ID="Button4" runat="server" CssClass="auto-style9" Height="30px" Text="-" Width="30px" OnClick="Button4_Click" />
                </strong></td>
                <td>ONAYSIZ YORUM LİSTESİ</td>
            </tr>
        </table>
        <br />
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <asp:DataList ID="DataList2" runat="server" Width="450px">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style7" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                        </td>
                        <td class="auto-style8">
                            <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/icons/delete2.png" Width="30px" />
                            </a>
                        </td>
                        <td class="auto-style6">
                            <a href="YorumDetay.aspx?Yorumid=<%# Eval("Yorumid") %>">
                                <asp:Image ID="Image3" runat="server" Height="40px" ImageUrl="~/icons/update2.png" Width="40px" />
                            </a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
</asp:Content>
