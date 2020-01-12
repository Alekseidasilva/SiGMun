﻿CREATE TABLE [dbo].[TB_Municipios]
(
	MunicipioId INT NOT NULL,
	MunicipioNome VARCHAR(50)NOT NULL,
	MunicipioProvinciaId INT

	CONSTRAINT PK_MunicipioId PRIMARY KEY (MunicipioId)
	CONSTRAINT FK_ProvinciaQPertenceOMunicipio FOREIGN KEY(MunicipioProvinciaId)REFERENCES dbo.TB_Provincias
)
