CREATE DATABASE SOFTINT

USE SOFTINT
----------------------------------------------------------------------------------------------------------------------------------
--CREA TABLA USERS
CREATE TABLE Users 
(
	Us_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Us_user CHAR(20) NOT NULL,
	Us_pass CHAR(20) NOT NULL,
	Us_type INT NOT NULL,
	Us_CI CHAR(10) NOT NULL,
	Us_apel CHAR(10) NOT NULL
)

INSERT INTO Users VALUES('pepe','abc123',1,'0923456345','Perinete')
INSERT INTO Users VALUES('juan','abc123',0,'0923456367','Velazco')

----------------------------------------------------------------------------------------------------------------------------------
-- CREA LA TABLA VOTANTES CON PARAMETROS DE ID Y CI ( AQUI SE GUARDA LOS REGISTROS DEL ADMIN )
CREATE TABLE Votantes 
(
	Vot_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Vot_CI CHAR(10) NOT NULL
)

--INSERT INTO Votantes VALUES (0912384589);
--INSERT INTO Votantes VALUES (0912384578);
--INSERT INTO Votantes VALUES (0912384573);

----------------------------------------------------------------------------------------------------------------------------------
-- CREA TABLA PARA GUARDAR VOTANTES QUE YA SUFRAGARON ( SE GENERA AL TRAMITAR EL VOTO LUEGO DE VALIDAR QUE PUEDA VOTAR )
CREATE TABLE YesVot 
(
	Yes_CI CHAR(10) PRIMARY KEY NOT NULL
)
----------------------------------------------------------------------------------------------------------------------------------
-- CREA LA TABLA VOTOS, REGISTRA EL VOTO QUE GENERO EL VOTANTE Y LO ALMACENA CON UN ID EN ORDEN
CREATE TABLE Votos 
(
	Vot_ID  INT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
	Vot_Lista INT 
)


SELECT * FROM Users

select Us_type from Users where Us_user='pepe' and Us_pass='abc123'