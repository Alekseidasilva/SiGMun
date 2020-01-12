﻿CREATE PROCEDURE [dbo].[SP_DocsFinalidades_Inserir]

@FinalidadeNome VARCHAR(max),
@FinalidadeEstado BIT,
@FinalidadeusuarioId int
AS
DECLARE @@IdAuto int
SELECT @@IdAuto=MAX(FinalidadeId) FROM dbo.TB_DocsFinalidades
IF @@IdAuto IS NULL
BEGIN
    SET @@IdAuto=0
END
ELSE
BEGIN
SET @@IdAuto=@@IdAuto+1
END
BEGIN
    INSERT INTO dbo.TB_DocsFinalidades
    (
FinalidadeId,
FinalidadeNome,
FinalidadeEstado,
FinalidadeusuarioId
    )
    VALUES
    (
@@IdAuto,
@FinalidadeNome,
@FinalidadeEstado,
@FinalidadeusuarioId
    )
END
