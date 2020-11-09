
CREATE PROCEDURE sp_insertar_persona_gerente
	@CURP		VARCHAR(20),
	@RFC		VARCHAR(20),
	@nombre		VARCHAR(20),
	@apellido	VARCHAR(20),
	@fehcaNacim	DATE,
	@calle_p		VARCHAR(20),
	@colonia_p		VARCHAR(20),
	@municipio_p	VARCHAR(20),
	--@codigoPostal_p	INT,
	@estado_p		VARCHAR(20)
AS
BEGIN
	EXEC sp_insertar_domicilio @estado_p, @municipio_p, @calle_p, @colonia_p, 'Persona'

	INSERT INTO Persona (CURP, RFC, Nombre, Apellidos, Fecha_nacimiento, Domicilio)
				VALUES (@CURP, @RFC, @nombre, @apellido, @fehcaNacim,
				(SELECT clave_domicilio FROM Domicilio_persona WHERE (calle = @calle_p AND  colonia = @colonia_p)))
				
END