# 📚 Sistema de Gestión de Biblioteca (AcaBiblioteca)

[![.NET 10.0](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL_Server-JUAN__OP-CC292B?logo=microsoftsqlserver)](https://www.microsoft.com/sql-server)
[![C#](https://img.shields.io/badge/Language-C%23-239120?logo=csharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)

Proyecto de escritorio desarrollado como evidencia de la asignatura **Programación Avanzada** (Grupo 54467) en la **Corporación Unificada Nacional de Educación Superior (CUN)**.

---

## 👨‍💻 Desarrolladores & Información Académica

* **Estudiantes:** 
  * Juan Felipe Ospina Mosos
  * Alan Yamith Romero Godoy
* **Docente:** Verónica Castro
* **Institución:** Corporación Unificada Nacional de Educación Superior (CUN)
* **Programa:** Ingeniería / Tecnología en Sistemas
* **Fecha:** Noviembre de 2026

---

## 🎯 Descripción General

**AcaBiblioteca** es un sistema de escritorio (Windows Forms) que automatiza y centraliza la administración del inventario bibliográfico, registro de usuarios y el control transaccional de préstamos y devoluciones de libros.

### ✨ Características Principales:
* **Gestión de Libros y Stock:** Control de existencias, código ISBN, categorías y autores.
* **Gestión de Autores y Editoriales:** Operaciones CRUD completas.
* **Control de Usuarios:** Registro de estudiantes y docentes autorizados.
* **Préstamos y Devoluciones:** Control transaccional con actualización en tiempo real de la disponibilidad de libros.
* **Seguridad e Integridad:** Uso de consultas parametrizadas contra inyección SQL y arquitectura por capas.

---

## 🛠️ Tecnologías y Herramientas

* **Lenguaje:** C# (.NET 10.0)
* **Interfaz Gráfica:** Windows Forms + FontAwesome.Sharp (v6.6.0)
* **Base de Datos:** SQL Server (ADO.NET - `Microsoft.Data.SqlClient` v7.1.1)
* **Arquitectura:** N-Capas (Presentación, Lógica de Negocio, Acceso a Datos)
* **Control de Versiones:** Git & GitHub

---

## 🏗️ Arquitectura del Sistema

La solución aplica una división estricta de responsabilidades:

1. **Capa de Presentación (`UI`):** Formulario principal (`FrmPrincipal`) y subsistemas (`FrmLibros`, `FrmAutores`, `FrmUsuarios`, `FrmPrestamos`, etc.).
2. **Capa de Negocio (`BLL`):** Validaciones de stock, restricciones de negocio y control de flujo.
3. **Capa de Datos (`DAL`):** Conexión ADO.NET (`Conexion.cs`) y comandos T-SQL para la base de datos `AcaBiblioteca`.

---

## 🗄️ Esquema de Base de Datos (SQL)

La base de datos relacional incluye 5 tablas normalizadas en 3FN:

```sql
-- Creación de la BD
CREATE DATABASE AcaBiblioteca;
GO
USE AcaBiblioteca;
GO

-- Tabla Autores
CREATE TABLE Autores (
    IdAutor INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL
);

-- Tabla Editoriales
CREATE TABLE Editoriales (
    IdEditorial INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(150) NOT NULL
);

-- Tabla Libros
CREATE TABLE Libros (
    ISBN VARCHAR(20) PRIMARY KEY,
    Titulo VARCHAR(200) NOT NULL,
    IdAutor INT NOT NULL CONSTRAINT FK_Libros_Autores FOREIGN KEY REFERENCES Autores(IdAutor),
    IdEditorial INT NOT NULL CONSTRAINT FK_Libros_Editoriales FOREIGN KEY REFERENCES Editoriales(IdEditorial),
    Categoria VARCHAR(100),
    Anio INT,
    Existencias INT NOT NULL
);

-- Tabla Usuarios
CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Documento VARCHAR(30) NOT NULL UNIQUE,
    Telefono VARCHAR(30),
    Correo VARCHAR(150)
);

-- Tabla Prestamos
CREATE TABLE Prestamos (
    IdPrestamo INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario INT NOT NULL CONSTRAINT FK_Prestamos_Usuarios FOREIGN KEY REFERENCES Usuarios(IdUsuario),
    ISBN VARCHAR(20) NOT NULL CONSTRAINT FK_Prestamos_Libros FOREIGN KEY REFERENCES Libros(ISBN),
    FechaPrestamo DATE NOT NULL,
    FechaDevolucion DATE NULL,
    Estado VARCHAR(20) NOT NULL
);
