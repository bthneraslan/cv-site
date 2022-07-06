<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Deneyimler.aspx.cs" Inherits="Deneyimler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>BAŞLIK</th>
                <th>ALT BAŞLIK</th>
                <th>AÇIKLAMA</th>
                <th>TARİH</th>
                <th>İŞLEMLER</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>

                        <tr>
                            <th><%# Eval("ID") %></th>
                            <td><%# Eval("BASLIK") %></td>
                            <td><%# Eval("ALTBASLIK") %></td>
                            <td><%# Eval("ACIKLAMA") %></td>
                            <td><%# Eval("TARIH") %></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "DeneyimSil.aspx?ID=" + Eval("ID") %>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                                <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "DeneyimGuncelle.aspx?ID="+ Eval("ID") %>' runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>
                            </td>
                        </tr>

                    </ItemTemplate>
                </asp:Repeater>
            </tbody>

        </table>
        <asp:HyperLink ID="HyperLink3" NavigateUrl="~/DeneyimEkle.aspx" runat="server" CssClass="btn btn-success">Deneyim Ekle</asp:HyperLink>
    </form>

</asp:Content>

