USE DB_ESCOLA;
-- Declarando uma vari�vel como base de pesquisa
DECLARE @Valor FLOAT;
SET @Valor = 1500;
--LISTANDO TODOS OS CURSOS DE TODAS AS ESCOLAS
--SELECT * FROM TBEscolas, TBCursos 
	--WHERE TBEscolas.Id = TBCursos.IdEscola;
-- Lista com relacionamento, permitindo a sele��o de campos
	SELECT 
	E.Descricao As Escola,
	C.Descricao As Curso,
	E.Endereco As Endere�o,
	C.Preco As Pre�o 
	FROM 
		TBEscolas E, TBCursos C 
	WHERE 
		E.Id = C.IdEscola 
	AND 
		C.Preco>= @Valor;
-- Consultas envolvendo agrupamento e fun��es de agrega��o
-- Apresentar as escolas e a quantidade de cursos por escola
SELECT 
	E.Descricao As Escola,
	E.Telefone AS Telefone, 
	COUNT(C.Descricao) As QuantCursos,
	SUM(C.Preco) As Total
FROM	
TBEscolas E, TBCursos C
WHERE	
	E.Id = C.IdEscola
	GROUP BY 
	E.Descricao, 
	E.Telefone
	
			