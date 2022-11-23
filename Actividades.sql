USE master
GO

IF DB_ID (N'Actividades') IS NOT NULL
DROP DATABASE Actividades
GO

CREATE DATABASE Actividades
ON
( NAME = Actividades_dat,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Actividades.mdf',
	SIZE = 100,
	MAXSIZE = 500,
	FILEGROWTH = 500 )
LOG ON 
( NAME = Actividades_log,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Actividades.ldf',
	SIZE = 100MB,
	MAXSIZE = 500MB,
	FILEGROWTH = 500MB ) ;
GO

------------- TABLAS ---------------------------------

USE Actividades
GO

CREATE TABLE Actividad(
    idActividad int IDENTITY,
    nombreActividad varchar(150) not null,
    fecha date not null,
    hora time not null,
    lugar varchar (80) not null,
    cantidadParticipantes int not null,
    oficio varchar (200) not null,
    nombreEncargado varchar (150) not null,
    academia varchar (50) not null,
	fotoEncargado varchar (200) not null,
    idUsuarioResponsable int not null,
    estatus bit default 0 not null,
    CONSTRAINT PKActividad PRIMARY KEY (idActividad)
)

CREATE TABLE Usuario(
    idUsuario int IDENTITY,
    correo varchar (50) not null UNIQUE,
    clave varbinary (MAX) not null,
    estatus bit default 1 not null,
    CONSTRAINT PKUsuario PRIMARY KEY(idUsuario)
)

ALTER TABLE Actividad
ADD CONSTRAINT FKActividadUsuarioResponsable FOREIGN KEY (idUsuarioResponsable)
REFERENCES Usuario(idUsuario)

----------------------------------------------------------------

INSERT INTO Usuario (correo, clave)
VALUES ('director@monclova.tecnm.mx', HASHBYTES('MD4', 'sk1pper')),
('planeacion@monclova.tecnm.mx', HASHBYTES('MD4', 'kowalsk1')),
('financiero@monclova.tecnm.mx', HASHBYTES('MD4', 'r1c0')),
('academico@monclova.tecnm.mx', HASHBYTES('MD4', 'c4b0'));
