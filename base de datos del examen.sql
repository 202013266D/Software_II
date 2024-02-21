CREATE DATABASE RegistroVentasLibros;
GO

USE RegistroVentasLibros;
GO


CREATE TABLE Clientes (
   ClienteId INT IDENTITY(1,1) PRIMARY KEY,
   Nombre VARCHAR(100) NOT NULL,
   Genero CHAR(1) NOT NULL CHECK (Genero IN ('M', 'F'))
);


CREATE TABLE TiposLibro (
   TipoLibroId INT PRIMARY KEY,
   Descripcion VARCHAR(50) NOT NULL,
   Precio DECIMAL(10, 2) NOT NULL
);

CREATE TABLE Libros (
   LibroId INT IDENTITY(1,1) PRIMARY KEY,
   Titulo VARCHAR(200) NOT NULL,
   TipoLibroId INT FOREIGN KEY REFERENCES TiposLibro(TipoLibroId)
);


CREATE TABLE Ventas (
   VentaId INT IDENTITY(1,1) PRIMARY KEY,
   ClienteId INT FOREIGN KEY REFERENCES Clientes(ClienteId),
   FechaVenta DATE NOT NULL,
   ImporteBruto DECIMAL(10, 2) NOT NULL,
   PorcentajeDescuento DECIMAL(5, 2) NOT NULL,
   MontoDescuento DECIMAL(10, 2) NOT NULL,
   ImporteNeto DECIMAL(10, 2) NOT NULL
);


CREATE TABLE DetallesVenta (
   DetalleVentaId INT IDENTITY(1,1) PRIMARY KEY,
   VentaId INT FOREIGN KEY REFERENCES Ventas(VentaId),
   LibroId INT FOREIGN KEY REFERENCES Libros(LibroId),
   Cantidad INT NOT NULL,
   PrecioUnitario DECIMAL(10, 2) NOT NULL
);


INSERT INTO TiposLibro (TipoLibroId, Descripcion, Precio) VALUES
   (1, 'Ficción', 90.00),
   (2, 'Novelas', 100.00),
   (3, 'Cuentos', 80.00),
   (4, 'Física Cuántica', 150.00);
