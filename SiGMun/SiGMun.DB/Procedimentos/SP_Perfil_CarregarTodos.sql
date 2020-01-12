CREATE PROCEDURE [dbo].[SP_Perfil_CarregarTodos]
AS
BEGIN
    	SELECT PerfilId,PerfilNome FROM dbo.TB_Perfil
END


