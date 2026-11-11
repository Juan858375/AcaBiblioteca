# ACA -- Programación Avanzada

# Sistema de Gestión de Biblioteca

------------------------------------------------------------------------

## PORTADA

**Corporación Unificada Nacional de Educación Superior (CUN)**

**Programa de Ingeniería / Tecnología en Sistemas**

### ACA -- Programación Avanzada

### Sistema de Gestión de Biblioteca (AcaBiblioteca)

**Presentado por:**\
Juan Felipe Ospina Mosos y Alan Yamith Romero Godoy

**Docente:**\
Verónica Castro

**Fecha:**\
Bogotá, D.C., Noviembre de 2026

------------------------------------------------------------------------

# CONTRAPORTADA

**Sistema de Gestión de Biblioteca**

Proyecto desarrollado como evidencia del curso de **Programación
Avanzada**, aplicando Programación Orientada a Objetos, base de datos
relacional, arquitectura por capas, operaciones CRUD, validaciones,
manejo de excepciones y conexión con SQL Server.

**Estudiante(s):** Juan Felipe Ospina Mosos y Alan Yamith Romero Godoy\
**Programa:** Ingeniería / Tecnología en Sistemas\
**Grupo:** 54467\
**Docente:** Verónica Castro\
**Institución:** Corporación Unificada Nacional de Educación Superior (CUN)\
**Año:** 2026

------------------------------------------------------------------------

# TABLA DE CONTENIDO

1.  Introducción
2.  Objetivos
    -   2.1 Objetivo general
    -   2.2 Objetivos específicos
3.  Planteamiento del problema
4.  Análisis de requerimientos
5.  Casos de uso
6.  Diagrama de clases
7.  Modelo entidad-relación
8.  Diccionario de datos
9.  Arquitectura del sistema
10. Explicación de los módulos desarrollados
11. Capturas de pantalla del sistema
12. Pruebas de funcionamiento
13. Conclusiones
14. Recomendaciones
15. Referencias bibliográficas

------------------------------------------------------------------------

# 1. INTRODUCCIÓN

El presente documento describe el desarrollo del **Sistema de Gestión de
Biblioteca (AcaBiblioteca)**, una aplicación de escritorio cuyo propósito es facilitar
la administración del inventario de libros, el registro de usuarios y el control de los procesos de préstamos y devoluciones de la biblioteca.

El sistema fue desarrollado utilizando **C# bajo el entorno .NET 10.0**, con una interfaz gráfica en **Windows Forms** enriquecida con la librería **FontAwesome.Sharp (v6.6.0)**. Como motor de base de datos se implementó **SQL Server** mediante ADO.NET (Microsoft.Data.SqlClient v7.1.1), aplicando principios de
Programación Orientada a Objetos y una arquitectura lógica estructurada por capas (Presentación, Negocio, Datos).

La aplicación permite gestionar libros, autores, categorías (editoriales), usuarios,
préstamos, devoluciones y reportes, centralizando la información para mantener la integridad de los datos.

------------------------------------------------------------------------

# 2. OBJETIVOS

## 2.1 Objetivo general

Desarrollar una aplicación de escritorio para la gestión integral de una biblioteca utilizando C#, Windows Forms y SQL Server, que permita administrar el inventario literario y automatizar los préstamos, utilizando Programación Orientada a Objetos, una base de datos relacional y una arquitectura por capas.

## 2.2 Objetivos específicos

-   Diseñar e implementar una aplicación de escritorio en .NET 10 para la gestión del inventario y los usuarios.
-   Aplicar principios de Programación Orientada a Objetos (clases, encapsulamiento, objetos).
-   Diseñar e implementar una base de datos relacional en SQL Server.
-   Implementar operaciones CRUD para las entidades principales (Libros, Autores, Categorías, Usuarios, Préstamos).
-   Implementar validaciones de datos para evitar registros inconsistentes o duplicados.
-   Implementar manejo de excepciones a nivel de base de datos y de interfaz.
-   Aplicar una arquitectura por capas separando la interfaz visual de las consultas SQL.
-   Implementar reportes que faciliten la administración de la
    biblioteca.
-   Utilizar Git y GitHub para el control de versiones.
-   Documentar técnica y funcionalmente el proyecto.

------------------------------------------------------------------------

# 3. PLANTEAMIENTO DEL PROBLEMA

## 3.1 Descripción del problema

La biblioteca actualmente presenta dificultades para administrar de
manera organizada la información relacionada con los libros, autores,
usuarios y los movimientos de préstamos. El manejo manual de esta información puede generar
errores de redundancia, pérdida de información histórica y dificultades logísticas críticas para conocer la
disponibilidad real de los libros en el inventario.

Por esta razón, se propone desarrollar "AcaBiblioteca", una aplicación que permita
centralizar y administrar la información de la biblioteca de manera
organizada, estructurada y eficiente mediante el uso de bases de datos relacionales.

## 3.2 Justificación

Desarrollar el sistema es fundamental para modernizar la gestión bibliotecaria, mitigando los errores humanos en el registro de devoluciones y garantizando el control de existencias. A nivel académico, este proyecto consolida los conocimientos de ADO.NET, POO y diseño de interfaces en C#, validando las competencias exigidas en la asignatura.

## 3.3 Alcance

El sistema permitirá:

-   Gestionar libros y su stock de existencias.
-   Gestionar autores.
-   Gestionar categorías / editoriales.
-   Gestionar usuarios registrados.
-   Registrar préstamos vinculando libros y usuarios.
-   Registrar devoluciones.
-   Consultar disponibilidad de ejemplares.
-   Consultar historial de préstamos y reportes del sistema.

### Fuera del alcance

-   Módulo de facturación o cobro electrónico de multas.
-   Plataforma web de auto-consulta para los usuarios de la biblioteca.

------------------------------------------------------------------------

# 4. ANÁLISIS DE REQUERIMIENTOS

## 4.1 Descripción general

El Sistema de Gestión de Biblioteca permitirá administrar la información
relacionada con Autores, Categorías, Libros y Usuarios, y controlar los procesos transaccionales de
préstamos, devoluciones y reportes.

## 4.2 Actores del sistema

| Actor | Descripción |
| :--- | :--- |
| **Bibliotecario / Administrador** | Posee control total del sistema. Puede registrar y modificar libros, categorías, autores y usuarios, y aprueba todas las transacciones de préstamos y devoluciones. |

## 4.3 Requerimientos funcionales

| Código | Requerimiento | Descripción |
| :--- | :--- | :--- |
| **RF01** | Gestionar libros | Registrar, consultar, actualizar, eliminar y buscar libros en el catálogo. |
| **RF02** | Gestionar autores | Registrar, consultar, actualizar y eliminar autores. |
| **RF03** | Gestionar categorías/editoriales | Registrar, consultar, actualizar y eliminar categorías temáticas o editoriales. |
| **RF04** | Gestionar usuarios | Registrar, consultar, actualizar y eliminar usuarios autorizados para préstamos. |
| **RF05** | Registrar préstamos | Registrar préstamos asociando un usuario y un libro, y actualizar automáticamente la disponibilidad de los ejemplares. |
| **RF06** | Registrar devoluciones | Registrar devoluciones, actualizando el estado del préstamo y la cantidad disponible del libro. |
| **RF07** | Módulo de Reportes | Consultar listados de libros disponibles, historial de préstamos, registros activos y devueltos. |

## 4.4 Requerimientos no funcionales

| Código | Requerimiento | Descripción |
| :--- | :--- | :--- |
| **RNF01** | Usabilidad | La interfaz (Windows Forms) debe ser clara, sencilla y utilizar iconos descriptivos (FontAwesome). |
| **RNF02** | Validación | El sistema debe validar campos obligatorios y unicidad de identificadores ingresados. |
| **RNF03** | Compatibilidad | El sistema debe compilarse y ejecutarse en .NET 10.0. |
| **RNF04** | Arquitectura | El sistema debe utilizar de forma estricta una arquitectura lógica por capas. |
| **RNF05** | Manejo de excepciones | Las operaciones a BD deben manejar errores (try-catch) de forma controlada. |
| **RNF06** | Integridad de datos | La base de datos (SQL Server) mantendrá la consistencia con llaves foráneas y restricciones UNIQUE. |
| **RNF07** | Consultas parametrizadas | Todas las transacciones SQL utilizarán parámetros ADO.NET para evitar inyección SQL. |

## 4.5 Reglas de negocio

### RN01 -- Código único del libro
No se permitirá registrar dos libros con el mismo código identificador o ISBN.

### RN02 -- Datos obligatorios
No se permitirá almacenar registros con campos obligatorios vacíos (ej. nombre, documento, código).

### RN03 -- Integridad referencial
No se podrá eliminar un autor o categoría que tenga libros asociados, ni un usuario que tenga préstamos.

### RN04 -- Disponibilidad de ejemplares
No se podrá registrar un préstamo para un libro cuando su cantidad (stock) sea cero.

### RN05 -- Actualización de disponibilidad
Al registrar un préstamo, la cantidad disponible del libro deberá restarse en 1 unidad.

### RN06 -- Devolución
Al registrar una devolución, la disponibilidad del libro sumará 1 unidad y el estado del préstamo cambiará a "Devuelto".

------------------------------------------------------------------------

# 5. CASOS DE USO

## 5.1 Descripción

Los casos de uso describen la interacción del Bibliotecario con los módulos de registro maestro y con los módulos transaccionales que afectan las existencias en SQL Server.

## 5.2 Diagrama de casos de uso

`![Diagrama de casos de uso](ruta/al/diagrama-casos-uso.png)`

## 5.3 Descripción de casos de uso

### CU01 -- Gestionar libros

**Actor principal:** Bibliotecario / Administrador
**Descripción:** Permite registrar, consultar, actualizar, eliminar y buscar libros.
**Precondiciones:** 
- El usuario debe tener acceso al sistema. 
- Deben existir autores y categorías previamente registrados.
**Flujo principal:** 
1. El actor ingresa al módulo de libros. 
2. El sistema muestra los libros registrados en un DataGridView. 
3. El actor llena el formulario y hace clic en la operación que desea realizar. 
4. La Capa de Negocio valida los datos.
5. La Capa de Datos ejecuta la instrucción SQL y refresca la vista.
**Flujos alternativos:** 
- Código de libro duplicado: El sistema detiene la operación y muestra un mensaje de advertencia.
**Postcondiciones:** 
- El catálogo de libros queda actualizado en la base de datos.

------------------------------------------------------------------------

### CU02 -- Registrar préstamo

**Actor principal:** Bibliotecario / Administrador
**Descripción:** Permite registrar el préstamo de un libro a un usuario.
**Precondiciones:** 
- El usuario debe existir en el sistema. 
- El libro debe existir. 
- Debe existir disponibilidad (cantidad > 0).
**Flujo principal:** 
1. Seleccionar usuario desde el panel de préstamos. 
2. Seleccionar libro a prestar. 
3. El sistema verifica la disponibilidad en tiempo real. 
4. Registrar préstamo con la fecha actual. 
5. El sistema resta la disponibilidad del libro en la BD. 
6. Mostrar mensaje de confirmación de éxito.
**Flujos alternativos:** 
- Libro sin disponibilidad: El sistema bloquea el préstamo e informa al bibliotecario.
**Postcondiciones:** 
- El préstamo queda registrado y la disponibilidad del libro queda actualizada.

------------------------------------------------------------------------

### CU03 -- Registrar devolución

**Actor principal:** Bibliotecario / Administrador
**Descripción:** Permite registrar la devolución de un libro prestado.
**Precondiciones:** 
- Debe existir un préstamo en estado activo o pendiente.
**Flujo principal:** 
1. Buscar y seleccionar el registro del préstamo. 
2. Confirmar la recepción física del libro. 
3. El sistema actualiza la disponibilidad sumando el libro al inventario. 
4. Actualizar el estado del préstamo a "Devuelto". 
5. Mostrar confirmación en pantalla.
**Postcondiciones:** 
- La devolución queda finalizada y el libro vuelve a estar disponible para futuros préstamos.

------------------------------------------------------------------------

# 6. DIAGRAMA DE CLASES

## 6.1 Descripción

El sistema separa las clases que modelan los datos (Entidades), las clases que manejan la lógica y las validaciones (Controladores/BLL) y las que se conectan con la base de datos (DAOs/DAL).

## 6.2 Diagrama de clases

`![Diagrama de clases](ruta/al/diagrama-clases.png)`

## 6.3 Principales clases

| Clase | Responsabilidad |
| :--- | :--- |
| **Conexion** | Proveer la cadena de conexión ADO.NET (`SqlConnection`) para SQL Server. |
| **Libro** | Modelar las propiedades e información en memoria de los libros. |
| **Usuario** | Modelar los datos de los usuarios registrados de la biblioteca. |
| **LibroDAO** | Ejecutar los comandos `INSERT`, `UPDATE`, `DELETE`, `SELECT` del libro hacia la base de datos. |
| **PrestamoController** | Orquestar la creación de un préstamo, verificando stock antes de llamar al DAO. |

## 6.4 Aplicación de POO

-   **Clases y Objetos:** Se definieron plantillas (Clases) para las tablas SQL que se instancian como Objetos al cargar datos.
-   **Constructores:** Utilizados en los formularios y clases controladoras para inicializar las conexiones de base de datos.
-   **Métodos y Propiedades:** Getters y Setters encapsulan el acceso a los atributos privados.
-   **Encapsulamiento:** Las validaciones evitan la modificación directa del estado de las variables desde la vista.
-   **Colecciones:** Uso de `List<T>` para extraer conjuntos de resultados desde la base de datos a los DataGridViews.

------------------------------------------------------------------------

# 7. MODELO ENTIDAD-RELACIÓN

## 7.1 Descripción

El modelo de base de datos relacional `JUAN_OP` fue diseñado en Tercera Forma Normal (3FN) para garantizar la integridad referencial. Emplea claves primarias autoincrementales (IDENTITY) y llaves foráneas.

## 7.2 Diagrama entidad-relación

`![Modelo entidad-relación](ruta/al/modelo-entidad-relacion.png)`

## 7.3 Relaciones principales

-   Un autor puede estar asociado a muchos libros (1:N).
-   Una categoría puede estar asociada a muchos libros (1:N).
-   Un usuario puede realizar múltiples préstamos (1:N).
-   Un préstamo tiene un detalle que lo vincula a un libro específico y gestiona la fecha de devolución (1:1 o 1:N dependiendo de la cantidad retirada).

------------------------------------------------------------------------

# 8. DICCIONARIO DE DATOS

## 8.1 Convenciones

| Abreviatura | Significado |
| :--- | :--- |
| PK | Clave primaria |
| FK | Clave foránea |
| UQ | Campo con valor único |
| NULL | Campo que puede estar vacío |
| NOT NULL | Campo obligatorio |

## 8.2 Tabla: Autor

| Campo | Tipo de dato | Clave | Nulo | Descripción |
| :--- | :--- | :--- | :--- | :--- |
| idAutor | INT | PK | No | Identificador único del autor (Identity). |
| nombre | VARCHAR(100) | - | No | Nombre del autor. |
| apellidos | VARCHAR(100) | - | No | Apellidos del autor. |
| nacionalidad | VARCHAR(50) | - | Sí | País de origen del autor. |
| fechaNacimiento | DATE | - | Sí | Fecha de nacimiento. |

## 8.3 Tabla: Categoria

| Campo | Tipo de dato | Clave | Nulo | Descripción |
| :--- | :--- | :--- | :--- | :--- |
| idCategoria | INT | PK | No | Identificador único de la categoría. |
| nombre | VARCHAR(50) | UQ | No | Nombre de la categoría o editorial. |
| descripcion | VARCHAR(200) | - | Sí | Descripción de la categoría. |

## 8.4 Tabla: Libro

| Campo | Tipo de dato | Clave | Nulo | Descripción |
| :--- | :--- | :--- | :--- | :--- |
| idLibro | INT | PK | No | Identificador único del libro. |
| codigo | VARCHAR(20) | UQ | No | Código único o ISBN del libro. |
| titulo | VARCHAR(200) | - | No | Título de la obra. |
| anioPublicacion | INT | - | Sí | Año de publicación. |
| idAutor | INT | FK | No | FK a la tabla Autor. |
| idCategoria | INT | FK | No | FK a la tabla Categoria. |
| cantidad | INT | - | No | Existencias disponibles (stock). |
| estado | VARCHAR(20) | - | No | Estado físico del libro. |
| sinopsis | VARCHAR(500) | - | Sí | Descripción general. |

## 8.5 Tabla: Usuario

| Campo | Tipo de dato | Clave | Nulo | Descripción |
| :--- | :--- | :--- | :--- | :--- |
| idUsuario | INT | PK | No | Identificador único del usuario. |
| documento | VARCHAR(20) | UQ | No | Número de identificación. |
| tipoDocumento | VARCHAR(20) | - | No | Tipo de documento (ej. CC, TI). |
| nombre | VARCHAR(100) | - | No | Nombres del usuario. |
| apellidos | VARCHAR(100) | - | No | Apellidos del usuario. |
| direccion | VARCHAR(150) | - | Sí | Residencia. |
| telefono | VARCHAR(20) | - | Sí | Teléfono de contacto. |
| correo | VARCHAR(100) | - | Sí | Correo electrónico. |
| fechaNacimiento | DATE | - | Sí | Fecha de nacimiento. |
| estado | VARCHAR(20) | - | No | Activo / Inactivo. |

## 8.6 Tabla: Prestamo

| Campo | Tipo de dato | Clave | Nulo | Descripción |
| :--- | :--- | :--- | :--- | :--- |
| idPrestamo | INT | PK | No | Identificador único del préstamo. |
| idUsuario | INT | FK | No | Usuario que retira el libro. |
| fechaPrestamo | DATETIME | - | No | Fecha del registro del retiro. |
| estado | VARCHAR(20) | - | No | Pendiente / Devuelto. |

## 8.7 Tabla: DetallePrestamo

| Campo | Tipo de dato | Clave | Nulo | Descripción |
| :--- | :--- | :--- | :--- | :--- |
| idDetalle | INT | PK | No | PK del detalle del préstamo. |
| idPrestamo | INT | FK | No | FK a la tabla Prestamo. |
| idLibro | INT | FK | No | FK al Libro prestado. |
| fechaDevolucionEstimada | DATE | - | No | Fecha límite pactada. |
| fechaDevolucionReal | DATE | - | Sí | Fecha de entrega del libro. |
| multa | DECIMAL(10,2)| - | Sí | Monto en caso de retrasos. |
| estado | VARCHAR(20) | - | No | Estado del ítem específico. |

------------------------------------------------------------------------

# 9. ARQUITECTURA DEL SISTEMA

## 9.1 Descripción general

El Sistema de Gestión de Biblioteca se desarrolla utilizando una
**arquitectura lógica por capas**. Este patrón separa las
responsabilidades visuales de las reglas del negocio y el acceso a los datos, mejorando el mantenimiento, lectura y escalabilidad del código C#.

La arquitectura está compuesta por:
1.  Capa de Presentación (Interfaz UI).
2.  Capa de Lógica de Negocio (Reglas y Control).
3.  Capa de Acceso a Datos (Consultas SQL).

## 9.2 Diagrama de arquitectura

`![Arquitectura del sistema](ruta/al/diagrama-arquitectura.png)`

## 9.3 Capa de Presentación

**Responsabilidad:**
Es la interfaz visual e interactiva; captura los eventos del usuario (clics) y solicita la ejecución a la capa inferior. No contiene consultas SQL.

**Componentes:**
-   `FrmPrincipal` (Menú contenedor)
-   `FrmLibros`, `FrmAutores`, `FrmCategorias`, `FrmUsuarios`, `FrmPrestamos`, `FrmReportes`.

**Tecnología utilizada:**
-   Windows Forms bajo .NET 10.0.
-   FontAwesome.Sharp (Iconografía).

## 9.4 Capa de Lógica de Negocio

**Responsabilidad:**
Recibe los datos del formulario, aplica validaciones (campos vacíos, lógica condicional) y decide si la operación es válida antes de contactar a la base de datos.

**Ejemplos de reglas:**
-   Validar disponibilidad (`cantidad > 0`).
-   Validar que el documento del usuario no esté vacío.
-   Calcular la actualización de estados.

## 9.5 Capa de Acceso a Datos

**Responsabilidad:**
Gestiona exclusivamente la apertura, ejecución y cierre de operaciones contra SQL Server.

**Componentes:**
-   Clase `Conexion` (Cadena de conexión a base de datos `JUAN_OP`).
-   Clases DAO (`LibroDAO`, `UsuarioDAO`, etc.).

**Tecnologías utilizadas:**
-   `Microsoft.Data.SqlClient`.
-   Comandos paramétricos (`SqlCommand.Parameters.AddWithValue`) para prevenir Inyección SQL.

## 9.6 Flujo de información

``` text
Usuario (Click en Interfaz)
   ↓
Capa de Presentación (Windows Forms)
   ↓
Capa de Lógica de Negocio (Control y Validación)
   ↓
Capa de Acceso a Datos (DAO / ADO.NET)
   ↓
SQL Server (Base de Datos JUAN_OP)