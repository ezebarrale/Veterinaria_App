CREATE DATABASE VETERINARIA

GO
USE VETERINARIA

GO
/******************************************/
--TABLAS
/******************************************/

CREATE TABLE TIPO_MASCOTAS(
id_tipo_mascota int IDENTITY(1,1) NOT NULL,
descripcion VARCHAR(10) NOT NULL,
fecha_baja DATETIME
CONSTRAINT [pk_tipo_mascota] PRIMARY KEY (id_tipo_mascota))

CREATE TABLE VETERINARIOS(
id_veterinario INT IDENTITY,
nombre VARCHAR(20),
sexo VARCHAR(1),
fecha_baja DATETIME
CONSTRAINT pk_id_veterinario PRIMARY KEY (id_veterinario))

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
id_veterinario INT,
fecha_hora DATETIME,
fecha_baja DATETIME
CONSTRAINT pk_id_atencion PRIMARY KEY (id_atencion),
CONSTRAINT fk_atenion_veterinario FOREIGN KEY (id_veterinario)
REFERENCES VETERINARIOS (id_veterinario))

CREATE TABLE DETALLE_ATENCIONES(
id_detalle INT,
id_atencion INT,
id_mascota INT,
descripcion VARCHAR (100),
importe_atencion DECIMAL (8,2)
CONSTRAINT pk_detalle_atencion PRIMARY KEY (id_detalle, id_atencion),
CONSTRAINT fk_detalle_atencion_mascota FOREIGN KEY (id_mascota)
REFERENCES MASCOTAS (id_mascota),
CONSTRAINT fk_atencion_detalle_atencion FOREIGN KEY (id_atencion)
REFERENCES ATENCIONES (id_atencion))


CREATE TABLE USUARIOS(
id_usuario int IDENTITY(1,1) NOT NULL,
usuario varchar(10) NOT NULL,
passwrd varchar(10) NOT NULL,
CONSTRAINT pk_id_usuario PRIMARY KEY (id_usuario))

/******************************************/
--PROCEDIMIENTOS
/******************************************/


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

GO

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


/******************************************/
--PROCEDIMIENTOS DE ATENCIONES NUEVOS
/******************************************/

GO

CREATE PROCEDURE PA_REPORTE_MES --OK
@mes int
AS
BEGIN
	SELECT tm.id_tipo_mascota 'CODIGO', tm.descripcion 'TIPO_MASCOTA', count(a.id_atencion) 'CANTIDAD'
	FROM MASCOTAS m
	JOIN DETALLE_ATENCIONES da on da.id_mascota = m.id_mascota
	JOIN ATENCIONES a on a.id_atencion = da.id_atencion
	JOIN TIPO_MASCOTAS tm on tm.id_tipo_mascota = m.id_tipo_mascota
	WHERE MONTH(a.fecha_hora) = @mes
	AND a.fecha_baja IS NULL
	GROUP BY tm.id_tipo_mascota, tm.descripcion
END


---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
GO

CREATE PROCEDURE PA_NEXT_ID_ATENCION --OK
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



---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
GO

CREATE PROCEDURE PA_GUARDAR_ATENCION --OK
@id_veterinario int,
@id_atencion int OUT
AS
BEGIN

	INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(@id_veterinario, GETDATE())

	SELECT @id_atencion = SCOPE_IDENTITY();

END

---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
GO

CREATE PROCEDURE PA_GUARDAR_DETALLE_ATENCION --OK
@id_detalle int,
@descrip varchar(200),
@imp DECIMAL (8,2),
@id_mascota int,
@id_atencion int
AS
BEGIN

	INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
					VALUES( @id_detalle, @id_atencion, @id_mascota, @descrip, @imp)

END

---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
GO

CREATE PROCEDURE PA_CONSULTAR_ATENCIONES --OK
@id_mascota int
AS
BEGIN
	SELECT a.id_atencion, a.id_veterinario, a.fecha_hora, a.fecha_baja, v.nombre
	FROM ATENCIONES a
	JOIN DETALLE_ATENCIONES da on da.id_atencion = a.id_atencion
	JOIN VETERINARIOS v on v.id_veterinario = a.id_veterinario
	WHERE da.id_mascota = @id_mascota
	AND a.fecha_baja IS NULL
	group by a.id_atencion, a.id_veterinario, a.fecha_hora, a.fecha_baja, v.nombre
END

---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
GO

CREATE PROCEDURE PA_CONSULTAR_DETALLE_ATENCIONES --OK
@id_atencion int
AS
BEGIN
SELECT da.id_detalle 'CODIGO', m.nombre 'MASCOTA', da.descripcion 'DESCRIPCION', da.importe_atencion 'IMPORTE'
FROM DETALLE_ATENCIONES da
JOIN MASCOTAS m on m.id_mascota = da.id_mascota
WHERE da.id_atencion = @id_atencion
END

---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
GO

CREATE PROCEDURE PA_ACTUALIZAR_ATENCIONES --OK
@id_atencion int,
@id_vaterinario int
AS
BEGIN
	UPDATE ATENCIONES
	SET id_veterinario = @id_vaterinario
	where id_atencion = @id_atencion
END

---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
GO

CREATE PROCEDURE PA_ELIMINAR_ATENCIONES --OK
@id_atencion int
AS
BEGIN
	UPDATE ATENCIONES
	SET fecha_baja = GETDATE()
	where id_atencion = @id_atencion
END

---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
GO

CREATE PROCEDURE PA_CONSULTAR_VETERINARIOS --OK
AS
BEGIN

	SELECT * FROM VETERINARIOS
	WHERE fecha_baja IS NULL

END

/******************************************/
--INSERCIONES
/******************************************/
GO

INSERT INTO TIPO_MASCOTAS (descripcion) VALUES ('perro')
INSERT INTO TIPO_MASCOTAS (descripcion) VALUES ('gato')
INSERT INTO TIPO_MASCOTAS (descripcion) VALUES ('araña')
INSERT INTO TIPO_MASCOTAS (descripcion) VALUES ('iguana')

INSERT INTO USUARIOS (usuario, passwrd) VALUES ('Admin', 'admin')

INSERT INTO CLIENTES(nombre,sexo) VALUES ('Juan', 'M')
INSERT INTO CLIENTES(nombre,sexo) VALUES ('Ana', 'F')	
INSERT INTO CLIENTES(nombre,sexo) VALUES ('Martina', 'F')
INSERT INTO CLIENTES(nombre,sexo) VALUES ('Monica', 'F')
INSERT INTO CLIENTES(nombre,sexo) VALUES ('Gabriel', 'M')
INSERT INTO CLIENTES(nombre,sexo) VALUES ('Daniela', 'F')

INSERT INTO VETERINARIOS(nombre,sexo) VALUES ('Ines', 'F')
INSERT INTO VETERINARIOS(nombre,sexo) VALUES ('Ricardo', 'M')	
INSERT INTO VETERINARIOS(nombre,sexo) VALUES ('Silvina', 'F')
INSERT INTO VETERINARIOS(nombre,sexo) VALUES ('Fernando', 'M')

INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Charlie', 5, 1,2);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Toby', 3, 1,2);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Nini', 2, 2,2);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Sofi', 3, 3,3);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Negro', 4, 4,1);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Roque', 4, 1,4);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Brisa', 4, 2,4);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Laika', 2, 2,6);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Pongo', 1, 1,6);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Dama', 1, 3,5);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Golfo', 5, 4,4);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Titi', 3, 1,1);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Tofi', 3, 2,1);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Panda', 3, 4,1);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Linda', 3, 3,1);
INSERT INTO MASCOTAS(nombre, edad, id_tipo_mascota, id_cliente) VALUES ('Rubia', 3, 1,1);

INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(1, '2021-11-05 14:14:03.600')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(2, '2021-10-22 14:28:13.837')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(3, '2021-01-05 14:29:42.513')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(4, '2021-01-16 21:46:04.660')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(1, '2021-03-11 14:42:20.773')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(2, '2021-11-05 15:11:05.053')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(3, '2021-11-05 20:55:48.180')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(4, '2021-11-05 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(1, '2021-07-02 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(2, '2021-08-26 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(3, '2021-08-26 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(4, '2021-11-05 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(4, '2021-11-05 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(4, '2021-11-05 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(2, '2021-11-05 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(2, '2021-11-05 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(2, '2021-11-05 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(1, '2021-11-05 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(1, '2021-11-05 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(1, '2021-10-25 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(3, '2021-10-15 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(3, '2021-01-08 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(1, '2021-01-24 21:46:04.660')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(2, '2021-01-24 21:46:04.660')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(3, '2021-01-16 21:46:04.660')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(4, '2021-11-05 14:14:03.600')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(4, '2021-11-05 21:46:04.657')
INSERT INTO ATENCIONES(id_veterinario, fecha_hora) VALUES(4, '2021-09-15 21:46:04.657')


INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 1, 1, 'Primovacunación ', 1220)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 2, 1, 1, 'Pentavalente  ', 1220)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 2, 2, 'Primovacunación', 850)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 2, 2, 2, 'Primovacunación', 850)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 3, 3, 'Hexavalente ', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 4, 4, 'Hexavalente ', 1850)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 5, 5, 'Contra Rabia', 1850)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 6, 6, 'Pentavalente ', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 7, 7, 'Polivalente', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 8, 8, 'Octovalente ', 1450)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 9, 9, 'Contra Rabia', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 10, 10, 'Pentavalente ', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 11, 11, 'Octovalente ', 1350)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 12, 12, 'Octovalente ', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 13, 15, 'Contra Rabia', 350)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 14, 13, 'Octovalente ', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 15, 14, 'Pentavalente  ', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 16, 3, 'Polivalente', 1350)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 17, 8, 'Contra Rabia', 1350)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 19, 12, 'Pentavalente ', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 20, 13, 'Polivalente', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 21, 6, 'Contra Rabia', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 22, 5, 'Contra Rabia', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 23, 7, 'Contra Rabia', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 24, 9, 'Contra Rabia', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 25, 10, 'Contra Rabia', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 26, 4, 'Contra Rabia', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 27, 9, 'Contra Rabia', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
VALUES( 1, 28, 12, 'Contra Rabia', 1250)


