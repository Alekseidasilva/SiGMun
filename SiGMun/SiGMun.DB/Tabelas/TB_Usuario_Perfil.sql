CREATE TABLE [dbo].[TB_Usuario_Perfil]
(
	UsuPerilId INT NOT NULL,
	UsuId int not null,
	UsuIdPerfil int not null

	CONSTRAINT PK_Usuario_Perfil_Id PRIMARY KEY (UsuPerilId),
    CONSTRAINT FK_UsuarioId FOREIGN KEY (UsuId) REFERENCES TB_Usuarios,
    CONSTRAINT FK_UsuIDdoPerfil FOREIGN KEY (UsuIdPerfil) REFERENCES TB_Perfil_Usuario

)
