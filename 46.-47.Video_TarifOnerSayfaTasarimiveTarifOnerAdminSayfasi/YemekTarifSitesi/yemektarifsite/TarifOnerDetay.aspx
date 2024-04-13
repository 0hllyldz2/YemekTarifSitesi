<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="TarifOnerDetay.aspx.cs" Inherits="TarifOnerDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }

        .auto-style11 {
            text-align: right;
        }

        .auto-style14 {
            margin-left: 40px;
        }

        .auto-style15 {
            margin-left: 80px;
        }

        .auto-style16 {
            font-size: medium;
            font-weight: bold;
        }
        .auto-style17 {
            text-align: right;
            height: 26px;
        }
    </style>
    <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style6">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11"><strong>Tarif Ad:</strong></td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11"><strong>Tarif Malzemeler:</strong></td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11"><strong>Yapılışı:</strong></td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox3" runat="server" Height="100px" Width="200px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11"><strong>Tarif Resim:</strong></td>
                <td class="auto-style15">
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="200px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style17"><strong>Tarif Öneren:</strong></td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox4" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11"><strong>Öneren Mail:</strong></td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox5" runat="server" Height="20px" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style15"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style16" Text="Onayla" Width="205px" />
                    </strong></td>
            </tr>
        </table>
    </asp:Panel>
    <br />
</asp:Content>

