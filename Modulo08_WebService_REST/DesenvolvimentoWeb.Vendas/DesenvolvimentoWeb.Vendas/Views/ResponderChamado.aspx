<%@ Page  Async="true" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ResponderChamado.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ResponderChamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <div class="container"> 
        <h2 class="text-center text-primary">Resposta a chamados</h2>
<div class="row">
      <div class="col-md-7">
          <%-- Chamado --%>
            <div class="form-group">
                <asp:Label ID="chamadoLabel" runat="server" Text="Chamado:"></asp:Label>
                <asp:DropDownList ID="chamadoDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
          <%-- Botão --%>
            <div class="form-group">
            <asp:Button ID="buscarButton" CssClass="btn btn-info" 
                runat="server" Text="Buscar Chamado" OnClick="buscarButton_Click"/>
                 <%-- Botão --%>
            <asp:Button ID="excluirButton" CssClass="btn btn-danger" 
                runat="server" Text="Excluir Chamado" OnClick="excluirButton_Click"/>
                </div>
          <%--Buscar Chamado --%>
            <div class="form-group">
                 <asp:Label ID="buscarLabel" runat="server" Text="Descrição:"></asp:Label>
                <asp:TextBox ID="descricaoTextBox" CssClass="form-control text-primary" ReadOnly="true" TextMode="MultiLine" Rows="4" Columns ="50" runat="server"></asp:TextBox>

            </div>
           

          <%--Responder Chamado --%>
            <div class="form-group">
                 <asp:Label ID="responderLabel" runat="server" Text="Responder:"></asp:Label>
                <asp:TextBox ID="responderTextBox" CssClass="form-control" TextMode="MultiLine" Rows="4" Columns="50" runat="server"></asp:TextBox>
            </div>
                  <%-- Botão --%>
            <div class="form-group">
            <asp:Button ID="enviarButton" CssClass="btn btn-primary" 
                runat="server" Text="Responder Chamado" OnClick="enviarButton_Click"/>
                </div>
             <%--Mensagem --%>
                 <div class="form-group" style="width:100%">
                <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
                     </div>
      </div>
</div>
    </div>
</asp:Content>
