CREATE PROCEDURE [dbo].[SP_Perfil_Inserir]	
	@PerfilNome VARCHAR(50)
AS
DECLARE @@IdAuto int
SELECT @@IdAuto=MAX(PerfilId) FROM dbo.TB_Perfil
IF @@IdAuto IS NULL
BEGIN
    SET @@IdAuto=0
    set @@IdAuto=@@IdAuto+1
END
ELSE
BEGIN
SET @@IdAuto=@@IdAuto+1
END
BEGIN
    INSERT dbo.TB_Perfil(PerfilId,PerfilNome)
    VALUES (@@IdAuto,@PerfilNome)
END
