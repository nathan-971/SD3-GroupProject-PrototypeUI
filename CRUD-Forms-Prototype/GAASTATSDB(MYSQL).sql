CREATE DATABASE  IF NOT EXISTS `gaastatsdb` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci */;
USE `gaastatsdb`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: gaastatsdb
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.28-MariaDB

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
-- Table structure for table `action`
--

DROP TABLE IF EXISTS `action`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `action` (
  `A_ID` int(11) NOT NULL,
  `A_Title` varchar(45) NOT NULL,
  `A_IsPositive` tinyint(4) NOT NULL,
  `A_Deleted` tinyint(4) NOT NULL,
  PRIMARY KEY (`A_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `action`
--

LOCK TABLES `action` WRITE;
/*!40000 ALTER TABLE `action` DISABLE KEYS */;
/*!40000 ALTER TABLE `action` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `game`
--

DROP TABLE IF EXISTS `game`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `game` (
  `G_ID` int(11) NOT NULL,
  `G_StartTime` datetime DEFAULT NULL,
  `G_EndTime` datetime DEFAULT NULL,
  `G_Deleted` tinyint(4) NOT NULL,
  PRIMARY KEY (`G_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `game`
--

LOCK TABLES `game` WRITE;
/*!40000 ALTER TABLE `game` DISABLE KEYS */;
/*!40000 ALTER TABLE `game` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jerseynumber`
--

DROP TABLE IF EXISTS `jerseynumber`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jerseynumber` (
  `JN_ID` int(11) NOT NULL,
  `JN_Title` varchar(45) NOT NULL,
  PRIMARY KEY (`JN_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jerseynumber`
--

LOCK TABLES `jerseynumber` WRITE;
/*!40000 ALTER TABLE `jerseynumber` DISABLE KEYS */;
/*!40000 ALTER TABLE `jerseynumber` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `playeraction`
--

DROP TABLE IF EXISTS `playeraction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `playeraction` (
  `PA_ID` int(11) NOT NULL,
  `PA_User` int(11) NOT NULL,
  `PA_Action` int(11) NOT NULL,
  `PA_Zone` int(11) NOT NULL,
  `PA_Deleted` tinyint(4) NOT NULL,
  PRIMARY KEY (`PA_ID`),
  KEY `FK_Z_idx` (`PA_Zone`),
  KEY `FK_A_idx` (`PA_Action`),
  KEY `FK_U_idx` (`PA_User`),
  CONSTRAINT `FK_A` FOREIGN KEY (`PA_Action`) REFERENCES `action` (`A_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_U` FOREIGN KEY (`PA_User`) REFERENCES `user` (`U_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Z` FOREIGN KEY (`PA_Zone`) REFERENCES `zone` (`Z_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `playeraction`
--

LOCK TABLES `playeraction` WRITE;
/*!40000 ALTER TABLE `playeraction` DISABLE KEYS */;
/*!40000 ALTER TABLE `playeraction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `playerpositiion`
--

DROP TABLE IF EXISTS `playerpositiion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `playerpositiion` (
  `PP_ID` int(11) NOT NULL,
  `PP_Title` varchar(45) NOT NULL,
  `PP_Deleted` tinyint(4) NOT NULL,
  PRIMARY KEY (`PP_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `playerpositiion`
--

LOCK TABLES `playerpositiion` WRITE;
/*!40000 ALTER TABLE `playerpositiion` DISABLE KEYS */;
/*!40000 ALTER TABLE `playerpositiion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `role` (
  `R_ID` int(11) NOT NULL,
  `R_Title` varchar(45) DEFAULT NULL,
  `R_Deleted` tinyint(4) NOT NULL,
  PRIMARY KEY (`R_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `team`
--

DROP TABLE IF EXISTS `team`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `team` (
  `T_ID` int(11) NOT NULL,
  `T_Name` varchar(45) NOT NULL,
  `T_Deleted` tinyint(4) NOT NULL,
  PRIMARY KEY (`T_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `team`
--

LOCK TABLES `team` WRITE;
/*!40000 ALTER TABLE `team` DISABLE KEYS */;
/*!40000 ALTER TABLE `team` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teamgame`
--

DROP TABLE IF EXISTS `teamgame`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `teamgame` (
  `TG_Team` int(11) NOT NULL,
  `TG_Game` int(11) NOT NULL,
  `TG_Deleted` tinyint(4) NOT NULL,
  PRIMARY KEY (`TG_Team`,`TG_Game`),
  KEY `fk_Team_has_Game_Game1_idx` (`TG_Game`),
  KEY `fk_Team_has_Game_Team1_idx` (`TG_Team`),
  CONSTRAINT `FK_G` FOREIGN KEY (`TG_Game`) REFERENCES `game` (`G_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_T` FOREIGN KEY (`TG_Team`) REFERENCES `team` (`T_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teamgame`
--

LOCK TABLES `teamgame` WRITE;
/*!40000 ALTER TABLE `teamgame` DISABLE KEYS */;
/*!40000 ALTER TABLE `teamgame` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `U_ID` int(11) NOT NULL,
  `U_Name` varchar(45) NOT NULL,
  `U_Email` varchar(45) NOT NULL,
  `U_Team` int(11) DEFAULT NULL,
  `U_Role` int(11) NOT NULL,
  `U_Position` int(11) DEFAULT NULL,
  `U_JerseyNumber` int(11) NOT NULL,
  `U_Deleted` tinyint(1) NOT NULL,
  PRIMARY KEY (`U_ID`),
  KEY `FK_JN_idx` (`U_JerseyNumber`),
  KEY `FK_R_idx` (`U_Role`),
  KEY `FK_PP_idx` (`U_Position`),
  KEY `FK_Team_idx` (`U_Team`),
  CONSTRAINT `FK_JN` FOREIGN KEY (`U_JerseyNumber`) REFERENCES `jerseynumber` (`JN_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_PP` FOREIGN KEY (`U_Position`) REFERENCES `playerpositiion` (`PP_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_R` FOREIGN KEY (`U_Role`) REFERENCES `role` (`R_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Team` FOREIGN KEY (`U_Team`) REFERENCES `team` (`T_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zone`
--

DROP TABLE IF EXISTS `zone`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zone` (
  `Z_ID` int(11) NOT NULL,
  `Z_Title` varchar(45) NOT NULL,
  PRIMARY KEY (`Z_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zone`
--

LOCK TABLES `zone` WRITE;
/*!40000 ALTER TABLE `zone` DISABLE KEYS */;
/*!40000 ALTER TABLE `zone` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'gaastatsdb'
--

--
-- Dumping routines for database 'gaastatsdb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-10-04 18:42:17
