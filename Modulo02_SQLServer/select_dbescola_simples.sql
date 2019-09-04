-- Trabalhando com consultas simples
USE DB_ESCOLA;
GO
--LISTANDO TODAS AS ESCOLAS
SELECT * FROM TBEscolas;
-- LISTANDO APENAS O NOME E O TELEFONE
SELECT Descricao,Telefone FROM TBEscolas;
--DANDO APELIDOS PARA AS CONSULTAS
SELECT 
Descricao AS Descrição,
Telefone AS Tel
FROM TBEscolas;
--FORMA 4
SELECT
E.Descricao, E.Endereco 
FROM TBEscolas E
-----------------------------USANDO RESTRIÇÕES---------------------------------------------
SELECT * FROM TBEscolas WHERE Descricao LIKE 'F%'; 
SELECT * FROM TBEscolas WHERE Id BETWEEN 2 AND 5 AND Endereco LIKE 'Av%';  
