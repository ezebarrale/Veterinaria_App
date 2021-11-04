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
nombre VARCHAR(20),
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
descripcion VARCHAR (100),
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
GO

CREATE PROCEDURE PA_REPORTE
AS
BEGIN
	SELECT m.id_mascota 'CODIGO', m.nombre 'NOMBRE', m.edad 'EDAD',  c.nombre 'DUEÑO', count(a.id_atencion) 'CANTIDAD'
	FROM MASCOTAS m
	JOIN ATENCIONES a on a.id_mascota = m.id_mascota
	JOIN CLIENTES c on c.id_cliente = m.id_cliente
	WHERE YEAR(a.fecha_hora) = YEAR(GETDATE())
	GROUP BY m.id_mascota, m.nombre , m.edad,  c.nombre
END

GO

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

GO

CREATE PROCEDURE PA_TIPO_MASCOTAS
AS
BEGIN
SELECT * FROM TIPO_MASCOTAS
where fecha_baja IS NULL
END

GO

CREATE PROCEDURE PA_TIPO_MASCOTAS_X_ID
@id_tipo int
AS
BEGIN
SELECT * FROM TIPO_MASCOTAS
WHERE id_tipo_mascota = @id_tipo
AND fecha_baja IS NULL
END

GO

CREATE PROCEDURE PA_GUARDAR_TIPO_MASCOTA
@descrip varchar(10),
@id_exito int OUT
AS
BEGIN
INSERT INTO TIPO_MASCOTAS (descripcion) VALUES (@descrip)

set @id_exito = (SELECT SCOPE_IDENTITY())
END

GO

CREATE PROCEDURE PA_ELIMINAR_TIPO_MASCOTA
@id_tipo_mascota int
AS
BEGIN
UPDATE TIPO_MASCOTAS
SET fecha_baja = getdate()
where id_tipo_mascota = @id_tipo_mascota
END

GO

CREATE PROCEDURE PA_EDITAR_TIPO_MASCOTA
@id_tipo_mascota int,
@descripcion varchar(10)
AS
BEGIN
UPDATE TIPO_MASCOTAS
SET descripcion = @descripcion
where id_tipo_mascota = @id_tipo_mascota
END

GO

CREATE PROCEDURE PA_CONSULTAR_MASCOTA
@id_cliente int
AS
BEGIN
SELECT m.*, tm.descripcion 'nombre_tipo'
FROM MASCOTAS m
JOIN TIPO_MASCOTAS tm on tm.id_tipo_mascota = m.id_tipo_mascota
WHERE m.id_cliente = @id_cliente
AND m.fecha_baja IS NULL
END

GO

CREATE PROCEDURE PA_GUARDAR_CLIENTES
@nombre varchar(20),
@sexo varchar(1)
AS
BEGIN
	INSERT INTO CLIENTES(nombre,sexo) VALUES (@nombre, @sexo)
END
GO

CREATE PROCEDURE PA_CONSULTAR_CLIENTE
@nombre varchar(20)
AS
BEGIN
SELECT * FROM CLIENTES
WHERE upper(nombre) LIKE upper('%'+@nombre+'%')
AND fecha_baja IS NULL
END

GO

CREATE PROCEDURE PA_SIGUIENTE_ID_CLIENTE
@id_cliente INT OUT
AS
BEGIN
declare @id int
SET @id = (SELECT MAX(id_cliente) FROM CLIENTES )

	IF(@id IS NULL)
	BEGIN
		SET @id_cliente = IDENT_CURRENT('dbo.CLIENTES')
		RETURN
	END
	
	SET @id_cliente =(IDENT_CURRENT('dbo.CLIENTES') + IDENT_INCR('dbo.CLIENTES'))	
END

GO

CREATE PROCEDURE PA_CONSULTAR_INFO_COMPLETO
@id_cliente int
AS
BEGIN
SELECT m.* ,tm.descripcion 'nombre_tipo'
FROM MASCOTAS m
JOIN TIPO_MASCOTAS tm on tm.id_tipo_mascota = m.id_tipo_mascota
WHERE m.id_cliente = @id_cliente
AND m.fecha_baja IS NULL
END

GO

CREATE PROCEDURE PA_NEXT_ID_ATENCION
@id_atencion INT OUT
AS
BEGIN
declare @id int
SET @id = (SELECT MAX(id_atencion) FROM ATENCIONES )

	IF(@id IS NULL)
	BEGIN
		SET @id_atencion = IDENT_CURRENT('dbo.ATENCIONES')
		RETURN
	END
	
	SET @id_atencion=(IDENT_CURRENT('dbo.ATENCIONES') + IDENT_INCR('dbo.ATENCIONES'))	
END

GO

CREATE PROCEDURE PA_GUARDAR_ATENCION
@descrip varchar(200),
@imp DECIMAL (8,2),
@id_mascota int
AS
BEGIN

	INSERT INTO ATENCIONES(fecha_hora, descripcion, id_mascota, importe_atencion) 
					VALUES(GETDATE(), @descrip, @id_mascota, @imp)

END

GO

CREATE PROCEDURE PA_CONSULTAR_ATENCIONES
@id_mascota int
AS
BEGIN
SELECT * FROM ATENCIONES
WHERE id_mascota = @id_mascota
AND fecha_baja IS NULL
END

GO

CREATE PROCEDURE PA_ACTUALIZAR_ATENCIONES
@id int,
@descripcion varchar(100),
@importe_atencion decimal(8,2)
AS
BEGIN
	UPDATE ATENCIONES
	SET descripcion = @descripcion, importe_atencion = @importe_atencion
	where id_atencion = @id
END

GO

CREATE PROCEDURE PA_ELIMINAR_ATENCIONES
@id int
AS
BEGIN
	UPDATE ATENCIONES
	SET fecha_baja = GETDATE()
	where id_atencion = @id
END

GO

CREATE PROCEDURE PA_ACTUALIZAR_CLIENTES
@nombre varchar(20),
@sexo varchar(1),
@id int
AS
BEGIN
	UPDATE CLIENTES
	SET nombre = @nombre, sexo = @sexo
	where id_cliente = @id
END

GO

CREATE PROCEDURE PA_ELIMINAR_CLIENTES
@id int
AS
BEGIN
	UPDATE CLIENTES
	SET fecha_baja = GETDATE()
	where id_cliente = @id
END

GO

CREATE PROCEDURE PA_CONSULTAR_CLIENTE_X_ID
@id int
AS
BEGIN
SELECT * FROM CLIENTES
WHERE id_cliente = @id
END

GO

CREATE PROCEDURE PA_GUARDAR_MASCOTAS
@id_cliente int,
@nombre varchar(20),
@edad int,
@id_tipo_mascota int
AS
BEGIN
	INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES (@nombre, @edad, @id_tipo_mascota, @id_cliente);
END

CREATE PROCEDURE PA_ACTUALIZAR_MASCOTAS
@id int,
@nombre varchar(20),
@edad int,
@id_tipo_mascota int
AS
BEGIN
	UPDATE MASCOTAS
	SET nombre = @nombre, edad = @edad, id_tipo_mascota = @id_tipo_mascota
	where id_mascota = @id
END

GO

CREATE PROCEDURE PA_ELIMINAR_MASCOTAS
@id int
AS
BEGIN
	UPDATE MASCOTAS
	SET fecha_baja = GETDATE()
	where id_mascota = @id
END

GO

CREATE PROCEDURE PA_SIGUIENTE_ID_MASCOTA
@id_mascota INT OUT
AS
BEGIN
declare @id int
SET @id = (SELECT MAX(id_mascota) FROM MASCOTAS )

	IF(@id IS NULL)
	BEGIN
		SET @id_mascota = IDENT_CURRENT('dbo.MASCOTAS')
		RETURN
	END
	
	SET @id_mascota =(IDENT_CURRENT('dbo.MASCOTAS') + IDENT_INCR('dbo.MASCOTAS'))	
END

GO

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
INSERT INTO CLIENTES(nombre,sexo) VALUES ('monica', 'F')
INSERT INTO CLIENTES(nombre,sexo) VALUES ('gabriel', 'F')
INSERT INTO CLIENTES(nombre,sexo) VALUES ('daniela', 'F')

INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Charlie', 5, 1,2);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Toby', 3, 1,2);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Nini', 2, 2,2);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Sofi', 3, 3,3);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Negro', 4, 4,1);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Roque', 4, 1,4);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Brisa', 4, 2,4);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Laika', 2, 2,6);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Pongo', 1, 1,6);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Dama', 1, 2,5);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Golfo', 5, 1,4);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Titi', 2, 1,1);

INSERT INTO ATENCIONES(fecha_hora, descripcion, id_mascota, importe_atencion) VALUES (GETDATE(), 'Vacuna zzzz', 1, 1200)
