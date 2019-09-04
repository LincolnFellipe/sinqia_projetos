<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ChamadosResolvidos.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ChamadosResolvidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

     <div class="container">
        <h2 class="text-center text-primary">Lista de Chamados</h2>


          <%-- Pedido + Cliente --%>
            <div class="form-group">
                <asp:Label ID="IdChamadoLabel" runat="server" Text="Chamado:"></asp:Label>
                <asp:DropDownList ID="IdChamadoDropDownList" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="IdChamadoDropDownList_SelectedIndexChanged"></asp:DropDownList>
            </div>
        <hr />
        <asp:Repeater ID="itensRepeater" runat="server">
            <HeaderTemplate></HeaderTemplate>
            <ItemTemplate>
                <div class="alert alert-secondary">
                    <div style="float: right;">
                    </div>
                    <strong>Chamado:</strong>
                    <asp:Label ID="idChamadoLabel" runat="server" 
                        Text='<%# Eval("ChamadoId") %>'></asp:Label><br />

                    <strong>Data Chamado:</strong>
                    <asp:Label ID="dataLabel" runat="server" 
                        Text='<%# Eval("Data") %>'></asp:Label>

                    <strong>Documento:</strong>
                    <asp:Label ID="documentoLabel" runat="server" 
                        Text='<%# Eval("Documento") %>'></asp:Label><br />

                    <strong>Assunto:</strong>
                    <asp:Label ID="assuntoLabel" runat="server" 
                        Text='<%# Eval("Assunto") %>'></asp:Label><br />
                    <strong>Descricao:</strong>
                    <asp:Label ID="descricaoLabel" runat="server" 
                        Text='<%# Eval("Descricao") %>'></asp:Label><br />

                    <strong>Resposta</strong>
                    <asp:Label ID="respostaLabel" runat="server" 
                        Text='<%# Eval("Resposta") %>'></asp:Label>

                    <strong>Resolvido:</strong>
                    <asp:Label ID="resolvidoLabel" runat="server" 
                        Text='<%# Eval("Resolvido") %>'></asp:Label><br />

               </div>

            </ItemTemplate>
            <FooterTemplate></FooterTemplate>
        </asp:Repeater>
         </div>
</asp:Content>
