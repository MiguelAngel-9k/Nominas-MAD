USE NOMINA_EMPRESAS;
SELECT*FROM Empresa
SELECT*FROM Domicilio_fiscal;
SELECT*FROM Municipio;
SELECT*FROM Estado;
SELECT*FROM Empleado;
SELECT*FROM Banco;

INSERT INTO Estado (estado) VALUES ('Nuevo Le�n');
DELETE Estado WHERE estado = 'Nuevo Le�n';
INSERT INTO Domicilio_fiscal (calle, colonia) VALUES ('av independencia', 'huinala')
DELETE Domicilio_fiscal WHERE calle = 'av independencia'

