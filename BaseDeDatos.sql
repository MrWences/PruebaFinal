CREATE DATABASE PruebaRelacional;
USE PruebaRelacional;

CREATE TABLE Pacientes (
	PacienteID int IDENTITY(1,1),
	Nombres varchar(255) NOT NULL PRIMARY KEY,
	Apellidos varchar(255) NOT NULL,
	Direccion varchar(255) NOT NULL,
	Edad int NOT NULL,
	Sexo varchar(255) NOT NULL,
	Telefono bigint NOT NULL,
	Email varchar(255) NOT NULL,
)

INSERT INTO Pacientes(Nombres, Apellidos, Direccion, Edad, Sexo, Telefono, Email) VALUES('Juan', 'Mendez', 'Primero de Mayo', '23', 'H', '6871783067', 'srjuanjo98@gmail.com')
INSERT INTO Medicos(Nombres, Apellidos, Direccion, Edad, Sexo, Telefono, Email) VALUES('Daniel', 'Mendeza', 'Justi Sierra', '33', 'H', '6871783066', 'danielmendoza@gmail.com')

CREATE TABLE Medicos (
	MedicoID int IDENTITY(1,1),
	Nombres varchar(255) NOT NULL PRIMARY KEY,
	Apellidos varchar(255) NOT NULL,
	Direccion varchar(255) NOT NULL,
	Edad int NOT NULL,
	Sexo varchar(255) NOT NULL,
	Telefono bigint NOT NULL,
	Email varchar(255) NOT NULL,
)

CREATE TABLE Cita (
	CitaID int IDENTITY(1,1) PRIMARY KEY,
	nombreMed varchar(255) NOT NULL,
	nombrePac varchar(255) NOT NULL,
	fechaCita datetime

	CONSTRAINT FK_Cita_Medico FOREIGN KEY (nombreMed) REFERENCES Medicos(Nombres)
		ON DELETE CASCADE,
	CONSTRAINT FK_Cita_Paciente FOREIGN KEY (nombrePac) REFERENCES Pacientes(Nombres)
		ON DELETE CASCADE
)


INSERT INTO Cita(nombreMed, nombrePac, fechaCita) VALUES('Daniel', 'Juan', '04-11-21 2:30')

SELECT * FROM Pacientes
SELECT * FROM Medicos
SELECT * FROM Cita



SELECT Nombres FROM Pacientes WHERE(PacienteID=2) 

DROP TABLE Pacientes
DROP TABLE Medicos
DROP TABLE Cita
