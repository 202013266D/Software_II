create database recuperacion
go
use recuperacion
go

CREATE TABLE Rutas (
    RutaID INT PRIMARY KEY,
    Nombre NVARCHAR(100),
    Precio DECIMAL(10, 2)
);
CREATE TABLE TiposCliente (
    TipoID INT PRIMARY KEY,
    Tipo NVARCHAR(100)
);
CREATE TABLE Ventas (
    VentaID INT PRIMARY KEY,
    RutaID INT,
    CantidadPersonas INT,
    TipoClienteID INT,
    FOREIGN KEY (RutaID) REFERENCES Rutas(RutaID),
    FOREIGN KEY (TipoClienteID) REFERENCES TiposCliente(TipoID)
);
INSERT INTO Rutas (RutaID, Nombre, Precio) VALUES
(1, 'Sacsayhuaman – Puka Pukara – Tambomachay', 100),
(2, 'Tipon -Lucre-Piquillaqta', 120),
(3, 'Ollantaytambo-Machupicchu', 150);





INSERT INTO TiposCliente (TipoID, Tipo) VALUES
(1, 'Promoción de colegios'),
(2, 'Adultos mayores de 60 años'),
(3, 'Adultos menores de 60 y jóvenes');



