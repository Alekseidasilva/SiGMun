﻿CREATE PROCEDURE [dbo].[SP_Usuario_Alterar_Senha]
	@UsuId INT,
	@UsuSenha VARCHAR(50)
    
AS
BEGIN
    UPDATE dbo.TB_Usuarios 
	SET UsuSenha=@UsuSenha
	WHERE UsuId=@UsuId
END