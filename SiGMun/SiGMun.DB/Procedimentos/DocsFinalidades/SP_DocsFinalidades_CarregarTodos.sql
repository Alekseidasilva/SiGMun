CREATE PROCEDURE [dbo].[SP_DocsFinalidades_CarregarTodos]
AS
	BEGIN
	    SELECT
		FinalidadeId,
		FinalidadeNome,
		FinalidadeEstado,
		FinalidadeusuarioId 
		FROM dbo.TB_DocsFinalidades
	END
