<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="listadoproductos.aspx.cs" Inherits="WebApplication2.listadoproductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table align="center" style="width: 100%">
                <tr>
                    <td style="height: 22px"><div align="center" style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: bold">Listado de Productos</div> </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="grvProducto" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="False" OnPageIndexChanging="grvProducto_PageIndexChanging" OnSelectedIndexChanged="grvProducto_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField DataField="idproducto" HeaderText="Codigo" />
                                <asp:BoundField DataField="nombreProducto" HeaderText="Producto" />
                                <asp:BoundField DataField="idProveedor" HeaderText="Proveedor" />
                                <asp:BoundField DataField="idCategoria" HeaderText="Categoria" />
                                <asp:BoundField DataField="precioUnidad" HeaderText="Precio" />
                                <asp:BoundField DataField="unidadesEnExistencia" HeaderText="Unidades" />
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" ForeColor="#333333" Font-Bold="True" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
