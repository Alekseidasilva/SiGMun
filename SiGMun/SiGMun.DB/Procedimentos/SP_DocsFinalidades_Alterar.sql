CREATE PROCEDURE [dbo].[SP_DocsFinalidades_Alterar]
@FinalidadeId INT,
@FinalidadeNome VARCHAR(max),
@FinalidadeEstado BIT,
@FinalidadeusuarioId int
AS
BEGIN
    UPDATE dbo.TB_DocsFinalidades SET
    FinalidadeNome=@FinalidadeNome,
    FinalidadeEstado=@FinalidadeEstado,
    FinalidadeusuarioId=@FinalidadeusuarioId
    WHERE
    FinalidadeId=@FinalidadeId
END