CREATE DATABASE `dbapidotnetcore` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `dbapidotnetcore`;

CREATE TABLE `Account` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserLogin` varchar(100) DEFAULT NULL,
  `DateRegister` datetime DEFAULT NULL,
  `InputType` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `InputValue` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `account_id_IDX` (`Id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb3;


CREATE TABLE `User` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  `Surname` varchar(50) DEFAULT NULL,
  `Email` varchar(150) DEFAULT NULL,
  `Phone` char(10) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `LastLogon` datetime(6) DEFAULT NULL,
  `CreatedOn` datetime(6) DEFAULT NULL,
  `ActivationCode` int DEFAULT NULL,
  `Login` varchar(50) NOT NULL,
  `Password` varchar(150) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb3;
