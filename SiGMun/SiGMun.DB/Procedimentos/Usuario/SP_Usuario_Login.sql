CREATE PROCEDURE [dbo].[SP_Usuario_Login]
	@Email VARCHAR(50),
	@Senha VARCHAR(50)
AS
BEGIN
    SELECT 
	UsuId,
	UsuNomeCompleto,
	UsuEmail,UsuSenha,
	UsuPerfilId,
	UsuDataCadastro,
	UsuIdUsuario,
	UsuEstado 
	FROM dbo.TB_Usuarios
	WHERE UsuEmail=@Email AND UsuSenha=@Senha
	
END
