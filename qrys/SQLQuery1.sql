USE NOMINA_EMPRESAS;
SELECT*FROM Empresa
SELECT*FROM Domicilio_fiscal;
SELECT*FROM Municipio;
SELECT*FROM Estado;
SELECT*FROM Empleado;
SELECT*FROM Banco;

INSERT INTO Estado (estado) VALUES ('Nuevo León');
DELETE Estado WHERE estado = 'Nuevo León';
INSERT INTO Domicilio_fiscal (calle, colonia) VALUES ('av independencia', 'huinala')
DELETE Domicilio_fiscal WHERE calle = 'av independencia'

