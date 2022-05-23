CREATE DATABASE  IF NOT EXISTS `bd` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `bd`;
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
-- Table structure for table `warehouse`
--

DROP TABLE IF EXISTS `warehouse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `warehouse` (
  `IdProductsWarehouse` int(11) NOT NULL AUTO_INCREMENT,
  `IdProducts` int(11) NOT NULL,
  `CountProduct` double NOT NULL,
  `ShelfLifeProduct` varchar(45) NOT NULL,
  PRIMARY KEY (`IdProductsWarehouse`),
  KEY `fk_Warehouse_Products1_idx` (`IdProducts`),
  CONSTRAINT `fk_Warehouse_Products1` FOREIGN KEY (`IdProducts`) REFERENCES `products` (`IdProducts`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `warehouse`
--

LOCK TABLES `warehouse` WRITE;
/*!40000 ALTER TABLE `warehouse` DISABLE KEYS */;
INSERT INTO `warehouse` VALUES (18,5,45,'05-18-2022 00:45:04'),(25,1,54,'05-17-2022 00:45:04'),(26,6,40,'05-17-2022 00:45:04'),(27,2,20,'05-17-2022 00:45:04'),(28,4,43,'05-17-2022 00:45:04'),(29,3,45,'05-18-2022 00:47:04');
/*!40000 ALTER TABLE `warehouse` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `bd`.`warehouse_AFTER_INSERT` AFTER INSERT ON `warehouse` FOR EACH ROW
BEGIN
DECLARE dish_id INT  DEFAULT 0;    
DECLARE i INT DEFAULT 0;  
DECLARE test INT DEFAULT 0;  
DECLARE Get_Dish CURSOR FOR SELECT IdDish FROM dish;

OPEN Get_Dish;
while i< (select count(IdDish) from dish) do
	FETCH Get_Dish INTO dish_id;  	
		set test= test_function(dish_id);
        IF(test=0) then
			update dish set  InStock=0 where IdDish=dish_id;
        else 
        update dish set  InStock=1 where IdDish=dish_id;
        END IF;
	SET  i=i+1;
END WHILE;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `bd`.`warehouse_AFTER_UPDATE` AFTER UPDATE ON `warehouse` FOR EACH ROW
BEGIN
DECLARE dish_id INT  DEFAULT 0;    
DECLARE i INT DEFAULT 0;  
DECLARE test INT DEFAULT 0;  
DECLARE Get_Dish CURSOR FOR SELECT IdDish FROM dish;

OPEN Get_Dish;
while i< (select count(IdDish) from dish) do
	FETCH Get_Dish INTO dish_id;  	
		set test= test_function(dish_id);
        IF(test=0) then
			update dish set  InStock=0 where IdDish=dish_id;
        else 
        update dish set  InStock=1 where IdDish=dish_id;
        END IF;
	SET  i=i+1;
END WHILE;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `bd`.`warehouse_AFTER_DELETE` AFTER DELETE ON `warehouse` FOR EACH ROW
BEGIN
DECLARE dish_id INT  DEFAULT 0;    
DECLARE i INT DEFAULT 0;  
DECLARE test INT DEFAULT 0;  
DECLARE Get_Dish CURSOR FOR SELECT IdDish FROM dish;

OPEN Get_Dish;
while i< (select count(IdDish) from dish) do
	FETCH Get_Dish INTO dish_id;  	
		set test= test_function(dish_id);
        IF(test=0) then
			update dish set  InStock=0 where IdDish=dish_id;
        else 
        update dish set  InStock=1 where IdDish=dish_id;
        END IF;
	SET  i=i+1;
END WHILE;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-24  1:01:43
