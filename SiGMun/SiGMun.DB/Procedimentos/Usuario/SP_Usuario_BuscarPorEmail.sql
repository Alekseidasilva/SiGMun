CREATE PROCEDURE [dbo].[SP_Usuario_BuscarPorEmail]
	@UsuEmail VARCHAR(200)
	
AS
BEGIN
    SELECT 
	
	UsuEmail
	
	FROM dbo.TB_Usuarios
END