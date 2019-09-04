USE DB_EVENTOS;
GO
-- INSERIR DADOS NA TABELA TBEVENTOS (4 EVENTOS) 
--OBS: AS DATAS PODEM SER FORNECIDAS NOS FORMATOS MM/DD/YYYY OU YYYY/MM/DD  
INSERT INTO TBEventos (Descricao,Responsavel,Data,Preco)
VALUES ('PALESTRA JAVASCRIPT','PROF. JOÃO','2019-08-12',500),
		('PALESTRA DELL','PROF. JOSÉ','2019-05-01',2200),
		('FESTA FORMATURA','JORGE DA SILVA JUNIOR','2019-07-09',22500),
		('HACKATON FACEBOOK','MARCK ZUCKERBERG','2019-04-25',8000);

INSERT INTO TBConvidados(Cpf,IdEvento,Nome,Telefone,Email)
VALUES  ('12563987541',1,'Clodosvaldo','11-25369874','clodosvaldo@hotmail.com'),
		('15545785546',1,'Jorgina','11-46578741','jorgina412@hotmail.com'),
		('54851324456',2,'Ricardo','11-41548796','ricardao58@yahoo.com'),
		('36985274127',2,'Leoncio','11-21366985','leoncio432@gmail.com'),
		('63985274123',3,'Carmem','11-47856325','c.almeida12@gmail.com'),
		('89896352144',3,'Denise','11-15875623','denam@hotmail.com'),
		('65478932145',4,'Eliseu','11-36923695','elieli@gmail.com'),
		('58946544233',4,'Paulo','11-66321542','paulinho@hotmail.com');

		--Transferindo dados da tabela TBEventosBackup para a tabela TBEventos, mediante consulta

		INSERT INTO TBEventos (Descricao,Responsavel,Data,Preco)
		SELECT Descricao,Responsavel,Data,Preco FROM TBEventosBackup;

		SELECT * FROM TBEventos;

		--------------------------- Removendo elementos adicionados a mais--------------------------------------
									DELETE FROM TBEventos WHERE Id >= 16 -- (A partir da ID 16 ele apagará)
		--------------------------------------------------------------------------------------------------------