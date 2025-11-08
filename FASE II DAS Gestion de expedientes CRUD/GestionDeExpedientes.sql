-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               Microsoft SQL Server 2022 (RTM) - 16.0.1000.6
-- Server OS:                    Windows 10 Home Single Language 10.0 <X64> (Build 26100: ) (Hypervisor)
-- HeidiSQL Version:             12.11.0.7065
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for GESTIONEXPEDIENTE
CREATE DATABASE IF NOT EXISTS "GESTIONEXPEDIENTE";
USE "GESTIONEXPEDIENTE";

-- Dumping structure for table GESTIONEXPEDIENTE.Alumno
CREATE TABLE IF NOT EXISTS "Alumno" (
	"AlumnoID" INT,
	"Nombre" NVARCHAR(50) DEFAULT NULL COLLATE Modern_Spanish_CI_AS,
	"Apellido" NVARCHAR(50) DEFAULT NULL COLLATE Modern_Spanish_CI_AS,
	"FechaNacimiento" DATE DEFAULT NULL,
	"Grado" NVARCHAR(20) DEFAULT NULL COLLATE Modern_Spanish_CI_AS,
	PRIMARY KEY ("AlumnoID")
);

-- Data exporting was unselected.

-- Dumping structure for table GESTIONEXPEDIENTE.Expediente
CREATE TABLE IF NOT EXISTS "Expediente" (
	"ExpedienteID" INT,
	"AlumnoID" INT DEFAULT NULL,
	"MaterialID" INT DEFAULT NULL,
	"NotaFinal" FLOAT DEFAULT NULL,
	"Observaciones" NVARCHAR(200) DEFAULT NULL COLLATE Modern_Spanish_CI_AS,
	FOREIGN KEY INDEX "FK__Expedient__Alumn__3E52440B" ("AlumnoID"),
	FOREIGN KEY INDEX "FK__Expedient__Mater__3F466844" ("MaterialID"),
	FOREIGN KEY INDEX "FK_Expediente_Alumno" ("AlumnoID"),
	PRIMARY KEY ("ExpedienteID"),
	CONSTRAINT "FK__Expedient__Alumn__3E52440B" FOREIGN KEY ("AlumnoID") REFERENCES "Alumno" ("AlumnoID") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK_Expediente_Alumno" FOREIGN KEY ("AlumnoID") REFERENCES "Alumno" ("AlumnoID") ON UPDATE NO_ACTION ON DELETE CASCADE,
	CONSTRAINT "FK__Expedient__Mater__3F466844" FOREIGN KEY ("MaterialID") REFERENCES "Materia" ("MaterialID") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Data exporting was unselected.

-- Dumping structure for table GESTIONEXPEDIENTE.Materia
CREATE TABLE IF NOT EXISTS "Materia" (
	"MaterialID" INT,
	"NombreMateria" NVARCHAR(100) DEFAULT NULL COLLATE Modern_Spanish_CI_AS,
	"Docente" NVARCHAR(100) DEFAULT NULL COLLATE Modern_Spanish_CI_AS,
	PRIMARY KEY ("MaterialID")
);

-- Data exporting was unselected.

-- Dumping structure for table GESTIONEXPEDIENTE.__EFMigrationsHistory
CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
	"MigrationId" NVARCHAR(150) COLLATE Modern_Spanish_CI_AS,
	"ProductVersion" NVARCHAR(32) COLLATE Modern_Spanish_CI_AS,
	PRIMARY KEY ("MigrationId")
);

-- Data exporting was unselected.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
