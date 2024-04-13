<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Hakkimizda.aspx.cs" Inherits="Hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style8 {
            color: #FFFFFF;
            font-size: xx-large;
            text-align: left;
            background-color: #9900FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style8"><strong>Hakkımızda</strong></td>
        </tr>
    </table>
    <asp:DataList ID="DataList2" runat="server" Width="450px">
        <ItemTemplate>
            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Metin") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>
    <br />
    <asp:Image runat="server" Height="200px" Width="450px" ImageUrl="~/image/hakkimizda.jpg"></asp:Image>
    <br /> <br />
</asp:Content>
