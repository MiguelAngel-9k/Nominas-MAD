
CREATE PROCEDURE sp_insertar_gerente_nomina
	@RFC_EMPRESA		VARCHAR(20),
	@sueldo_base		INT,
	@cant_empleados		INT,
	@CURP				VARCHAR(20),
	@RFC				VARCHAR(20),
	@nombre_p			VARCHAR(20),
	@apellido_p			VARCHAR(20),
	@fehcaNacim			DATE,
	@calle_p			VARCHAR(20),
	@colonia_p			VARCHAR(20),
	@municipio_p		VARCHAR(20),
	@codigoPostal_p		INT,
	@estado_p			VARCHAR(20),
	@sueldo_especifico	INT,
	@nivelSalarial		INT,
	@noCuenta			INT,
	@salarioDiario		INT,
	@NSS				INT,
	@banco				VARCHAR(20),
	@nomina				INT
AS
BEGIN
	--usamos el sp de insertar persona para insertar a la persona que sera el nuevo gerente
	EXEC SP_insertar_persona_gerente @CURP, @RFC, @nombre_p, @apellido_p, @fehcaNacim, @calle_p, @colonia_p, @municipio_p, @estado_p
	--insertamos el nuevo departamento aun no se define el gerente
	INSERT INTO Departamento (empresa, sueldo_base, nombre, cant_empleados)
			VALUES (@RFC_EMPRESA, @sueldo_base, 'Nominas', @cant_empleados)
	--insertamos nuevo puesto 
	INSERT INTO Puesto (empresa, sueldo_esp, nivel_salarial, departamento, nombre_puesto)
			VALUES (@RFC_EMPRESA, @sueldo_base, @nivelSalarial, (
			SELECT clave_departamento FROM Departamento WHERE nombre = 'Nominas' AND empresa = @RFC_EMPRESA),
			'Gerente de Nomina')

	--insertamos al nuevo empleado que sera el gerente
	INSERT INTO Empleado (contrasenia, no_cuenta, departamento, Puesto, salario_diario, NSS, banco, nomina, CURP)
			VALUES (RAND(100), @noCuenta, (
				SELECT clave_departamento FROM Departamento WHERE nombre = 'Nominas' AND empresa = @RFC_EMPRESA
				), (SELECT nombre_puesto FROM Puesto WHERE nombre_puesto = 'Gerente de Nomina')
				, @salarioDiario, @NSS,
				(SELECT clave_banco FROM Banco WHERE banco = @banco ), @nomina, @CURP )

	UPDATE Empresa SET gerEnte_nomina = (SELECT no_empleado FROM Empleado WHERE CURP = @CURP)
END


	