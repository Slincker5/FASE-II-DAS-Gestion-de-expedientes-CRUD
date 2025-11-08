# Desafío 2  
## Sistema de Gestión de Expedientes Académicos  
**Colegio San José**

---

###  Enunciado del Ejercicio

El **Colegio San José** desea desarrollar un sistema web para la gestión de los expedientes académicos de sus alumnos, con el propósito de mantener un **registro digital de las materias cursadas y las calificaciones obtenidas** por cada estudiante.

El sistema deberá permitir registrar la información básica de los alumnos, las materias que ofrece la institución y los expedientes que asocian a cada alumno con las materias inscritas, incluyendo la **nota final** y las **observaciones del docente**.  

Cada alumno puede estar matriculado en varias materias, y cada materia puede ser cursada por varios alumnos, estableciendo así una **relación de muchos a muchos** entre ambas entidades, gestionada mediante la tabla `Expediente`.

---

###  Modelo Entidad-Relación

![Diagrama ER](https://profiles.multimarcas.app/2c62e966-63d8-4bfd-832e-89094ae47eec/690ec29f18acf.png)

---

###  Tecnologías y Arquitectura

El sistema se desarrollará en **ASP.NET Core MVC**, utilizando **Entity Framework Core** como ORM.  
Debe incluir las operaciones **CRUD (crear, leer, actualizar y eliminar)** para cada entidad.

Adicionalmente, se implementará una **vista estadística** que muestre el **promedio de notas por alumno**, agrupando los registros del expediente.

---

### Funcionalidades a Implementar

####  Gestión de Alumnos
- Registro de alumnos con sus datos personales.  
- Edición y eliminación de registros.  
- Visualización de la lista completa.

####  Gestión de Materias
- Creación y administración de las materias ofrecidas por la institución.  
- Edición y eliminación de materias.  
- Listado completo con opciones de filtrado.

####  Gestión de Expedientes
- Asociación de alumnos con materias.  
- Registro de nota final y observaciones del docente.  
- Edición, consulta y eliminación de expedientes.

#### Vista de Promedios
- Visualización del **promedio de notas por alumno**.  
- Gráficas comparativas (barras, pastel o líneas) generadas con **Chart.js**.

---

### Entrega Esperada

El estudiante deberá entregar:

1. **Repositorio en GitHub** con el proyecto completo en ASP.NET Core, que incluya:
   - Las tres tablas (`Alumno`, `Materia`, `Expediente`) implementadas.
   - CRUD funcional para cada entidad.
   - Vista de promedio de notas.

2. **Documento en formato PDF** con:
   - Capturas de pantalla que evidencien el funcionamiento del sistema.  
   - Breve descripción de las principales funcionalidades.  
   - Enlace al repositorio de GitHub del proyecto.  
   - Gráficas estadísticas que representen los resultados (por ejemplo, promedios por alumno o distribución de notas).

>  *El script SQL de creación de la base de datos puede incluirse de forma opcional si el proyecto utiliza migraciones con Entity Framework Core.*

---

**Autor:** *Gerson Borja Álvarez*  
**Materia:** *Desarrollo de Aplicaciones con Software Propietario DAS901 G01T (Virtual)*  
**Institución:** *Universidad Don Bosco (UDB Virtual)*  
**Año:** *2025*
