-- Crear la base de datos
CREATE DATABASE VideoClubDB;

-- Usar la base de datos creada
USE VideoClubDB;

-- Crear la tabla Peliculas
CREATE TABLE Peliculas (
    ID INT PRIMARY KEY IDENTITY,
    Titulo NVARCHAR(60) NOT NULL,
    Director NVARCHAR(30) NOT NULL,
    Genero NVARCHAR(30) NOT NULL,
    FechaLanzamiento DATE NOT NULL,
    Disponible BIT NOT NULL
);

-- Insertar registros
INSERT INTO Peliculas (Titulo, Director, Genero, FechaLanzamiento, Disponible)
VALUES ('Jurassic Park', 'Steven Spielberg', 'Aventura', '1993-06-11', 1),
       ('Interstellar', 'Christopher Nolan', 'Ciencia ficción', '2014-11-07', 1),
       ('El padrino', 'Francis Ford Coppola', 'Crimen', '1972-03-24', 0);
