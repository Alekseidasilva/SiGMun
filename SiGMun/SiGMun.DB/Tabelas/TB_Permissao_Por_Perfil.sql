CREATE TABLE [dbo].[TB_Permissao_Por_Perfil]
(
	PermissaoId INT NOT NULL IDENTITY(1,1),
	PermissaoPerfilId INT NOT NULL,
	PermissaoNome VARCHAR(50) NOT NULL,
	PermissaEstado BIT NOT NULL,

	CONSTRAINT PK_PermissaoId PRIMARY KEY (PermissaoId),
    CONSTRAINT FK_PerfilQPermissaoPertence FOREIGN KEY (PermissaoPerfilId) REFERENCES TB_Perfil_Usuario,
)
