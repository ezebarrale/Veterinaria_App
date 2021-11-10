USE VETERINARIA
SELECT * FROM ATENCIONES
SELECT * FROM VETERINARIOS
SELECT * FROM DETALLE_ATENCIONES
SELECT * FROM MASCOTAS
SELECT * FROM CLIENTES

---------------------INSERT VETERINARIOS---------------------------------
INSERT INTO VETERINARIOS(nombre, apellido, dni, contacto, sexo) 
			VALUES ('Nieves', 'Aguada', 28822496, 'Avda. Coronas 1100', 'F')
INSERT INTO VETERINARIOS(nombre, apellido, dni, contacto, sexo) 
			VALUES ('Ricardo', 'Maroleto', 34644234, 'Calle publica s/n', 'M')	
INSERT INTO VETERINARIOS(nombre, apellido, dni, contacto, sexo) 
			VALUES ('Silvina', 'Bustamante', 38456784, 'Calle Pizarro 210', 'F')
INSERT INTO VETERINARIOS(nombre, apellido, dni, contacto, sexo) 
			VALUES ('Fernando', 'Flores Fernandez', 32044776, 'Avda. Valparaiso 576', 'M')

----------------------INSERT CLIENTES------------------------------------------------
INSERT INTO CLIENTES(nombre, apellido, contacto, dni, sexo) 
			VALUES ('Juan', 'Barrionuevo', 4606124, 32403405, 'M')
INSERT INTO CLIENTES(nombre, apellido, contacto, dni, sexo)
			VALUES ('Ana', 'Frondizi', 4824039, 33450567, 'F')	
INSERT INTO CLIENTES(nombre, apellido, contacto, dni, sexo)
			VALUES ('Martina', 'Giraldi', 4765045, 30345432, 'F')
INSERT INTO CLIENTES(nombre, apellido, contacto, dni, sexo)
			VALUES ('Monica', 'Avellaneda', 4554978, 29887665,'F')
INSERT INTO CLIENTES(nombre, apellido, contacto, dni, sexo)
			VALUES ('Gabriel', 'Moleri', 4323332, 29433545, 'M')
INSERT INTO CLIENTES(nombre, apellido, contacto, dni, sexo)
			VALUES ('Daniela', 'Sanguinetti', 4645656, 37456788, 'F')

--------------INSERT MASCOTAS--------------------------------------------------
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Charlie', 5, 'M', 1,2);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente)
		VALUES ('Toby', 3, 'M', 1,2);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Nini', 2, 'H', 2,2);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Sofi', 3, 'H',3,3);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Negro', 4,'M', 4,1);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Roque', 4,'M', 1,4);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Brisa', 4,'H', 2,4);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Laika', 2,'H', 2,6);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Pongo', 1,'M', 1,6);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Dama', 1,'H', 3,5);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Golfo', 5,'M', 4,4);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Titi', 3,'M', 1,1);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Tofi', 3,'M', 2,1);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Panda', 3,'M', 4,1);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Linda', 3,'H', 3,1);
INSERT INTO MASCOTAS(nombre, edad, sexo, id_tipo_mascota, id_cliente) 
		VALUES ('Rubia', 3,'H', 1,1);


----------------INSERT ATENCIONES------------
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

--------------INSERT DETALLE ATENCIONES------------------------------------

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 1, 1, 'Primovacunación', 1220)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 2, 1, 1, 'Vacunación Pentavalente', 1220)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 2, 2, 'Vacunación Hexavalente', 1350)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 2, 2, 2, 'Desparasitación, pipeta', 750)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 3, 3, 'Hidratacion intravenosa por Panleucopeina', 1550)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 4, 4, 'Amputación extremedidad por infeccion bacteriana', 650)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 5, 5, 'Gota, cambio de dieta', 1150)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 6, 6, 'Vacunación Peritonitis', 1250)
						
INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 7, 7, 'Desparasitación intestinal por gastroenteritis', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 8, 8, 'Vacunación Pentavalente', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 9, 9, 'Extraccion de Epulis, sedación', 4950)
						
INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 10, 10, 'Gentamicina, infeccion fungica', 550)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 11, 11, 'Prolapso de la cloaca', 2350)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 12, 12, 'Vacunación Octovalente ', 1450)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 13, 15, 'Revision por fatiga invernal', 550)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 14, 13, 'Corte uñas, sedación', 1850)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 15, 14, 'Enfermedad ósea metabólica, cambio de lampara', 3250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 16, 3, 'Conjuntivitis, Gotas antibioticas', 1350)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 17, 8, 'Vacunación Rabia', 850)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 19, 12, 'Vacunación Pentavalente ', 850)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 20, 13, 'Otitis, gotas gentamicina', 1250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 21, 6, 'Extraccion vidrios pata trasera, antibioticos', 2250)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 22, 5, 'Gota, cambio de dieta', 750)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 23, 7, 'Vacunación Rabia', 850)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 24, 9, 'Vacunación Rabia', 850)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 25, 10, 'Gentamicina, infeccion fungica', 550)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 26, 4, 'Gentamicina, infeccion fungica', 550)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 27, 9, 'Vacunación Rabia', 850)

INSERT INTO DETALLE_ATENCIONES( id_detalle, id_atencion, id_mascota ,descripcion, importe_atencion) 
						VALUES( 1, 28, 12, 'Desparasitación intestinal + collar isabelino', 2050)


			