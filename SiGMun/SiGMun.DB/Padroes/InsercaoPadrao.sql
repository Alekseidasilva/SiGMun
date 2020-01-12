/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
-------------------------Inserir Perfil------------------------------------
EXEC dbo.SP_Perfil_Inserir @PerfilNome = 'Administrador' 
---------------------------Inserir Usuario------------------------------------
EXEC dbo.SP_Usuario_Inserir @UsuNomeCompleto = 'Aleksei da Silva',
                            @UsuEmail = 'Alekseidasilva@hotmail.com',
                            @UsuSenha = '000000',
                            @UsuPerfilId = 1,
                            @UsuDataCadastro = '2020-01-07', 
                            @UsuIdUsuario = 1,
                            @UsuEstado = 1  

INSERT dbo.TB_Generos(GeneroId,GeneroNome)VALUES(1,'MASCULINO'),(2,'FEMENINO')
INSERT dbo.TB_EstadoCivil(EstadoCivilId,EstadoCivilNome)VALUES(1,'SOLTEIRO'),(2,'CASADO'),(3,'DIVORCIADO'),(4,'VIÚVO')

-- BEGIN
--DECLARE @@NM int 
--DECLARE @@ID_AUTO INT
--SELECT @@ID_AUTO=MAX(MUN_ID) FROM TB_MUNICIPE
--SET
--@@ID_AUTO=@@ID_AUTO+1
--IF @@ID_AUTO IS NULL
--SET
--@@ID_AUTO=1
----CAPTURAR OS DADOS PARA Nº MUNICIPE,               
----CONCATENAMOS OS  VALORES E ATRIBUOU A VARIAVEL @@NM 
----SELECT @@NM=CONCAT (BAIRRO.BAI_ID,COMUNA.COM_ID,MUNICIPIO.MUN_ID,P.PROV_ID,@@ID_AUTO)   Codigo Antigo           
--SELECT @@NM=CONCAT (PROVINCIA.PROV_ID,MUNICIPIO.MUN_ID,COMUNA.COM_ID,@@ID_AUTO)   --Codigo Novo
--FROM TB_MUNICIPE MUN
--JOIN TB_BAIRRO BAIRRO ON @MUN_BAIRRO_ACTUAL=BAIRRO.BAI_ID
--JOIN TB_COMUNA COMUNA ON COMUNA.COM_ID = BAIRRO.COM_ID
--JOIN TB_MUNICIPIO MUNICIPIO ON COMUNA.MUN_ID=MUNICIPIO.MUN_ID
--JOIN TB_PROVINCIA PROVINCIA ON MUNICIPIO.PROV_ID=PROVINCIA.PROV_ID