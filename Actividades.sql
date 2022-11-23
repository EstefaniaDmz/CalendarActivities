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

INSERT INTO Actividad (nombreActividad, fecha, hora, lugar, cantidadParticipantes, oficio, nombreEncargado, academia, idUsuarioResponsable, fotoEncargado, estatus)
VALUES ('Paga de quincena', '2022-04-15', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-04-15-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-04-30', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-04-30-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-05-15', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-05-15-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-05-30', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-05-30-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-06-15', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-06-15-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-06-30', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-06-30-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-07-15', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-07-15-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-07-30', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-07-30-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-08-15', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-08-15-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-08-30', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-08-30-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-09-15', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-09-15-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-09-30', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-09-30-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-10-15', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-10-15-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-10-30', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-10-30-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-11-15', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-11-15-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-11-30', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-11-30-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-12-15', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-12-15-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2022-12-30', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-12-30-22.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2023-01-15', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-01-15-23.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2023-01-30', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-01-30-23.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2023-02-15', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-02-15-23.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2023-02-28', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-02-28-23.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2023-03-15', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-03-15-23.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1),
('Paga de quincena', '2023-03-30', '15:00', 'Edifico 2, planta alta', 55, 'C:\Users\ANDREITA\Documents\Formatos Actividades\FIN-03-30-23.pdf', 'Rosario L. Muñoz', 'N/A', 3, 'C:\Users\ANDREITA\Documents\Formatos Actividades\tec.png', 1);
