IF NOT EXISTS (
    SELECT name
    FROM sys.databases
    WHERE name = 'CrudEscolar'
)
BEGIN
    CREATE DATABASE CrudEscolar;
END
GO

USE CrudEscolar;
GO

IF OBJECT_ID('dbo.Usuarios', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Usuarios
    (
        IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
        Usuario VARCHAR(100) NOT NULL,
        Contraseña VARCHAR (255) NOT NULL,
        Salt VARCHAR (255) NOT NULL, 
        Iteraciones INT,
        FechaRegistro DATETIME NOT NULL
            DEFAULT GETDATE(),
        CONSTRAINT UQ_Usuarios_Usuario
        UNIQUE (USUARIO)
    );
END
GO
IF OBJECT_ID('dbo.Productos', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Productos
    (
        IdProducto INT IDENTITY(1,1) PRIMARY KEY,
        IdUsuario INT NOT NULL,
        Nombre VARCHAR(100) NOT NULL,
        Descripcion VARCHAR(300) NOT NULL,
        Precio DECIMAL(10,2) NOT NULL,

        FechaRegistro DATETIME NOT NULL
            DEFAULT GETDATE(),

        CONSTRAINT CK_Productos_Precio
        CHECK (Precio > 0),

        CONSTRAINT FK_Productos_Usuario
        FOREIGN KEY (IdUsuario)
        REFERENCES dbo.Usuarios(IdUsuario)
    );
END
GO
