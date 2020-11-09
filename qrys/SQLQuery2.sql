
CREATE PROCEDURE sp_insertar_emrpesa
	@calle_e			VARCHAR(20),
	@colonia_e			VARCHAR(20),
	@municipio_e		VARCHAR(20),
	@codigoPostal_e		INT,
	@estado_e			VARCHAR(20),
	@razonSocial		VARCHAR(20),
	@registroPatronal	VARCHAR(20),
	@RFC				VARCHAR(20),
	@fechaInOp			DATE
	
AS
BEGIN
	EXEC sp_insertar_domicilio_fiscal @estado_e, @municipio_e, @calle_e, @colonia_e, 'Empresa'
	INSERT INTO Empresa (razon_social, domicilio_fiscal, registro_patronal, RFC, fecha_in_op, gerente_general)
		VALUES (@razonSocial, (SELECT clave_domicilio FROM Domicilio_fiscal WHERE calle = @calle_e AND colonia = @colonia_e )
		, @registroPatronal, @RFC, @fechaInOp, 101 ) 	
END


