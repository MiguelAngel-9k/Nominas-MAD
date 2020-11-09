
CREATE PROCEDURE sp_insertar_domicilio
	@estado		VARCHAR(20),
	@municipio	VARCHAR (20),
	@calle		VARCHAR (20),
	@colonia	VARCHAR (20),
	@OPC		CHAR(1)
AS
BEGIN
	INSERT INTO Estado (estado) VALUES (@estado)
	INSERT INTO Municipio(municipio, estado) 
		VALUES (@municipio, (SELECT clave_estado FROM Estado WHERE estado = @estado))
	
	IF (@OPC = 'Empresa')
	BEGIN
		INSERT INTO Domicilio_fiscal(calle, colonia, municipio)
			VALUES (@calle, @colonia, (
			SELECT codigo_postal FROM Municipio WHERE municipio = @municipio
			))
	END
	IF(@OPC = 'Persona')
	BEGIN
		INSERT INTO Domicilio_persona(calle, colonia, municipio)
			VALUES (@calle, @colonia, (
				SELECT codigo_postal FROM Municipio WHERE municipio = @municipio
			))
	END		
END
