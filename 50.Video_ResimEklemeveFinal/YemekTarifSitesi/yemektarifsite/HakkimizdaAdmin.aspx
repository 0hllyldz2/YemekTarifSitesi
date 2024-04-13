<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="HakkimizdaAdmin.aspx.cs" Inherits="HakkimizdaAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style4 {
            background-color: #C0C0C0;
        }

        .auto-style10 {
            width: 30px;
        }

        .auto-style9 {
            font-weight: bold;
            font-size: x-large;
        }

        .auto-style11 {
            width: 40px;
        }
        .auto-style12 {
            margin-left: 80px;
        }
        .auto-style13 {
            text-align: center;
            margin-left: 80px;
        }
        .auto-style14 {
            font-weight: bold;
            font-size: large;
        }
        .auto-style15 {
            font-size: medium;
            font-style: italic;
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
                <td>HAKKIMIZDA</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style12"><em>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style15" Height="300px" TextMode="MultiLine" Width="435px"></asp:TextBox>
                    </em></td>
            </tr>
            <tr>
                <td class="auto-style13"><strong>
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style14" OnClick="Button3_Click" Text="Güncelle" Width="280px" />
                    </strong></td>
            </tr>
        </table>
    </asp:Panel>
    <br />
</asp:Content>

