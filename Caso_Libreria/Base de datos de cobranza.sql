IF EXISTS (SELECT * FROM SYS.DATABASES WHERE NAME='pagosestudiantes')
DROP DATABASE pagosestudiantes
go

create database pagosestudiantes
go
use pagosestudiantes
go
--  tabla  estudiantes
CREATE TABLE Estudiantes (
    EstudianteID INT PRIMARY KEY,
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    FechaNacimiento DATE,
    Direccion NVARCHAR(200),
    Telefono NVARCHAR(20),
    Email NVARCHAR(100)
);
GO

-- tabla  pagos
CREATE TABLE Pagos (
    PagoID INT PRIMARY KEY,
    EstudianteID INT,
    FechaPago DATE,
    Monto DECIMAL(10, 2),
    CONSTRAINT FK_Pago_Estudiante FOREIGN KEY (EstudianteID) REFERENCES Estudiantes(EstudianteID)
);
GO

--  tabla tipos de pago
CREATE TABLE TipoPago (
    TipoPagoID INT PRIMARY KEY,
    Descripcion NVARCHAR(100)
);
GO

--  tabla para registrar los tipos de pago que puede hacer un estudiante
CREATE TABLE EstudianteTipoPago (
    EstudianteID INT,
    TipoPagoID INT,
    PRIMARY KEY (EstudianteID, TipoPagoID),
    CONSTRAINT FK_EstudianteTipoPago_Estudiante FOREIGN KEY (EstudianteID) REFERENCES Estudiantes(EstudianteID),
    CONSTRAINT FK_EstudianteTipoPago_TipoPago FOREIGN KEY (TipoPagoID) REFERENCES TipoPago(TipoPagoID)
);
GO

--  tabla de cuotas
CREATE TABLE Cuotas (
    CuotaID INT PRIMARY KEY,
    Descripcion NVARCHAR(100),
    Monto DECIMAL(10, 2),
    FechaInicio DATE,
    FechaFin DATE
);
GO

--  tabla para la relación entre estudiantes y cuotas
CREATE TABLE EstudianteCuota (
    EstudianteID INT,
    CuotaID INT,
    PRIMARY KEY (EstudianteID, CuotaID),
    CONSTRAINT FK_EstudianteCuota_Estudiante FOREIGN KEY (EstudianteID) REFERENCES Estudiantes(EstudianteID),
    CONSTRAINT FK_EstudianteCuota_Cuota FOREIGN KEY (CuotaID) REFERENCES Cuotas(CuotaID)
);
GO

