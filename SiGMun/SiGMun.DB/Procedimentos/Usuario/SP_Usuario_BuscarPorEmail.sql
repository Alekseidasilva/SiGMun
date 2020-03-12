CREATE PROCEDURE [dbo].[SP_Usuario_BuscarPorEmail]
	@UsuEmail VARCHAR(100)
	
AS
BEGIN
    SELECT 
	
	UsuEmail
	
	FROM dbo.TB_Usuarios
END