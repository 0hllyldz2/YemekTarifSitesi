<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="AnaSayfa.aspx.cs" Inherits="AnaSayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }

        .auto-style7 {
            font-size: x-large;
            color: #FFFFFF;
        }

        .auto-style8 {
            background-color: #9900FF;
        }

        .auto-style10 {
            color: #000000;
        }
    .auto-style11 {
        font-size: x-large;
        color: #FFFFFF;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:DataList ID="DataList2" runat="server" Width="450px">
        <itemtemplate>
            <table class="auto-style6">
                <tr>
                    <td class="auto-style8"><strong>
                        <a href="YemekDetay.aspx?Yemekid=<%# Eval("Yemekid") %>">
                            <asp:Label ID="Label3" runat="server" CssClass="auto-style11" Text='<%# Eval("YemekAd") %>'></asp:Label>
                        </a>
                    </strong></td>
                </tr>
                <tr>
                    <td><strong>Malzemeler:</strong>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("YemekMalzeme") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><strong>Yemek Tarifi:</strong>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("YemekTarif") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><strong><em>Eklenme Tarihi:</em></strong><em><strong>
                        <asp:Label ID="Label6" runat="server" CssClass="auto-style10" Text='<%# Eval("YemekTarih") %>'></asp:Label>
                        &nbsp; -&nbsp; Puan:
                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("YemekPuan") %>' CssClass="auto-style10"></asp:Label>
                    </strong></em></td>
                </tr>
                <tr>
                    <td style="border-bottom-style: groove; border-bottom-width: thick; border-bottom-color: #C0C0C0">&nbsp;</td>
                </tr>
            </table>
        </itemtemplate>
    </asp:DataList>
</asp:Content>

