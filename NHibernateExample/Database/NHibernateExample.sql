-- MySQL dump 10.16  Distrib 10.1.31-MariaDB, for Win32 (AMD64)
--
-- Host: localhost    Database: test
-- ------------------------------------------------------
-- Server version	10.1.31-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `test`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `test` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `test`;

--
-- Table structure for table `person`
--

DROP TABLE IF EXISTS `person`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `person` (
  `PERSON_ID` int(11) NOT NULL AUTO_INCREMENT,
  `PERSON_NAME` text NOT NULL,
  `PERSON_SURNAME` text,
  `PERSON_STREET` text,
  `PERSON_CITY` text,
  PRIMARY KEY (`PERSON_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `person`
--

LOCK TABLES `person` WRITE;
/*!40000 ALTER TABLE `person` DISABLE KEYS */;
INSERT INTO `person` VALUES (1,'TestPerson1','TestSurname1','TestStreet1','TestCity1'),(2,'TestPerson2','TestSurname2','TestStreet2','TestCity2'),(3,'TestPerson3','TestSurname3','TestStreet3','TestCity3'),(4,'TestPerson4','TestSurname4','TestStreet4','TestCity4'),(5,'TestPerson5','TestSurname5','TestStreet5','TestCity5'),(6,'SavedPerson1','SavedSurname1',NULL,NULL),(14,'EditedName28','EditedSurname28',NULL,NULL),(17,'EditedName59','EditedSurname59',NULL,NULL),(18,'SavedPerson79','SavedSurname79',NULL,NULL),(19,'TestPerson6','TestSurname6','TestStreet6','TestCity6'),(20,'SavedPerson22','SavedSurname22',NULL,NULL);
/*!40000 ALTER TABLE `person` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dog`
--

DROP TABLE IF EXISTS `dog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dog` (
  `DOG_ID` int(11) NOT NULL AUTO_INCREMENT,
  `DOG_NAME` text NOT NULL,
  `DOG_BREED` text,
  `DOG_OWNER_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`DOG_ID`),
  UNIQUE KEY `unique_owner` (`DOG_OWNER_ID`),
  KEY `DOG_OWNER_FK` (`DOG_OWNER_ID`),
  CONSTRAINT `DOG_OWNER_FK` FOREIGN KEY (`DOG_OWNER_ID`) REFERENCES `person` (`PERSON_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dog`
--

LOCK TABLES `dog` WRITE;
/*!40000 ALTER TABLE `dog` DISABLE KEYS */;
INSERT INTO `dog` VALUES (21,'TestDog1','TestBreed1',1),(22,'TestDog2','TestBreed2',2),(23,'TestDog3','TestBreed3',3),(24,'TestDog4','TestBreed4',4),(25,'TestDog5','TestBreed5',5),(26,'TestDog6','TestBreed6',NULL),(27,'TestDog7','TestBreed7',NULL),(28,'TestDog8','TestBreed8',NULL),(29,'TestDog9','TestBreed9',6);
/*!40000 ALTER TABLE `dog` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-01 15:31:23
