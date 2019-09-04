<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroClientes.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    
    <div class="container">
        <h2 class="text-center text-primary">Cadastro de Clientes</h2>
    <div class="row">
        <div class="col-md-5">
            <h3 class="text-center">Forneça os dados</h3>
            <div class="form-group">
                <asp:Label ID="documentoLabel" runat="server" Text="Documento:"></asp:Label>
                <asp:TextBox ID="documentoTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="documentoRequiredFieldValidator" runat="server" 
                ControlToValidate="documentoTextBox" ErrorMessage="O documento deve ser informado" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>

            </div>
            <div class="form-group">
                <asp:Label ID="nomeLabel" runat="server" Text="Nome:"></asp:Label>
                <asp:TextBox ID="nomeTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="nomeRequiredFieldValidator" runat="server" 
                ControlToValidate="nomeTextBox" ErrorMessage="O Nome deve ser informado" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="telefoneLabel" runat="server" Text="Telefone:"></asp:Label>
                <asp:TextBox ID="telefoneTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="telefoneRequiredFieldValidator" runat="server" 
                ControlToValidate="telefoneTextBox" ErrorMessage="O Telefone deve ser informado" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="emailLabel" runat="server" Text="Email:"></asp:Label>
                <asp:TextBox ID="emailTextBox" CssClass="form-control" runat="server" TextMode="Email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" 
                ControlToValidate="emailTextBox" ErrorMessage="O Email deve ser informado" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="emailRegularExpressionValidator" runat="server" ErrorMessage="Email Inválido" ControlToValidate="emailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="text-danger"></asp:RegularExpressionValidator>
            </div>
            
            <div class="form-group">
            <asp:Button ID="enviarButton" CssClass="btn btn-primary" runat="server" Text="Incluir Cliente" OnClick="enviarButton_Click" />
                </div>
             
                 <div class="form-group">
                <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
                     </div>
            
        </div>


        <div class="col-md-7">
            <h3 class="text-center">           Lista de Clientes              </h3>
            <asp:Repeater ID="clientesRepeater" runat="server">
                <HeaderTemplate> 
                   <table class="table table-hover">
                       <thead>
                           <tr>
                               <th>Cpf</th>
                               <th>Nome</th>
                               <th>Telefone</th>
                               <th>Email</th>
                           </tr>
                       </thead>
                       <tbody>
                       </HeaderTemplate>



                <ItemTemplate> 
                    <tr>
                        <th>
                            <asp:Label runat="server" Text='<%# Eval("Documento") %>'> </asp:Label>
                        </th>
                        <td>
                            <asp:Label runat="server" Text='<%# Eval("Nome") %>'> </asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text='<%# Eval("Telefone") %>'> </asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" Text='<%# Eval("Email") %>'> </asp:Label>
                        </td>
                    </tr>


                </ItemTemplate>

                
                
                
                
                <FooterTemplate> 
                    </tbody>
                    </table>

                </FooterTemplate>
                       
            </asp:Repeater>
            


        </div>

    </div>
        </div>
</asp:Content>
