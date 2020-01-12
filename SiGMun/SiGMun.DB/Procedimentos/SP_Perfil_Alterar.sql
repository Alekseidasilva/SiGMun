CREATE PROCEDURE [dbo].[SP_Perfil_Alterar]
	@PerfilId int ,
	@PerfilNome int
AS
BEGIN
    UPDATE dbo.TB_Perfil 
	SET PerfilNome=@PerfilNome
	WHERE PerfilId=@PerfilId
END
