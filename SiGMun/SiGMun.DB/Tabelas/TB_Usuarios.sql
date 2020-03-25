CREATE TABLE [dbo].[TB_Usuarios]
(
	[UsuId] INT NOT NULL, 
    [UsuNomeCompleto] VARCHAR(100) NULL, 
    [UsuEmail] VARCHAR(200) NULL, 
    [UsuSenha] VARCHAR(200) NULL, 
    [UsuPerfilId] INT NULL, 
    [UsuDataCadastro] DATE NULL, 
    [UsuIdUsuario] INT NULL, 
    [UsuEstado] BIT NULL
    CONSTRAINT PK_UsuarioId PRIMARY KEY (UsuId),
    CONSTRAINT FK_UsuarioQCadastra FOREIGN KEY (UsuIdUsuario) REFERENCES TB_Usuarios,
    CONSTRAINT FK_PerfilQPertenceOUsuario FOREIGN KEY (UsuPerfilId) REFERENCES TB_Perfil_Usuario
    
)
