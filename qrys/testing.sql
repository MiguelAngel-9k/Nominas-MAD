SELECT*FROM Domicilio_fiscal
SELECT*FROM Domicilio_persona
SELECT*FROM Estado;
SELECT*FROM Municipio;
SELECT*FROM Empresa;
SELECT*FROM Empleado;
SELECT*FROM Persona
SELECT*FROM Banco
SELECT*FROM Departamento
SELECT*FROM Puesto

exec sp_insertar_domicilio 66634, 'nuevo leon', 'apodaca', 'independencia', 'huinala', 'Empresa';
exec sp_insertar_emrpesa 'jose maria morelos', 'centro', 'razon2', 'registro2', 'rfc2', '20201107';
delete from Domicilio_fiscal where clave_domicilio = 7116
delete from Domicilio_persona where clave_domicilio = 6026
delete from Estado where estado = 'nuevo leon'
delete from Municipio where codigo_postal = 6400
delete from Municipio where codigo_postal = 66634
delete from Empresa where gerente_general = 101;
delete from Persona where CURP  = 'CURP persona';
Delete from Departamento where clave_departamento = 800
delete from puesto where departamento = 800

insert into Estado (estado) values (upper('nuevo leon'))
insert into Estado (estado) values (upper('chihuhua'))
insert into Estado (estado) values (upper('baja california'))
insert into Estado (estado) values (upper('coahuila'))
insert into Estado (estado) values (upper('quintana roo'))
insert into Estado (estado) values (upper('baja california sur'))
insert into Estado (estado) values (upper('ciudad de mexico'))
insert into Estado (estado) values (upper('guadalajara'))
insert into Estado (estado) values (upper('nayarit'))

ALTER TABLE Nomina ALTER COLUMN no_nomina varchar(50)