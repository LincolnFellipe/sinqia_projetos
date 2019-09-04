USE DB_CLINICA;

CREATE TABLE TBPaciente(
Rg varchar(14) not null,
Nome varchar(60) not null,
Telefone varchar(20) not null,
Email varchar(60) not null, 
PRIMARY KEY(Rg)
);
GO

CREATE TABLE TBMatemed(
CodigoMateriais int IDENTITY(1,1),
Mat_Id int not null,
Med_Id int not null,
Mat_Descricao varchar(50) not null,
Med_Descricao varchar(100) not null,
Mat_Preco money not null,
Med_Preco money not null,
Mat_Uni int not null,
Med_Uni float not null,
PRIMARY KEY(CodigoMateriais)
);
GO

CREATE TABLE TBTratamento(
Id int IDENTITY(1,1) not null,
Descricao varchar(80) not null,
Preco money not null,
Duracao datetime not null,
Qtd_Mat int not null,
Qtd_Med float not null,
PRIMARY KEY(Id),
);
GO

CREATE TABLE TBConvenios(
Id Varchar(14) not null, 
IdPaciente varchar(14) not null,
ValorPagarConvenio money not null,
ValorPagarMed money not null,
ValorPagarMat money not null,
ValorConsumido money not null
PRIMARY KEY(IdPaciente),
FOREIGN KEY(Id) REFERENCES TBPaciente(Rg)
);
GO

CREATE TABLE TBProcPac(
IdProc int not null IDENTITY(1,1),
Paciente varchar(14) not null,
Proced_Paci int not null,
Data_Proc datetime not null,
PRIMARY KEY(IdProc),
FOREIGN KEY (Paciente) REFERENCES TBPaciente(Rg),
FOREIGN KEY (Proced_Paci) REFERENCES TBTratamento(Id),
);
GO

CREATE TABLE TBUtilizados(
IdUtilizados int not null IDENTITY(1,1),
IdMatemed int not null,
IdTratamento int not null,
Quantidade float not null,
ValorTot money not null,
PRIMARY KEY (IdUtilizados),
FOREIGN KEY (IdMatemed) REFERENCES TBMatemed(CodigoMateriais),
FOREIGN KEY (Idtratamento) REFERENCES TBTratamento(Id)
);


ALTER TABLE TBConvenios DROP  COLUMN ValorPagarConvenio;
ALTER TABLE TBConvenios DROP  COLUMN ValorPagarMed;
ALTER TABLE TBConvenios DROP  COLUMN ValorPagarMat;
ALTER TABLE TBConvenios DROP  COLUMN ValorConsumido;
ALTER TABLE TBConvenios ADD Descricao varchar(50) not null;