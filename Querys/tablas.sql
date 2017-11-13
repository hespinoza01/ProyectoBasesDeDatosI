/* Creación de la base de datos */
create database ProyectoBDI
	go
use ProyectoBDI

  ------------
/*  TABLAS  */
------------


--Tabla users--
create table Users(
	id varchar(10) primary key not null,
	contraseña nvarchar(40) not null,
	nombre nvarchar(25),
	apellido nvarchar(25),
	correo varchar(35) unique,
	perfilPic image
)

