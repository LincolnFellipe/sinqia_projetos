USE DB_VENDAS;

CREATE TABLE TBClientes(
Rg varchar(14) not null,
Nome varchar(60) not null,
Telefone varchar(20) not null,
Email varchar(60) not null, 
PRIMARY KEY(Rg)
)
CREATE TABLE TBPedidos(
Id int  IDENTITY (1,1) not null,
DocCliente varchar(14) not null,
Data datetime not null,
NumeroPedido varchar(20) not null, 
PRIMARY KEY(Id),
FOREIGN KEY(DocCliente) REFERENCES TBClientes(Rg)
);
GO
CREATE TABLE TBCategorias(
Id int IDENTITY (1,1) not null,
Descricao varchar(20) not null,
PRIMARY KEY(Id)
);
CREATE TABLE TBProdutos(
Id int IDENTITY (1,1) not null,
IdCategoria int not null,
Descricao varchar(50) not null,
Unidade varchar(10) not null, 
Foto varbinary(MAX) not null, 
MimeType varchar(20) not null, 
PRIMARY KEY(Id),
FOREIGN KEY(IdCategoria) REFERENCES TBCategorias(Id)
);
GO
CREATE TABLE TBItens(
Id int IDENTITY (1,1) not null,
IdPedido int not null,
IdProduto int not null,
Quantidade float not null, 
PRIMARY KEY(Id),
FOREIGN KEY(IdPedido) REFERENCES TBPedidos(Id),
FOREIGN KEY(IdProduto) REFERENCES TBProdutos(Id)
);
GO



