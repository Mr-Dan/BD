-- MySQL dump 10.13  Distrib 5.6.23, for Win32 (x86)
--
-- Host: localhost    Database: bd
-- ------------------------------------------------------
-- Server version	5.7.37-log

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
-- Table structure for table `orders_dish`
--

DROP TABLE IF EXISTS `orders_dish`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders_dish` (
  `IdOrders_dish` int(11) NOT NULL AUTO_INCREMENT,
  `Cost` decimal(12,0) NOT NULL,
  `IdOrder` int(11) NOT NULL,
  `IdDish` int(11) NOT NULL,
  `StatusDish` varchar(45) NOT NULL DEFAULT 'В процессе',
  PRIMARY KEY (`IdOrders_dish`,`IdOrder`,`IdDish`),
  KEY `fk_Orders_Dish_Order1_idx` (`IdOrder`),
  KEY `fk_Orders_Dish_Dish1_idx` (`IdDish`),
  CONSTRAINT `fk_Orders_Dish_Dish1` FOREIGN KEY (`IdDish`) REFERENCES `dish` (`IdDish`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Orders_Dish_Order1` FOREIGN KEY (`IdOrder`) REFERENCES `orders` (`IdOrder`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders_dish`
--

LOCK TABLES `orders_dish` WRITE;
/*!40000 ALTER TABLE `orders_dish` DISABLE KEYS */;
INSERT INTO `orders_dish` VALUES (43,100,29,1,'Готово'),(44,100,29,1,'Готово'),(45,60,30,7,'Готово'),(46,60,30,7,'Готово'),(47,60,31,6,'Готово'),(48,60,31,6,'В процессе'),(49,60,31,6,'В процессе'),(50,60,32,7,'В процессе'),(51,60,33,7,'Готово');
/*!40000 ALTER TABLE `orders_dish` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-17  2:04:48
