<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="GununYemegi.aspx.cs" Inherits="GununYemegi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            margin-right: 0px;
        }
        .auto-style10 {
            color: #000000;
        }
        .auto-style11 {
            text-align: right;
            color: #000000;
        }
        .auto-style12 {
            font-size: x-large;
            color: #FFFFFF;
            margin-right: 0px;
        }
        .auto-style13 {
            text-align: center;
            background-color: #9900FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style6">
        <tr>
            <td>
                <asp:DataList ID="DataList2" runat="server" CssClass="auto-style7">
                    <ItemTemplate>
                        <table class="auto-style6">
                            <tr>
                                <td class="auto-style13"><strong>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("YemekAd") %>' CssClass="auto-style12"></asp:Label>
                                    </strong></td>
                            </tr>
                        </table>
                        <table class="auto-style6">
                            <tr>
                                <td><span class="auto-style10"><strong>Malzemeler:</strong>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("YemekMalzeme") %>'></asp:Label>
                                    </span>
                                    <table class="auto-style6">
                                        <tr>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                        <table class="auto-style6">
                            <tr>
                                <td class="auto-style10"><strong>Tarif:</strong>
                                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("YemekTarif") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <table class="auto-style6">
                            <tr>
                                <td class="auto-style4">
                                    <asp:Image ID="Image1" runat="server" Height="200px" Width="400px" ImageUrl='<%# Eval("YemekResim") %>' />
                                </td>
                            </tr>
                        </table>
                        <table class="auto-style6">
                            <tr>
                                <td class="auto-style11"><strong>Puan: </strong>
                                    <asp:Label ID="Label6" runat="server" Text='<%# Eval("YemekPuan") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <table class="auto-style6">
                            <tr>
                                <td class="auto-style11"><strong>Eklenme Tarih:</strong> <em>
                                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("YemekTarih") %>'></asp:Label>
                                    </em></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>
</asp:Content>

