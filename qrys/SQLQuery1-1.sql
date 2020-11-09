USE NOMINA_EMPRESAS;
SELECT*FROM Empresa;
SELECT*FROM Domicilio_fiscal;
exec sp_insertar_emrpesa  'jose maria morelos','centro', 'monterrey', '6400', 'nuevo leon', 'mi razon social', 'mi registro patronal', 'CUPU800825569', '20201107'
delete from Empresa where gerente_general =  101;
