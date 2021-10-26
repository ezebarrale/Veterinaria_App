CREATE DATABASE VETERINARIA

USE VETERINARIA

CREATE TABLE TIPO_MASCOTAS(
	id_tipo_mascota int IDENTITY(1,1) NOT NULL,
	descripcion varchar(50) NULL,
 CONSTRAINT [pk_tipo_mascota] PRIMARY KEY (id_tipo_mascota))

CREATE TABLE USUARIOS(
	id_usuario int IDENTITY(1,1) NOT NULL,
	usuario varchar(50) NOT NULL,
	passwrd varchar(50) NOT NULL,
 CONSTRAINT pk_id_usuario PRIMARY KEY (id_usuario))


CREATE PROCEDURE PA_EXISTE_USUARIO
@user varchar(8),
@pass varchar(8),
@existe int OUT
AS
SET @existe = (SELECT 1 FROM USUARIOS
				WHERE usuario = @user
				and passwrd = @pass)

IF(@existe IS NULL)
	SET @existe = ISNULL(@existe, 0)
/*
declare @salida int
EXECUTE PA_EXISTE_USUARIO 'Admin', 'admin', @salida OUT
select @salida
*/

CREATE PROCEDURE PA_TIPO_MASCOTAS
AS
SELECT * FROM TIPO_MASCOTAS

INSERT INTO TIPO_MASCOTAS (descripcion) VALUES ('perro')
INSERT INTO TIPO_MASCOTAS (descripcion) VALUES ('gato')
INSERT INTO TIPO_MASCOTAS (descripcion) VALUES ('araña')
INSERT INTO TIPO_MASCOTAS (descripcion) VALUES ('iguana')

INSERT INTO USUARIOS (usuario, passwrd) VALUES ('Admin', 'admin')
