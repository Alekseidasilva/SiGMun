CREATE TABLE [dbo].[TB_TiposDocumentos]
(
	DocumentoId INT NOT NULL,
	DocumentoNome VARCHAR(100)NOT NULL,
	DocumentoUsuarioId INT NOT NULL

	CONSTRAINT PK_DocumentoId PRIMARY KEY (DocumentoId)
	CONSTRAINT FK_UsuarioQCadastraODocumento FOREIGN KEY (DocumentoUsuarioId) REFERENCES dbo.TB_Usuarios
)
