USE DB_ESCOLA;
GO
-- Criando stored:procedure capaz de incluir ou alterar um convidado, a alteração ocorrerá se o cpf informado já estiver cadastrado
ALTER PROC pr_incluir_curso
(

	@codigo int,
	@idescola int,
	@descricao varchar(50),
	@cargahoraria int,
	@preco float,
	@status int output                -- 0: Incluido, 1: Alterado

)
AS BEGIN
	IF EXISTS(SELECT @codigo FROM TBCursos WHERE Codigo = @codigo)
	BEGIN
		UPDATE TBCursos SET IdEscola = @idescola, Descricao = @descricao, CargaHoraria = @cargahoraria, Preco = @preco 
		WHERE Codigo = @codigo

		set @status = 1
	END
ELSE
	BEGIN
			INSERT INTO TBCursos(Codigo,IdEscola,Descricao,CargaHoraria,Preco) 
			VALUES (@codigo, @idescola,@descricao,@cargahoraria,@preco)

			set @status = 0
	END 
END