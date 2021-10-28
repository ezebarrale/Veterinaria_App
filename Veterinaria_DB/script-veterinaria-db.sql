CREATE DATABASE VETERINARIA

USE VETERINARIA

/******************************************/
--TABLAS
/******************************************/

CREATE TABLE TIPO_MASCOTAS(
id_tipo_mascota int IDENTITY(1,1) NOT NULL,
descripcion VARCHAR(10) NOT NULL,
fecha_baja DATETIME
CONSTRAINT [pk_tipo_mascota] PRIMARY KEY (id_tipo_mascota))


CREATE TABLE CLIENTES(
id_cliente INT IDENTITY,
nombre VARCHAR(20),
sexo VARCHAR(1),
fecha_baja DATETIME
CONSTRAINT pk_id_cliente PRIMARY KEY (id_cliente))

CREATE TABLE MASCOTAS(
id_mascota INT IDENTITY,
nombre VARCHAR(10),
edad INT,
id_tipo_mascota INT,
fecha_baja DATETIME,
id_cliente INT
CONSTRAINT pk_id_mascota PRIMARY KEY (id_mascota),
CONSTRAINT fk_id_cliente_masc FOREIGN KEY (id_cliente)
REFERENCES CLIENTES (id_cliente),
CONSTRAINT fk_id_tipo_mascota FOREIGN KEY (id_tipo_mascota)
REFERENCES TIPO_MASCOTAS (id_tipo_mascota))


CREATE TABLE ATENCIONES(
id_atencion INT IDENTITY,
fecha_hora DATETIME,
descripcion VARCHAR (200),
id_mascota INT,
importe_atencion DECIMAL (8,2),
fecha_baja DATETIME
CONSTRAINT pk_id_atencion PRIMARY KEY (id_atencion),
CONSTRAINT fk_mascota FOREIGN KEY (id_mascota)
REFERENCES MASCOTAS (id_mascota))

CREATE TABLE USUARIOS(
id_usuario int IDENTITY(1,1) NOT NULL,
usuario varchar(10) NOT NULL,
passwrd varchar(10) NOT NULL,
CONSTRAINT pk_id_usuario PRIMARY KEY (id_usuario))

/******************************************/
--PROCEDIMIENTOS
/******************************************/

CREATE PROCEDURE PA_EXISTE_USUARIO
@user varchar(8),
@pass varchar(8),
@existe int OUT
AS
BEGIN
SET @existe = (SELECT 1 FROM USUARIOS
				WHERE usuario = @user
				and passwrd = @pass)

IF(@existe IS NULL)
	SET @existe = ISNULL(@existe, 0)
END

CREATE PROCEDURE PA_TIPO_MASCOTAS
AS
BEGIN
SELECT * FROM TIPO_MASCOTAS
where fecha_baja IS NULL
END

CREATE PROCEDURE PA_TIPO_MASCOTAS_X_ID
@id_tipo int
AS
BEGIN
SELECT * FROM TIPO_MASCOTAS
WHERE id_tipo_mascota = @id_tipo
AND fecha_baja IS NULL
END

CREATE PROCEDURE PA_GUARDAR_TIPO_MASCOTA
@descrip varchar(10),
@id_exito int OUT
AS
BEGIN
INSERT INTO TIPO_MASCOTAS (descripcion) VALUES (@descrip)

set @id_exito = (SELECT SCOPE_IDENTITY())
END

CREATE PROCEDURE PA_ELIMINAR_TIPO_MASCOTA
@id_tipo_mascota int
AS
BEGIN
UPDATE TIPO_MASCOTAS
SET fecha_baja = getdate()
where id_tipo_mascota = @id_tipo_mascota
END

CREATE PROCEDURE PA_EDITAR_TIPO_MASCOTA
@id_tipo_mascota int,
@descripcion varchar(10)
AS
BEGIN
UPDATE TIPO_MASCOTAS
SET descripcion = @descripcion
where id_tipo_mascota = @id_tipo_mascota
END

CREATE PROCEDURE PA_CONSULTAR_CLIENTE
@nombre varchar(20)
AS
BEGIN
SELECT * FROM CLIENTES
WHERE upper(nombre) LIKE upper('%'+@nombre+'%')
AND fecha_baja IS NULL
END

CREATE PROCEDURE PA_CONSULTAR_MASCOTA
@id_cliente int
AS
BEGIN
SELECT * FROM MASCOTAS
WHERE id_cliente = @id_cliente
END

/******************************************/
--INSERCIONES
/******************************************/

INSERT INTO TIPO_MASCOTAS (descripcion) VALUES ('perro')
INSERT INTO TIPO_MASCOTAS (descripcion) VALUES ('gato')
INSERT INTO TIPO_MASCOTAS (descripcion) VALUES ('araña')
INSERT INTO TIPO_MASCOTAS (descripcion) VALUES ('iguana')

INSERT INTO USUARIOS (usuario, passwrd) VALUES ('Admin', 'admin')

INSERT INTO CLIENTES(nombre,sexo) VALUES ('juan', 'M')
INSERT INTO CLIENTES(nombre,sexo) VALUES ('ana', 'F')	
INSERT INTO CLIENTES(nombre,sexo) VALUES ('martina', 'F')	

INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Charlie', 5, 1,2);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Toby', 3, 1,2);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Nini', 2, 2,2);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Sofi', 3, 3,3);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Negro', 4, 4,4);
