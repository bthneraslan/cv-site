<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Yetenekler.aspx.cs" Inherits="Yetenekler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>YETENEK</th>
                <th>İŞLEMLER</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("ID") %></td>
                            <td><%# Eval("YETENEK") %></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#  "~/YetenekSil.aspx?ID=" +  Eval("ID")%>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                                <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#  "~/YetenekGuncelle.aspx?ID=" +  Eval("ID")%>' CssClass="btn btn-success" runat="server">GÜNCELLE</asp:HyperLink>
                            </td>

                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:HyperLink ID="HyperLink3" NavigateUrl="~/YetenekEkle.aspx" runat="server" CssClass="btn btn-info">Yetenek Ekle</asp:HyperLink>
    </form>
</asp:Content>

