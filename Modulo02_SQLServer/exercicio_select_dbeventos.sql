USE DB_EVENTOS;
GO
-- selecionar todos os eventos cujo preço esteja entre 500 e 1000 reais
SELECT 
	Descricao As Descrição, 
	Preco As Preço 
	FROM TBEventos 
	WHERE Preco  BETWEEN 500 AND 1000

--selecionar todos os convidados(nome,email) que estiverem inscritos em eventos gratis
SELECT 
	C.Nome,
	C.Email,
	E.Descricao 
FROM 
	TBConvidados,
	TBEventos,
	TBConvidados C , TBEventos E
WHERE
	E.Id = C.IdEvento AND E.Preco = 0

-- apresentar a quantidade de convidados por evento (exbir o nome do evento e a quantidade)
SELECT 
	E.Descricao As Evento, 
	COUNT(E.Descricao) As QuantConvidados
FROM	
	TBEventos E, TBConvidados C
WHERE	
	E.Id = C.IdEvento
	GROUP BY 
	E.Descricao 
	--Apresentar o valor arrecadado por evento(apresentar o nome do evento e o total pago pelos convidados)
SELECT 
	E.Descricao As Descrição, 
	SUM(E.Preco) As ValorTotal
FROM 
	TBConvidados C , TBEventos E
	WHERE
	E.Id = C.IdEvento
	GROUP BY E.Descricao
