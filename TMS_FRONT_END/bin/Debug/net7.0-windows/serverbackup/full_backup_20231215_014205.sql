-- MySqlBackup.NET 2.3.8.0
-- Dump Time: 2023-12-15 01:42:05
-- --------------------------------------
-- Server version 8.0.34 MySQL Community Server - GPL


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of __efmigrationshistory
-- 

DROP TABLE IF EXISTS `__efmigrationshistory`;
CREATE TABLE IF NOT EXISTS `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table __efmigrationshistory
-- 

/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory`(`MigrationId`,`ProductVersion`) VALUES('20231214220833_InitialDB','7.0.7'),('20231214222604_AdminUpdate','7.0.7'),('20231214230411_AdminDataUpdate','7.0.7'),('20231215000631_AddedDemoAcc','7.0.7'),('20231215005929_BackupForSqlFunctionCreated','7.0.7'),('20231215035254_CarrierDataAdded','7.0.7');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;

-- 
-- Definition of admin
-- 

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `AdminId` int NOT NULL AUTO_INCREMENT,
  `AdminName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `AdminPassword` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `AdminDOB` datetime(6) NOT NULL,
  `AdminEmail` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `AdminPhone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`AdminId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table admin
-- 

/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin`(`AdminId`,`AdminName`,`AdminPassword`,`AdminDOB`,`AdminEmail`,`AdminPhone`) VALUES(1,'Admin1','Password1','1990-01-01 00:00:00.000000','admin1@example.com','1234567890'),(2,'Admin2','Password2','1991-02-02 00:00:00.000000','admin2@example.com','2345678901'),(3,'Admin3','Password3','1996-07-07 00:00:00.000000','admin3@example.com','7890123456');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;

-- 
-- Definition of buyer
-- 

DROP TABLE IF EXISTS `buyer`;
CREATE TABLE IF NOT EXISTS `buyer` (
  `BuyerId` int NOT NULL AUTO_INCREMENT,
  `BuyerName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BuyerPassword` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BuyerEmail` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BuyerDOB` datetime(6) NOT NULL,
  `BuyerPhone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`BuyerId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table buyer
-- 

/*!40000 ALTER TABLE `buyer` DISABLE KEYS */;
INSERT INTO `buyer`(`BuyerId`,`BuyerName`,`BuyerPassword`,`BuyerEmail`,`BuyerDOB`,`BuyerPhone`) VALUES(1,'Buyer1','Password1','Buyer1@example.com','1990-01-01 00:00:00.000000','1234567890'),(2,'Buyer2','Password2','Buyer2@example.com','1991-02-02 00:00:00.000000','2345678901'),(3,'Buyer3','Password3','Buyer3@example.com','1996-07-07 00:00:00.000000','7890123456');
/*!40000 ALTER TABLE `buyer` ENABLE KEYS */;

-- 
-- Definition of carriers
-- 

DROP TABLE IF EXISTS `carriers`;
CREATE TABLE IF NOT EXISTS `carriers` (
  `CarrierID` int NOT NULL AUTO_INCREMENT,
  `CarrierName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DepotCity` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `FTLAvailability` int NOT NULL DEFAULT '0',
  `FTLRate` double NOT NULL DEFAULT '0',
  `LTLAvailability` int NOT NULL DEFAULT '0',
  `LTLRate` double NOT NULL DEFAULT '0',
  `ReefCharge` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`CarrierID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table carriers
-- 

/*!40000 ALTER TABLE `carriers` DISABLE KEYS */;
INSERT INTO `carriers`(`CarrierID`,`CarrierName`,`DepotCity`,`FTLAvailability`,`FTLRate`,`LTLAvailability`,`LTLRate`,`ReefCharge`) VALUES(1,'Planet Express','Windsor',50,5.21,640,0.3621,0.08),(2,'Planet Express','Hamilton',50,5.21,640,0.3621,0.08),(3,'Planet Express','Oshawa',50,5.21,640,0.3621,0.08),(4,'Planet Express','Belleville',50,5.21,640,0.3621,0.08),(5,'Planet Express','Ottawa',50,5.21,640,0.3621,0.08),(6,'Schooner''s','London',18,5.05,98,0.3434,0.07),(7,'Schooner''s','Toronto',18,5.05,98,0.3434,0.07),(8,'Schooner''s','Kingston',18,5.05,98,0.3434,0.07),(9,'Tillman Transport','Windsor',24,5.11,35,0.3012,0.09),(10,'Tillman Transport','London',18,5.11,45,0.3012,0.09),(11,'Tillman Transport','Hamilton',18,5.11,45,0.3012,0.09),(12,'We Haul','Ottawa',11,5.2,0,0,0.065),(13,'We Haul','Toronto',11,5.2,0,0,0.065);
/*!40000 ALTER TABLE `carriers` ENABLE KEYS */;

-- 
-- Definition of contractmarketplace
-- 

DROP TABLE IF EXISTS `contractmarketplace`;
CREATE TABLE IF NOT EXISTS `contractmarketplace` (
  `MarketPlaceId` int NOT NULL AUTO_INCREMENT,
  `MarketPlaceName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `MarketPlaceCode` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MarketPlaceId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table contractmarketplace
-- 

/*!40000 ALTER TABLE `contractmarketplace` DISABLE KEYS */;

/*!40000 ALTER TABLE `contractmarketplace` ENABLE KEYS */;

-- 
-- Definition of customer
-- 

DROP TABLE IF EXISTS `customer`;
CREATE TABLE IF NOT EXISTS `customer` (
  `UserId` int NOT NULL AUTO_INCREMENT,
  `UserName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UserEmail` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UserPassword` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UserDOB` datetime(6) NOT NULL,
  `UserPhone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table customer
-- 

/*!40000 ALTER TABLE `customer` DISABLE KEYS */;

/*!40000 ALTER TABLE `customer` ENABLE KEYS */;

-- 
-- Definition of logentry
-- 

DROP TABLE IF EXISTS `logentry`;
CREATE TABLE IF NOT EXISTS `logentry` (
  `LogId` int NOT NULL AUTO_INCREMENT,
  `Timestamp` datetime(6) NOT NULL,
  `Action` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`LogId`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table logentry
-- 

/*!40000 ALTER TABLE `logentry` DISABLE KEYS */;
INSERT INTO `logentry`(`LogId`,`Timestamp`,`Action`,`Description`) VALUES(1,'2023-12-15 00:47:59.833379','INFO','Admin Logged In'),(2,'2023-12-15 00:51:23.249132','INFO','Admin Logged In'),(3,'2023-12-15 00:51:25.006859','INFO','Log Info Accessed.'),(4,'2023-12-15 00:51:27.013788','INFO','Log Info Accessed.'),(5,'2023-12-15 00:51:28.621542','INFO','Log Info Accessed.'),(6,'2023-12-15 00:51:31.412760','INFO','Log Info Accessed.'),(7,'2023-12-15 00:51:31.631939','INFO','Log Info Accessed.'),(8,'2023-12-15 00:51:31.868869','INFO','Log Info Accessed.'),(9,'2023-12-15 00:51:32.081271','INFO','Log Info Accessed.'),(10,'2023-12-15 00:51:32.303960','INFO','Log Info Accessed.'),(11,'2023-12-15 01:15:27.254940','INFO','Log Info Accessed.'),(12,'2023-12-15 01:15:28.169853','INFO','Log Info Accessed.'),(13,'2023-12-15 01:32:28.221244','INFO','Admin Logged In'),(14,'2023-12-15 01:33:05.448660','INFO','Log Info Accessed.');
/*!40000 ALTER TABLE `logentry` ENABLE KEYS */;

-- 
-- Definition of orders
-- 

DROP TABLE IF EXISTS `orders`;
CREATE TABLE IF NOT EXISTS `orders` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `BuyerID` int NOT NULL,
  `OrderDate` datetime(6) NOT NULL,
  `Status` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `InvoiceGenerated` tinyint(1) NOT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `IX_Orders_BuyerID` (`BuyerID`),
  CONSTRAINT `FK_Orders_Customer_BuyerID` FOREIGN KEY (`BuyerID`) REFERENCES `customer` (`UserId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table orders
-- 

/*!40000 ALTER TABLE `orders` DISABLE KEYS */;

/*!40000 ALTER TABLE `orders` ENABLE KEYS */;

-- 
-- Definition of planner
-- 

DROP TABLE IF EXISTS `planner`;
CREATE TABLE IF NOT EXISTS `planner` (
  `PlannerId` int NOT NULL AUTO_INCREMENT,
  `PlannerName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PlannerPassword` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PlannerEmail` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PlannerDOB` datetime(6) NOT NULL,
  `PlannerPhone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`PlannerId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table planner
-- 

/*!40000 ALTER TABLE `planner` DISABLE KEYS */;
INSERT INTO `planner`(`PlannerId`,`PlannerName`,`PlannerPassword`,`PlannerEmail`,`PlannerDOB`,`PlannerPhone`) VALUES(1,'Planner1','Password1','Planner1@example.com','1990-01-01 00:00:00.000000','1234567890'),(2,'Planner2','Password2','Planner2@example.com','1991-02-02 00:00:00.000000','2345678901'),(3,'Planner3','Password3','Planner3@example.com','1996-07-07 00:00:00.000000','7890123456');
/*!40000 ALTER TABLE `planner` ENABLE KEYS */;

-- 
-- Definition of ratefee
-- 

DROP TABLE IF EXISTS `ratefee`;
CREATE TABLE IF NOT EXISTS `ratefee` (
  `RateFeeID` int NOT NULL AUTO_INCREMENT,
  `Description` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `FeeAmount` decimal(65,30) NOT NULL,
  PRIMARY KEY (`RateFeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table ratefee
-- 

/*!40000 ALTER TABLE `ratefee` DISABLE KEYS */;

/*!40000 ALTER TABLE `ratefee` ENABLE KEYS */;

-- 
-- Definition of route
-- 

DROP TABLE IF EXISTS `route`;
CREATE TABLE IF NOT EXISTS `route` (
  `RouteID` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`RouteID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table route
-- 

/*!40000 ALTER TABLE `route` DISABLE KEYS */;

/*!40000 ALTER TABLE `route` ENABLE KEYS */;

-- 
-- Definition of trips
-- 

DROP TABLE IF EXISTS `trips`;
CREATE TABLE IF NOT EXISTS `trips` (
  `TripID` int NOT NULL AUTO_INCREMENT,
  `OrderID` int NOT NULL,
  `CarrierID` int NOT NULL,
  PRIMARY KEY (`TripID`),
  KEY `IX_Trips_CarrierID` (`CarrierID`),
  KEY `IX_Trips_OrderID` (`OrderID`),
  CONSTRAINT `FK_Trips_Carriers_CarrierID` FOREIGN KEY (`CarrierID`) REFERENCES `carriers` (`CarrierID`) ON DELETE CASCADE,
  CONSTRAINT `FK_Trips_Orders_OrderID` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table trips
-- 

/*!40000 ALTER TABLE `trips` DISABLE KEYS */;

/*!40000 ALTER TABLE `trips` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2023-12-15 01:42:05
-- Total time: 0:0:0:0:129 (d:h:m:s:ms)
