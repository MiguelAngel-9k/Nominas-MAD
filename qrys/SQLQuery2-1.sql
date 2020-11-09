USE [NOMINA_EMPRESAS]
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_domicilio]    Script Date: 07/11/2020 12:10:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_insertar_domicilio]
	@codigoPostal	INT,
	@estado			VARCHAR(20),
	@municipio		VARCHAR (20),
	@calle			VARCHAR (20),
	@colonia		VARCHAR (20),
	@OPC			CHAR(1)
AS
BEGIN
	INSERT INTO Estado (estado) VALUES (@estado)
	INSERT INTO Municipio(codigo_postal,municipio, estado) 
		VALUES (@codigoPostal,@municipio, (SELECT clave_estado FROM Estado WHERE estado = @estado))
		print('se inserto el domicilio')
	
	IF (@OPC = 'Empresa')
	BEGIN
		INSERT INTO Domicilio_fiscal(calle, colonia, municipio)
			VALUES (@calle, @colonia, @codigoPostal)
			print('se inserto empresa')
	END
	IF(@OPC = 'Persona')
	BEGIN
		INSERT INTO Domicilio_persona(calle, colonia, municipio)
			VALUES (@calle, @colonia, @codigoPostal)
	END		
END
