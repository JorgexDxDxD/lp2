CREATE DATABASE  IF NOT EXISTS `inf282g4` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `inf282g4`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: quilla.lab.inf.pucp.edu.pe    Database: inf282g4
-- ------------------------------------------------------
-- Server version	5.5.54

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
-- Table structure for table `Almacen`
--

DROP TABLE IF EXISTS `Almacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Almacen` (
  `Local_idLocal` int(11) NOT NULL AUTO_INCREMENT,
  `Empresa_ruc` int(11) NOT NULL,
  PRIMARY KEY (`Local_idLocal`),
  CONSTRAINT `fk_Almacen_Local1` FOREIGN KEY (`Local_idLocal`) REFERENCES `Local` (`idLocal`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Almacen`
--

LOCK TABLES `Almacen` WRITE;
/*!40000 ALTER TABLE `Almacen` DISABLE KEYS */;
/*!40000 ALTER TABLE `Almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Cliente`
--

DROP TABLE IF EXISTS `Cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Cliente` (
  `codigoCliente` int(11) NOT NULL AUTO_INCREMENT,
  `telefono` varchar(15) NOT NULL,
  `correo` varchar(30) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `fechaDeRegistro` date NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `idVendedor` int(11) DEFAULT NULL,
  PRIMARY KEY (`codigoCliente`),
  KEY `Usuario_codigoUsuario_idx` (`idVendedor`),
  CONSTRAINT `Usuario_codigoUsuario` FOREIGN KEY (`idVendedor`) REFERENCES `Vendedor` (`Usuario_codigoUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Cliente`
--

LOCK TABLES `Cliente` WRITE;
/*!40000 ALTER TABLE `Cliente` DISABLE KEYS */;
INSERT INTO `Cliente` VALUES (1,'12312312424','asdas@asd.com','AV ASASDFAS','2018-05-23',1,3),(2,'123123','asd@pasd.com','av dsa 32','2018-05-23',1,3),(3,'4562134414','asd@yahoo.com','JR SOLEDAD','2018-05-23',1,3),(12,'4564568','pura@aleluya.fe','JR. Quien Sabe 123','2018-05-23',1,3),(13,'343141231','prof@pucp.pe','AV LA MARINA','2018-05-23',1,3),(16,'74546','diva@diva','dsfasgfa','2018-05-23',1,3),(17,'5825851','salvador@aleluya.fe','AV. Cerca De Ti','2018-05-23',1,3),(21,'98352753','email@email.em','YA PE','2018-05-23',1,3),(22,'92748141','asdfas@pucp.pe','LA VICTORIA','2018-05-23',1,3),(23,'445778998','gg@gmail.com','ROSARIO1234','2018-05-23',1,3),(28,'985637357','pgurerro@pucp.pe','AV ABTAO 6B','0000-00-00',1,NULL);
/*!40000 ALTER TABLE `Cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Color`
--

DROP TABLE IF EXISTS `Color`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Color` (
  `idColor` int(11) NOT NULL AUTO_INCREMENT,
  `nombreColor` varchar(15) NOT NULL,
  PRIMARY KEY (`idColor`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Color`
--

LOCK TABLES `Color` WRITE;
/*!40000 ALTER TABLE `Color` DISABLE KEYS */;
INSERT INTO `Color` VALUES (1,'Niquel'),(2,'Negro'),(3,'Blanco'),(4,'Gris');
/*!40000 ALTER TABLE `Color` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ComponenteKit`
--

DROP TABLE IF EXISTS `ComponenteKit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ComponenteKit` (
  `cantidad` double NOT NULL,
  `Kit_Producto_codigo` int(11) NOT NULL,
  `Producto_codigo` int(11) NOT NULL,
  PRIMARY KEY (`Kit_Producto_codigo`,`Producto_codigo`),
  KEY `fk_ComponenteKit_Producto1_idx` (`Producto_codigo`),
  CONSTRAINT `fk_ComponenteKit_Kit1` FOREIGN KEY (`Kit_Producto_codigo`) REFERENCES `Kit` (`Producto_codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ComponenteKit_Producto1` FOREIGN KEY (`Producto_codigo`) REFERENCES `Producto` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ComponenteKit`
--

LOCK TABLES `ComponenteKit` WRITE;
/*!40000 ALTER TABLE `ComponenteKit` DISABLE KEYS */;
INSERT INTO `ComponenteKit` VALUES (3,3,1),(2,3,2),(1,12,1),(2,13,1),(4,16,1),(4,16,2),(2,16,14);
/*!40000 ALTER TABLE `ComponenteKit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `DetalleProd`
--

DROP TABLE IF EXISTS `DetalleProd`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `DetalleProd` (
  `Producto_codigo` int(11) NOT NULL AUTO_INCREMENT,
  `cantidad` double NOT NULL,
  `Local_idExhibicion` int(11) NOT NULL,
  PRIMARY KEY (`Producto_codigo`,`Local_idExhibicion`),
  KEY `fk_Local_idx` (`Local_idExhibicion`),
  CONSTRAINT `fk_DetalleProd_Producto1` FOREIGN KEY (`Producto_codigo`) REFERENCES `Producto` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Local` FOREIGN KEY (`Local_idExhibicion`) REFERENCES `Local` (`idLocal`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `DetalleProd`
--

LOCK TABLES `DetalleProd` WRITE;
/*!40000 ALTER TABLE `DetalleProd` DISABLE KEYS */;
INSERT INTO `DetalleProd` VALUES (3,2,34),(5,5,34),(5,4,35),(16,1,35);
/*!40000 ALTER TABLE `DetalleProd` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `DetalleVenta`
--

DROP TABLE IF EXISTS `DetalleVenta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `DetalleVenta` (
  `Venta_idVenta` int(11) NOT NULL,
  `Producto_codigo` int(11) NOT NULL,
  `cantidad` double NOT NULL,
  `Venta_Vendedor_Usuario_codigoUsuario` int(11) NOT NULL,
  PRIMARY KEY (`Venta_idVenta`,`Producto_codigo`),
  KEY `fk_Venta_has_Producto_Producto1_idx` (`Producto_codigo`),
  KEY `fk_DetalleVenta_Venta1_idx` (`Venta_idVenta`),
  CONSTRAINT `fk_DetalleVenta_Venta1` FOREIGN KEY (`Venta_idVenta`) REFERENCES `Venta` (`idVenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Venta_has_Producto_Producto1` FOREIGN KEY (`Producto_codigo`) REFERENCES `Producto` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `DetalleVenta`
--

LOCK TABLES `DetalleVenta` WRITE;
/*!40000 ALTER TABLE `DetalleVenta` DISABLE KEYS */;
INSERT INTO `DetalleVenta` VALUES (1,1,50,3),(1,2,1.5,3),(2,1,1,3),(3,4,20,3),(3,5,50,3),(4,3,1,3),(5,3,2,3),(6,3,2,3),(7,3,2,3),(8,3,2,3),(9,3,1,3),(9,12,1,3),(10,3,1,3),(10,12,1,3),(11,3,1,3),(12,3,1,3),(13,3,1,3),(14,4,10,3),(15,3,1,3),(15,16,1,3),(16,3,1,3);
/*!40000 ALTER TABLE `DetalleVenta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Empresa`
--

DROP TABLE IF EXISTS `Empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Empresa` (
  `ruc` varchar(10) NOT NULL,
  `direccionPrinc` varchar(50) NOT NULL,
  PRIMARY KEY (`ruc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Empresa`
--

LOCK TABLES `Empresa` WRITE;
/*!40000 ALTER TABLE `Empresa` DISABLE KEYS */;
/*!40000 ALTER TABLE `Empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Exhibicion`
--

DROP TABLE IF EXISTS `Exhibicion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Exhibicion` (
  `Local_idLocal` int(11) NOT NULL AUTO_INCREMENT,
  `diaIni` varchar(10) NOT NULL,
  `diaFin` varchar(10) NOT NULL,
  `horaIni` time NOT NULL,
  `horaFin` time NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `Cliente_codigoCliente` int(11) DEFAULT NULL,
  PRIMARY KEY (`Local_idLocal`),
  KEY `fk_Exhibicion_Cliente1_idx` (`Cliente_codigoCliente`),
  CONSTRAINT `fk_Exhibicion_Cliente1` FOREIGN KEY (`Cliente_codigoCliente`) REFERENCES `Cliente` (`codigoCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Exhibicion_Local1` FOREIGN KEY (`Local_idLocal`) REFERENCES `Local` (`idLocal`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Exhibicion`
--

LOCK TABLES `Exhibicion` WRITE;
/*!40000 ALTER TABLE `Exhibicion` DISABLE KEYS */;
INSERT INTO `Exhibicion` VALUES (33,'Lunes','Lunes','21:33:26','01:33:26',1,22),(34,'Martes','Martes','21:43:43','04:43:43',1,13),(35,'Jueves','Jueves','21:49:50','07:49:50',1,17);
/*!40000 ALTER TABLE `Exhibicion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Gerente`
--

DROP TABLE IF EXISTS `Gerente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Gerente` (
  `Usuario_codigoUsuario` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Usuario_codigoUsuario`),
  CONSTRAINT `fk_Gerente_Usuario` FOREIGN KEY (`Usuario_codigoUsuario`) REFERENCES `Usuario` (`codigoUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Gerente`
--

LOCK TABLES `Gerente` WRITE;
/*!40000 ALTER TABLE `Gerente` DISABLE KEYS */;
INSERT INTO `Gerente` VALUES (1),(2),(7),(9),(10),(11),(12);
/*!40000 ALTER TABLE `Gerente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Juridico`
--

DROP TABLE IF EXISTS `Juridico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Juridico` (
  `Cliente_codigoCliente` int(11) NOT NULL AUTO_INCREMENT,
  `ruc` varchar(12) NOT NULL,
  `razon` varchar(45) NOT NULL,
  `representante` varchar(45) NOT NULL,
  PRIMARY KEY (`Cliente_codigoCliente`),
  CONSTRAINT `fk_Juridico_Cliente1` FOREIGN KEY (`Cliente_codigoCliente`) REFERENCES `Cliente` (`codigoCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Juridico`
--

LOCK TABLES `Juridico` WRITE;
/*!40000 ALTER TABLE `Juridico` DISABLE KEYS */;
INSERT INTO `Juridico` VALUES (1,'20521314987','EMPRESA1','Av. Javier prado 66'),(2,'20524894526','Empresa 2','Av. Universitaria 123'),(17,'987511321561','El Cielo Te Ve','Jesus Elegido'),(21,'12414124','DEBERIA','ME'),(28,'512512514512','INOTEC','PAOLO GUERRERO');
/*!40000 ALTER TABLE `Juridico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Kit`
--

DROP TABLE IF EXISTS `Kit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Kit` (
  `Producto_codigo` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Producto_codigo`),
  CONSTRAINT `fk_Kit_Producto1` FOREIGN KEY (`Producto_codigo`) REFERENCES `Producto` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Kit`
--

LOCK TABLES `Kit` WRITE;
/*!40000 ALTER TABLE `Kit` DISABLE KEYS */;
INSERT INTO `Kit` VALUES (3),(12),(13),(16);
/*!40000 ALTER TABLE `Kit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Local`
--

DROP TABLE IF EXISTS `Local`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Local` (
  `idLocal` int(11) NOT NULL AUTO_INCREMENT,
  `direccion` varchar(50) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  PRIMARY KEY (`idLocal`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Local`
--

LOCK TABLES `Local` WRITE;
/*!40000 ALTER TABLE `Local` DISABLE KEYS */;
INSERT INTO `Local` VALUES (5,'San Borja 123 los Pericos','998665335'),(29,'San miguel 432 M.Grau','994638362'),(30,'Pueblo Libre 414 S.Juan','974074392'),(31,'Nuevo Surco 532. Calle Grau','916394933'),(32,'Miraflores 666 Los laures','900373822'),(33,'LAS BEGONIAS','134124'),(34,'ARMADITOS.CSV','2142512241'),(35,'DASDAS','97847525');
/*!40000 ALTER TABLE `Local` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Natural`
--

DROP TABLE IF EXISTS `Natural`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Natural` (
  `Cliente_codigoCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(60) NOT NULL,
  `apellidoPaterno` varchar(60) NOT NULL,
  `apellidoMaterno` varchar(60) NOT NULL,
  `dni` varchar(10) NOT NULL,
  PRIMARY KEY (`Cliente_codigoCliente`),
  CONSTRAINT `fk_Natural_Cliente1` FOREIGN KEY (`Cliente_codigoCliente`) REFERENCES `Cliente` (`codigoCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Natural`
--

LOCK TABLES `Natural` WRITE;
/*!40000 ALTER TABLE `Natural` DISABLE KEYS */;
INSERT INTO `Natural` VALUES (3,'JUANCITO','POBRECITO','TRISTECITO','45238789'),(12,'Maria','Salve','Gracia','91827364'),(13,'LEIBNIZ','ASDA','WEQE','34114124'),(16,'NO ME LLAMES','JIJI','hdkjhfksjh','12421412'),(22,'JORGE GABRIEL','ALFARO','RAMOS','71324241'),(23,'RODRIGO','VELTREJO','SALAZAR','88445577');
/*!40000 ALTER TABLE `Natural` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Pais`
--

DROP TABLE IF EXISTS `Pais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Pais` (
  `idPais` int(11) NOT NULL AUTO_INCREMENT,
  `nombrePais` varchar(60) NOT NULL,
  PRIMARY KEY (`idPais`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Pais`
--

LOCK TABLES `Pais` WRITE;
/*!40000 ALTER TABLE `Pais` DISABLE KEYS */;
INSERT INTO `Pais` VALUES (1,'Austria'),(2,'Suiza'),(3,'Alemania'),(4,'Italia');
/*!40000 ALTER TABLE `Pais` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Producto`
--

DROP TABLE IF EXISTS `Producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Producto` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(200) NOT NULL,
  `familia` varchar(80) NOT NULL,
  `precio` double NOT NULL,
  `Proveedor_idProveedor` int(11) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `Color_idColor` int(11) DEFAULT NULL,
  `descuento` double NOT NULL,
  `UnidadMedida_idUnidadMedida` int(11) DEFAULT NULL,
  `Stock` double NOT NULL,
  `StockMinimo` double NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `fk_Producto_Proveedor1_idx` (`Proveedor_idProveedor`),
  KEY `fk_Producto_Color1_idx` (`Color_idColor`),
  KEY `fk_Producto_UnidadMedida1_idx` (`UnidadMedida_idUnidadMedida`),
  CONSTRAINT `fk_Producto_Color1` FOREIGN KEY (`Color_idColor`) REFERENCES `Color` (`idColor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Producto_Proveedor1` FOREIGN KEY (`Proveedor_idProveedor`) REFERENCES `Proveedor` (`idProveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Producto_UnidadMedida1` FOREIGN KEY (`UnidadMedida_idUnidadMedida`) REFERENCES `UnidadMedida` (`idUnidadMedida`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Producto`
--

LOCK TABLES `Producto` WRITE;
/*!40000 ALTER TABLE `Producto` DISABLE KEYS */;
INSERT INTO `Producto` VALUES (1,'CLIP-TOP','BISAGRAS',210,1,1,1,0,1,50,30),(2,'LEGRABOX','Sistemas box',150,1,1,3,0,2,133.5,40),(3,'COCINA-AYUDA','INTERNA',280,1,1,1,0,1,9,4),(4,'TANDEMBOX ANTARO','Sistemas box',14,1,1,2,0,2,70,10),(5,'PEGASUS','EXTRACCIONES',400,2,1,4,0,1,450,20),(12,'k','k',1,1,0,NULL,0,NULL,0,1),(13,'K','K',123,1,0,NULL,0,NULL,123,123),(14,'PRODUCTO1','CATE',100,1,1,1,0,1,100,100),(15,'PRODUCTO1','CATE',100,1,0,1,0,1,100,100),(16,'ASD','ASD',1000,1,1,NULL,0,NULL,100,100),(17,'ER','FDF',123,1,0,1,0,1,123,123),(18,'HHH','GGG',200,1,1,1,0,1,12,5),(19,'ZAPATOTIPO1','XXSHSHS',120,2,0,1,0,1,200,10);
/*!40000 ALTER TABLE `Producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Proveedor`
--

DROP TABLE IF EXISTS `Proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Proveedor` (
  `idProveedor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(60) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `Empresa_ruc` varchar(12) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `Pais_idPais` int(11) NOT NULL,
  PRIMARY KEY (`idProveedor`,`Pais_idPais`),
  KEY `fk_Proveedor_Pais1_idx` (`Pais_idPais`),
  CONSTRAINT `fk_Proveedor_Pais1` FOREIGN KEY (`Pais_idPais`) REFERENCES `Pais` (`idPais`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Proveedor`
--

LOCK TABLES `Proveedor` WRITE;
/*!40000 ALTER TABLE `Proveedor` DISABLE KEYS */;
INSERT INTO `Proveedor` VALUES (1,'Blum','voralberg','2342342','23424234',1,1),(2,'Peka','Zurich','123123','123123123',1,2),(3,'Mixal','Milano','123123','123123123',1,4);
/*!40000 ALTER TABLE `Proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `UnidadMedida`
--

DROP TABLE IF EXISTS `UnidadMedida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `UnidadMedida` (
  `idUnidadMedida` int(11) NOT NULL AUTO_INCREMENT,
  `nombreMedida` varchar(45) NOT NULL,
  PRIMARY KEY (`idUnidadMedida`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `UnidadMedida`
--

LOCK TABLES `UnidadMedida` WRITE;
/*!40000 ALTER TABLE `UnidadMedida` DISABLE KEYS */;
INSERT INTO `UnidadMedida` VALUES (1,'Caja de 50'),(2,'Caja de 100');
/*!40000 ALTER TABLE `UnidadMedida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Usuario`
--

DROP TABLE IF EXISTS `Usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Usuario` (
  `codigoUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `apellidoPaterno` varchar(60) NOT NULL,
  `apellidoMaterno` varchar(60) NOT NULL,
  `nombre` varchar(60) NOT NULL,
  `correo` varchar(45) NOT NULL,
  `dni` varchar(10) NOT NULL,
  `sexo` varchar(15) NOT NULL,
  `fechaRegistro` date NOT NULL,
  `activo` tinyint(1) NOT NULL,
  `username` varchar(45) NOT NULL,
  `pass` varchar(45) NOT NULL,
  `prioridad` tinyint(4) NOT NULL,
  PRIMARY KEY (`codigoUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Usuario`
--

LOCK TABLES `Usuario` WRITE;
/*!40000 ALTER TABLE `Usuario` DISABLE KEYS */;
INSERT INTO `Usuario` VALUES (1,'GONZALES','RODRIGUEZ','FRANK','frankcj7@gmail.com','7053452','Masculino','2018-05-21',1,'admin','123456',1),(2,'ALFARO','RAMOS','JORGE','jorgexD@gmail.com','76984325','Masculino','2018-05-23',0,'JorgexDxDxD','elpro',1),(3,'ESPEZUA','PROFE','BRUNO','bruno.esp@pasdpas.com','12313112','Masculino','2018-05-23',1,'lol','123',3),(4,'CARINO','HIJAR','ARNULFO','xd@xd.com','4214214','Masculino','2018-05-23',0,'chan','123',3),(5,'LOPEZ','ROBERTO','ALFONSO','elchino@pucp.pe','12415151','Masculino','2018-05-24',0,'notrabajare','1234',3),(6,'PEREZ','GUZMAN','FERNANDO','a20114263@pucp.pe','47881327','Masculino','0000-00-00',1,'vendedor','123456',3),(7,'GUZMAN','JULIO','FERNANDO','sdfasd','123546','Femenino','2018-05-24',0,'admin2','asdasd',1),(8,'ASD','ASD','ASD','asd','123','Masculino','2018-05-25',0,'123','123',3),(9,'ASD','ASD','ASD','asdasd','123','Femenino','2018-05-26',0,'123','123',1),(10,'CARO','HIJAR','MARTIN','caroxdaniela@pucp.pe','715251112','Masculino','2018-05-29',1,'machino','daniela98',2),(11,'AVILA','ASD','PATO','PTO.AVILA@pucp.pe','5315315','Masculino','2018-05-29',1,'pato','pato',1),(12,'EASDA','DSA','SDAFS','asdfasf','123456789','Femenino','2018-05-30',0,'afsafasfasf','asd',1),(13,'RODRIGUEZ','TORRES','JUAN','lol@lolos.pe','73225698','Masculino','2018-05-30',1,'usuario','usuario',3),(14,'LALA','FLORES','LUIS','66@pucp.pe','1234567','Masculino','2018-05-30',1,'123123','123123',3),(15,'LOLE','LELO','EDUARDO','dd@pucp.pe','12312343','Masculino','2018-05-30',1,'12345','12345',3),(16,'NELSON','GATORADE','JERSON','ff@pucp.pe','1234567','Masculino','2018-05-30',1,'glo','xxx',3);
/*!40000 ALTER TABLE `Usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Vendedor`
--

DROP TABLE IF EXISTS `Vendedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Vendedor` (
  `Usuario_codigoUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `meta` int(11) NOT NULL,
  `eficiencia` double NOT NULL,
  `informacion` varchar(200) DEFAULT NULL,
  `seguro` varchar(45) NOT NULL,
  `domicilio` varchar(45) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `horasMensuales` int(11) NOT NULL,
  `horasCumplidasMensuales` varchar(45) NOT NULL,
  `Local_idLocal` int(11) NOT NULL,
  PRIMARY KEY (`Usuario_codigoUsuario`),
  KEY `fk_Vendedor_Local1_idx` (`Local_idLocal`),
  CONSTRAINT `fk_Vendedor_Local1` FOREIGN KEY (`Local_idLocal`) REFERENCES `Local` (`idLocal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Vendedor_Usuario1` FOREIGN KEY (`Usuario_codigoUsuario`) REFERENCES `Usuario` (`codigoUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Vendedor`
--

LOCK TABLES `Vendedor` WRITE;
/*!40000 ALTER TABLE `Vendedor` DISABLE KEYS */;
INSERT INTO `Vendedor` VALUES (3,80,5,'Botenlo','214124','yoyos12345','12412151',100,'0',5),(4,70,5,'Botenlo','214124','no where else','12412151',60,'0',5),(5,70,5,'Botenlo','214124','no where else','12412151',60,'0',5),(8,0,0,'123','123','asd','123',0,'0',5),(16,44,1.2,'Nuevo Usuario\nDemasiado distraido','123141','LOS PERICOS','123123123',52,'0',5);
/*!40000 ALTER TABLE `Vendedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Venta`
--

DROP TABLE IF EXISTS `Venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Venta` (
  `idVenta` int(11) NOT NULL AUTO_INCREMENT,
  `fechaCompra` date NOT NULL,
  `tipoDoc` varchar(12) NOT NULL,
  `subToltal` double NOT NULL,
  `total` double NOT NULL,
  `fechaEntrega` date NOT NULL,
  `direccionDeDespacho` varchar(50) NOT NULL,
  `Cliente_codigoCliente` int(11) NOT NULL,
  `Vendedor_Usuario_codigoUsuario1` int(11) NOT NULL,
  PRIMARY KEY (`idVenta`),
  KEY `fk_Venta_Cliente1_idx` (`Cliente_codigoCliente`),
  KEY `fk_Venta_Vendedor1_idx` (`Vendedor_Usuario_codigoUsuario1`),
  CONSTRAINT `fk_Venta_Cliente1` FOREIGN KEY (`Cliente_codigoCliente`) REFERENCES `Cliente` (`codigoCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Venta_Vendedor1` FOREIGN KEY (`Vendedor_Usuario_codigoUsuario1`) REFERENCES `Vendedor` (`Usuario_codigoUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Venta`
--

LOCK TABLES `Venta` WRITE;
/*!40000 ALTER TABLE `Venta` DISABLE KEYS */;
INSERT INTO `Venta` VALUES (1,'2018-05-30','Factura',10725,12655.5,'2018-05-30','AV. Cerca De Ti',17,3),(2,'2018-05-31','Cotizacion',210,247.79999999999998,'2018-05-31','av dsa 32',2,3),(3,'2018-05-31','Boleta',20280,23930.399999999998,'2018-05-31','JR. Quien Sabe 123',12,3),(4,'2018-05-31','Boleta',280,330.4,'2018-05-31','YA PE',21,3),(5,'2018-05-31','Boleta',560,660.8,'2018-05-31','JR. Quien Sabe 123',12,3),(6,'2018-05-31','Boleta',560,660.8,'2018-05-31','AV. Cerca De Ti',17,3),(7,'2018-05-31','Cotizacion',560,660.8,'2018-05-31','AV. Cerca De Ti',17,3),(8,'2018-05-31','Boleta',560,660.8,'2018-05-31','AV. Cerca De Ti',17,3),(9,'2018-05-31','Cotizacion',281,331.58,'2018-05-31','AV LA MARINA',13,3),(10,'2018-05-31','Boleta',281,331.58,'2018-05-31','YA PE',21,3),(11,'2018-05-31','Cotizacion',280,330.4,'2018-05-31','AV. Cerca De Ti',17,3),(12,'2018-05-31','Boleta',280,330.4,'2018-05-31','YA PE',21,3),(13,'2018-05-31','Boleta',280,330.4,'2018-05-31','YA PE',21,3),(14,'2018-05-31','Factura',140,165.2,'2018-05-31','YA PE',21,3),(15,'2018-05-31','Cotizacion',1280,1510.3999999999999,'2018-05-31','ROSARIO1234',23,3),(16,'2018-05-31','Factura',280,330.4,'2018-05-31','YA PE',21,3);
/*!40000 ALTER TABLE `Venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'inf282g4'
--

--
-- Dumping routines for database 'inf282g4'
--
/*!50003 DROP PROCEDURE IF EXISTS `AGREGAR_CLIENTE_JURIDICO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `AGREGAR_CLIENTE_JURIDICO`(
	OUT _CODIGO_CLIENTE INT(11),
    IN _RUC VARCHAR(60),
    IN _RAZON VARCHAR(60),
    IN _REPRESENTANTE VARCHAR(60),
    IN _TELEFONO VARCHAR(15),
    IN _CORREO VARCHAR(45),
    IN _DIRECCION VARCHAR(60)
)
BEGIN
	INSERT INTO Cliente(telefono,correo,direccion,fechaDeRegistro,activo)
	VALUES (_TELEFONO,_CORREO,_DIRECCION,"0000-00-00",1);
	SET _CODIGO_CLIENTE = @@last_insert_id;
	INSERT INTO Juridico(Cliente_codigoCliente,
    ruc,razon,representante) 
			VALUES (_CODIGO_CLIENTE,_RUC,_RAZON,_REPRESENTANTE);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AGREGAR_CLIENTE_NATURAL` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `AGREGAR_CLIENTE_NATURAL`(
	OUT _CODIGO_CLIENTE INT(11),
    IN _NOMBRES VARCHAR(60),
    IN _APELLIDO_PATERNO VARCHAR(60),
    IN _APELLIDO_MATERNO VARCHAR(60),
    IN _DNI VARCHAR(10),
    IN _TELEFONO VARCHAR(15),
    IN _CORREO VARCHAR(45),
    IN _DIRECCION VARCHAR(60)
)
BEGIN
	INSERT INTO Cliente(telefono,correo,direccion,fechaDeRegistro,activo)
	VALUES (_TELEFONO,_CORREO,_DIRECCION,"0000-00-00",1);
	SET _CODIGO_CLIENTE = @@last_insert_id;
	INSERT INTO `Natural` (Cliente_codigoCliente,
    nombre,apellidoPaterno,apellidoMaterno,dni) 
			VALUES (_CODIGO_CLIENTE,_NOMBRES,_APELLIDO_PATERNO,_APELLIDO_MATERNO,_DNI);
End ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BUSCAR_CLIENTES_JURIDICOS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `BUSCAR_CLIENTES_JURIDICOS`(
	IN _NOMBRE VARCHAR(45),
    IN _ID_VENDEDOR INT(11)
)
BEGIN
	IF _NOMBRE IS NULL THEN
    SET _NOMBRE := '';
    END IF;
    
	SELECT * FROM Juridico, Cliente
    WHERE  Cliente.activo=1 AND (Cliente.codigoCliente=Juridico.Cliente_codigoCliente) AND razon LIKE CONCAT(_NOMBRE,'%') 
    AND _ID_VENDEDOR=Cliente.idVendedor;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BUSCAR_CLIENTES_NATURALES` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `BUSCAR_CLIENTES_NATURALES`(
	IN _NOMBRE VARCHAR(45),
    IN _ID_VENDEDOR INT(11)
)
BEGIN
	IF _NOMBRE IS NULL THEN
    SET _NOMBRE := '';
    END IF;
    
	SELECT * FROM `Natural`, Cliente
    WHERE  Cliente.activo=1 AND (Cliente.codigoCliente=`Natural`.Cliente_codigoCliente) AND 
    (nombre LIKE CONCAT(_NOMBRE,'%') OR apellidoPaterno LIKE CONCAT(_NOMBRE,'%') OR apellidoMaterno LIKE CONCAT(_NOMBRE,'%')) 
    AND _ID_VENDEDOR=Cliente.idVendedor;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BUSCAR_COLOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `BUSCAR_COLOR`(
	IN _ID INT(11)
)
BEGIN
	SELECT * FROM Color WHERE idColor LIKE _ID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BUSCAR_PRODUCTOS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `BUSCAR_PRODUCTOS`(
	IN _NOMBRE VARCHAR(200)
)
BEGIN
    IF _NOMBRE IS NULL THEN
		SET _NOMBRE := '';
    END IF;
	SELECT * FROM Producto WHERE nombre LIKE CONCAT(_NOMBRE,'%');
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BUSCAR_PROVEEDOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `BUSCAR_PROVEEDOR`(
	IN _ID INT(11)
)
BEGIN
	SELECT * FROM Proveedor WHERE idProveedor LIKE _ID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BUSCAR_UNIDAD` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `BUSCAR_UNIDAD`(
	IN _ID INT(11)
)
BEGIN
	SELECT * FROM UnidadMedida WHERE idUnidadMedida LIKE _ID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `COMPROBAR_USUARIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `COMPROBAR_USUARIO`(
	IN  _USERNAME VARCHAR(45),
	IN  _PASSWORD VARCHAR(45),
	OUT _ES_CORRECTO BOOLEAN,
    OUT _PRIORIDAD TINYINT(4),
    OUT _NOMBRE VARCHAR(60),
	OUT _APELLIDO_PATERNO VARCHAR (60),
	OUT _APELLIDO_MATERNO VARCHAR (60),
    OUT _DNI VARCHAR(10),
    OUT _FECHA DATE ,
    OUT _EMAIL VARCHAR (45),
    OUT _SEXO VARCHAR(15),
    OUT _CODIGO INT
)
BEGIN
	DECLARE COMPROBADO BOOLEAN;
	DECLARE Prior TINYINT(4);
    DECLARE r int;
    DECLARE nomb VARCHAR (60);
    DECLARE eliminado TINYINT (1);
    DECLARE apellidoPaterno VARCHAR (60);
    DECLARE apellidoMaterno VARCHAR (60);
    DECLARE dni VARCHAR(10);
    DECLARE fecha DATE;
    DECLARE email VARCHAR (45);
    DECLARE sexo VARCHAR(15);
    DECLARE codigo INT;
    
	SELECT count(*) INTO r
    FROM Usuario U
    WHERE (BINARY  U.username = _USERNAME ) AND (BINARY U.pass = _PASSWORD );
    
    
    SELECT activo INTO eliminado 
    FROM Usuario U
    WHERE (BINARY  U.username = _USERNAME ) AND (BINARY U.pass = _PASSWORD );
    
    if r = 0 OR eliminado = 0 then 
		set _ES_CORRECTO := FALSE ;
        SET _PRIORIDAD := 0;
    ELSE  
		set _ES_CORRECTO := TRUE ;			
		SELECT U.prioridad INTO Prior
		FROM inf282g4.Usuario U
		WHERE (U.username = _USERNAME) AND (U.pass = _PASSWORD);
		
        SELECT U.nombre INTO nomb
		FROM inf282g4.Usuario U
		WHERE (U.username = _USERNAME) AND (U.pass = _PASSWORD);
        
        SELECT U.apellidoPaterno INTO apellidoPaterno
		FROM inf282g4.Usuario U
		WHERE (U.username = _USERNAME) AND (U.pass = _PASSWORD);
        
        SELECT U.apellidoMaterno INTO apellidoMaterno
		FROM inf282g4.Usuario U
		WHERE (U.username = _USERNAME) AND (U.pass = _PASSWORD);
        
        SELECT U.dni INTO dni
		FROM inf282g4.Usuario U
		WHERE (U.username = _USERNAME) AND (U.pass = _PASSWORD);
        
        SELECT U.fechaRegistro INTO fecha
		FROM inf282g4.Usuario U
		WHERE (U.username = _USERNAME) AND (U.pass = _PASSWORD);
        
        SELECT U.correo INTO email
		FROM inf282g4.Usuario U
		WHERE (U.username = _USERNAME) AND (U.pass = _PASSWORD);
        
        SELECT U.sexo INTO sexo
		FROM inf282g4.Usuario U
		WHERE (U.username = _USERNAME) AND (U.pass = _PASSWORD);
        
        SELECT U.codigoUsuario INTO codigo
		FROM inf282g4.Usuario U
		WHERE (U.username = _USERNAME) AND (U.pass = _PASSWORD);
        
        SET _PRIORIDAD := Prior;
        SET _NOMBRE := nomb;
		SET _APELLIDO_PATERNO := apellidoPaterno;
		SET _APELLIDO_MATERNO := apellidoMaterno;
		SET _DNI := dni;
		SET _FECHA := fecha;
		SET _EMAIL := email;
		SET _SEXO := sexo;
		SET _CODIGO := codigo;   
    
    END IF;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DECRECER_STOCK_1_COMPONENTE_KIT` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `DECRECER_STOCK_1_COMPONENTE_KIT`(
	IN _ID_PRODUCTO INT,
    IN _STOCK_A_RESTAR DOUBLE
)
BEGIN
	UPDATE Producto
    SET Stock = Stock - _STOCK_A_RESTAR WHERE _ID_PRODUCTO = codigo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DECRECER_STOCK_PRODUCTO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `DECRECER_STOCK_PRODUCTO`(
	IN _ID_PRODUCTO INT,
    IN _STOCK_A_RESTAR DOUBLE
)
BEGIN
	UPDATE Producto
    SET Stock = Stock - _STOCK_A_RESTAR WHERE _ID_PRODUCTO = codigo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ELIMINAR_PRODUCTO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `ELIMINAR_PRODUCTO`(IN _CODIGO INT)
BEGIN	
	DECLARE cod INT(11);
    DECLARE finished INTEGER DEFAULT 0;
	DECLARE cur1 CURSOR FOR SELECT Kit_Producto_codigo FROM ComponenteKit WHERE Producto_codigo = _CODIGO;
	DECLARE CONTINUE HANDLER FOR NOT FOUND SET finished = 1;
        
    UPDATE Producto
    SET activo = 0
    WHERE codigo = _CODIGO;
    
    OPEN cur1;
    read_loop: LOOP
		FETCH cur1 INTO cod;
        IF finished = 1 THEN 
			LEAVE read_loop;
		END IF;
        UPDATE Producto
        SET activo = 0
        WHERE codigo = cod;
	END LOOP;
    CLOSE cur1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ELIMINAR_USUARIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `ELIMINAR_USUARIO`(
	IN _ID_USUARIO INT
)
BEGIN
	UPDATE Usuario
    SET activo = 0
    WHERE _ID_USUARIO = CodigoUsuario;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `FILTRAR_CLIENTES` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `FILTRAR_CLIENTES`(
	IN _ID_VENDEDOR INT(11)
)
BEGIN
	SELECT * FROM Cliente WHERE _ID_VENDEDOR = idVendedor;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `FILTRAR_GERENTES` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `FILTRAR_GERENTES`(
	IN _NOMBRE VARCHAR(45),
    IN _AP_PATERNO VARCHAR(45),
    IN _PRIORIDAD TINYINT(4),
    IN _DNI VARCHAR(10)
)
BEGIN
    IF _NOMBRE IS NULL THEN
    SET _NOMBRE := '';
    END IF;
	IF _AP_PATERNO IS NULL THEN
    SET _AP_PATERNO := '';
    END IF;
	IF _DNI IS NULL THEN
    SET _DNI := '';
    END IF;
	IF _PRIORIDAD=0 THEN
		SELECT * FROM Usuario
		WHERE nombre LIKE CONCAT(_NOMBRE,'%') AND apellidoPaterno LIKE CONCAT( _AP_PATERNO ,'%')
		AND dni LIKE CONCAT( _DNI , '%') AND activo =1 AND (PRIORIDAD =1 OR PRIORIDAD =2);
	ELSE
		SELECT * FROM Usuario
		WHERE nombre LIKE CONCAT(_NOMBRE,'%') AND apellidoPaterno LIKE CONCAT( _AP_PATERNO ,'%')
		AND dni LIKE CONCAT( _DNI , '%') AND prioridad = _PRIORIDAD AND activo =1;
	END IF;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `FILTRAR_PRODUCTOS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `FILTRAR_PRODUCTOS`(
	IN _NOMBRE VARCHAR(200),
    IN _PRECIOMIN DOUBLE,
    IN _PRECIOMAX DOUBLE
)
BEGIN
    IF _NOMBRE IS NULL THEN
		SET _NOMBRE := '';
    END IF;
	IF _PRECIOMAX = -1 THEN
		SELECT * FROM Producto
		WHERE precio>_PRECIOMIN AND activo = 1 AND nombre LIKE CONCAT(_NOMBRE,'%');
    ELSE
		SELECT * FROM Producto
		WHERE precio>_PRECIOMIN AND activo = 1 AND precio<_PRECIOMAX AND nombre LIKE CONCAT(_NOMBRE,'%');
	END IF;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `HISTORIAL_DE_COMPRAS_CLIENTE` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `HISTORIAL_DE_COMPRAS_CLIENTE`(
	IN _CODIGO_CLIENTE INT(11)
)
BEGIN
	SELECT *
    FROM Venta
    WHERE _CODIGO_CLIENTE=Cliente_codigoCliente AND (tipoDoc="Boleta" OR tipoDoc = "Factura");
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_CLIENTES` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_CLIENTES`()
BEGIN
	SELECT * FROM Cliente
    WHERE  Cliente.activo=1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_CLIENTESXVENDEDOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_CLIENTESXVENDEDOR`(
	IN _ID_VENDEDOR int(11)
)
BEGIN
	select * from (select * from Venta as V,Cliente as C where V.Cliente_codigoCliente = codigoCliente) as Aux where  Aux.Vendedor_Usuario_codigoUsuario1 = _ID_VENDEDOR;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_CLIENTES_JURIDICOS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_CLIENTES_JURIDICOS`()
BEGIN
	SELECT * FROM Juridico, Cliente
    WHERE  Cliente.activo=1 AND (Cliente.codigoCliente=Juridico.Cliente_codigoCliente);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_CLIENTES_NATURAL` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_CLIENTES_NATURAL`()
BEGIN
	SELECT * FROM `Natural`, Cliente
    WHERE  Cliente.activo=1 AND (Cliente.codigoCliente=`Natural`.Cliente_codigoCliente);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_COLOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_COLOR`()
BEGIN
	SELECT * FROM Color;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_GERENTES` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_GERENTES`()
BEGIN
	SELECT * FROM Usuario WHERE activo =1 and (prioridad =1 or prioridad =2);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_KIT` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_KIT`()
BEGIN
	SELECT * FROM Kit;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_MEDIDAS` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_MEDIDAS`()
BEGIN
	SELECT * FROM UnidadMedida;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_PAISES` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_PAISES`()
BEGIN
	SELECT * FROM Pais;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_PRODUCTO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_PRODUCTO`()
BEGIN
	SELECT * FROM Producto WHERE activo=1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_PRODUCTOS_KIT` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_PRODUCTOS_KIT`(IN _CODIGO INT)
BEGIN
	SELECT Producto.*,ComponenteKit.cantidad FROM Producto,ComponenteKit WHERE codigo = ComponenteKit.Producto_codigo and ComponenteKit.Kit_Producto_codigo=_CODIGO;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_PROVEEDOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_PROVEEDOR`()
BEGIN
	SELECT * FROM Proveedor;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTAR_VENDEDORES` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTAR_VENDEDORES`()
BEGIN
	SELECT * FROM Vendedor,Usuario WHERE  Usuario.activo=1 and (Usuario.prioridad=3)
    and (Vendedor.Usuario_codigoUsuario=Usuario.codigoUsuario);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LISTA_LOCAL` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `LISTA_LOCAL`()
BEGIN
	select * from Local;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `MODIFICAR_CLIENTE_JURIDICO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `MODIFICAR_CLIENTE_JURIDICO`(
	IN _CODIGO_CLIENTE INT(11),
    IN _RUC VARCHAR(12),
    IN _RAZON VARCHAR(45),
    IN _REPRESENTANTE VARCHAR(45),
    IN _TELEFONO VARCHAR(15),
    IN _CORREO VARCHAR(45),
    IN _DIRECCION VARCHAR(60)
)
BEGIN
	UPDATE Juridico
	SET ruc=_RUC, razon=_RAZON, representante=_REPRESENTANTE
    WHERE Cliente_codigoCliente=_CODIGO_CLIENTE;

	UPDATE Cliente
	SET telefono=_TELEFONO, correo=_CORREO, direccion=_DIRECCION
    WHERE codigoCliente = _CODIGO_CLIENTE;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `MODIFICAR_CLIENTE_NATURAL` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `MODIFICAR_CLIENTE_NATURAL`(
	IN _CODIGO_CLIENTE INT(11),
    IN _NOMBRES VARCHAR(60),
    IN _APELLIDO_PATERNO VARCHAR(60),
    IN _APELLIDO_MATERNO VARCHAR(60),
    IN _DNI VARCHAR(10),
    IN _TELEFONO VARCHAR(15),
    IN _CORREO VARCHAR(45),
    IN _DIRECCION VARCHAR(60)
)
BEGIN
	UPDATE `Natural`, Cliente
    SET telefono=_TELEFONO, correo=_CORREO, direccion=_DIRECCION,
    nombre=_NOMBRES, apellidoPaterno=_APELLIDO_PATERNO, apellidoMaterno=_APELLIDO_MATERNO, dni=_DNI
    WHERE codigoCliente = _CODIGO_CLIENTE AND (Cliente_codigoCliente=_CODIGO_CLIENTE);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `MODIFICAR_COMPONENTE_KIT` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `MODIFICAR_COMPONENTE_KIT`(
	IN _CODIGO_KIT INT(11),
    IN _CODIGO_PROD INT(11),
    IN _CANTIDAD DOUBLE
)
BEGIN
	DELETE FROM ComponenteKit WHERE Kit_Producto_codigo = _CODIGO_KIT AND Producto_codigo = _CODIGO_PROD;
    INSERT INTO ComponenteKit(cantidad,Kit_Producto_codigo,Producto_codigo) VALUES (_CANTIDAD,_CODIGO_KIT,_CODIGO_PROD);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `MODIFICAR_GERENTE` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `MODIFICAR_GERENTE`(
	IN _ID_USUARIO INT,
	IN _DNI VARCHAR(10),
    IN _NOMBRE VARCHAR(60),
    IN _APELLIDO_PATERNO VARCHAR(60),
    IN _APELLIDO_MATERNO VARCHAR(60),
    IN _SEXO VARCHAR(15),
    IN _CORREO VARCHAR(45),
    IN _USERNAME VARCHAR(45),
	IN _PASSWORD VARCHAR(45),
    IN _PRIORIDAD TINYINT(4)
)
BEGIN
	UPDATE Usuario
    SET dni=_DNI, nombre=_NOMBRE, apellidoPaterno= _APELLIDO_PATERNO,
    apellidoMaterno = _APELLIDO_MATERNO, sexo=_SEXO, correo=_CORREO, username=_USERNAME,
    pass= _PASSWORD, prioridad = _PRIORIDAD
    WHERE _ID_USUARIO = CodigoUsuario;
	
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `MODIFICAR_PRODUCTO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `MODIFICAR_PRODUCTO`(
	IN _CODIGO INT(11),
    IN _NOMBRE VARCHAR(200),
    IN _FAMILIA VARCHAR(80),
    IN _PRECIO DOUBLE,
    IN _PROVEEDOR INT,
    IN _COLOR_IDCOLOR INT,
    IN _DESCUENTO DOUBLE,
    IN _UNIDADMEDIDA INT,
    IN _STOCKE DOUBLE,
    IN _STOCKM DOUBLE)
BEGIN
	IF _COLOR_IDCOLOR = 0 AND _UNIDADMEDIDA = 0 THEN
		UPDATE Producto SET nombre=_NOMBRE, familia = _FAMILIA, precio = _PRECIO, Proveedor_idProveedor = _PROVEEDOR,
		descuento = _DESCUENTO, Stock = _STOCKE, StockMinimo = _STOCKM
		WHERE _CODIGO = codigo;
    ELSE
	UPDATE Producto SET nombre=_NOMBRE, familia = _FAMILIA, precio = _PRECIO, Proveedor_idProveedor = _PROVEEDOR,
		Color_idColor = _COLOR_IDCOLOR, descuento = _DESCUENTO, UnidadMedida_idUnidadMedida = _UNIDADMEDIDA, Stock = _STOCKE, StockMinimo = _STOCKM
		WHERE _CODIGO = codigo;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_COLOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_COLOR`(
	_NOMBRE VARCHAR(15)
)
BEGIN
	DECLARE _ID INT;
	SET _ID = last_insert_id();
	INSERT INTO Color (idColor, nombreColor)
    VALUES (_ID, _NOMBRE);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_COMPONENTE_KIT` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_COMPONENTE_KIT`(
	_CANTIDAD INT(11),
    _KIT_PRODUCTO_CODIGO INT(11),
	_PRODUCTO_CODIGO INT(11)
)
BEGIN
		INSERT INTO ComponenteKit (cantidad, Kit_Producto_codigo, Producto_codigo) VALUES (_CANTIDAD, _KIT_PRODUCTO_CODIGO, _PRODUCTO_CODIGO);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_DETALLEPROD` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_DETALLEPROD`(
	IN _CANTIDAD DOUBLE,
    IN _CODIGO INT(11),
    IN _LOCAL INT(11)
)
BEGIN
	INSERT INTO DetalleProd VALUES (_CODIGO,_CANTIDAD,_LOCAL);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_DETALLEVENTA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_DETALLEVENTA`(
	IN _ID_VENTA INT(11),
	IN _ID_PRODUCTO INT(11),
    IN _CANTIDAD DOUBLE,
    IN _ID_VENDEDOR INT(11)
)
BEGIN
	INSERT INTO DetalleVenta(Venta_idVenta, Producto_codigo, cantidad, Venta_Vendedor_Usuario_codigoUsuario)
	VALUES (_ID_VENTA, _ID_PRODUCTO, _CANTIDAD, _ID_VENDEDOR);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_DETALLE_VENTA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_DETALLE_VENTA`(
	_ID_VENTA INT(11),
    _CODIGO_PRODUCTO INT(11),
    _CANTIDAD DOUBLE,
    _VENTA_VENDEDOR_USUARIO_CODIGOUSUARIO INT(11)
)
BEGIN
	INSERT INTO DetalleVenta (Venta_idVenta, Producto_codigo, cantidad, Venta_Vendedor_Usuario_codigoUsuario) 
    VALUES (_ID_VENTA, _CODIGO_PRODUCTO, _CANTIDAD, _VENTA_VENDEDOR_USUARIO_CODIGOUSUARIO);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_EXHIBICION` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_EXHIBICION`(
	OUT _ID_LOCAL INT(11),
	IN _DIA_INI VARCHAR(10),
    IN _DIA_FIN VARCHAR(10),
    IN _HORA_INI TIME,
    IN _HORA_FIN TIME,
    IN _DIRECCION VARCHAR(50),
	IN _TELEFONO VARCHAR(15),
    IN _COD_CLIENTE INT(11)
)
BEGIN
	INSERT INTO inf282g4.Local (direccion,telefono)
	VALUES (_DIRECCION,_TELEFONO);
	SET _ID_LOCAL = @@last_insert_id;
    
	INSERT INTO Exhibicion 
    VALUES (_ID_LOCAL,_DIA_INI,_DIA_FIN,_HORA_INI,_HORA_FIN,1,_COD_CLIENTE);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_GERENTE` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_GERENTE`(
	OUT _ID_USUARIO INT,
	IN _DNI VARCHAR(10),
    IN _NOMBRES VARCHAR(60),
    IN _APELLIDO_PATERNO VARCHAR(60),
    IN _APELLIDO_MATERNO VARCHAR(60),
    IN _SEXO VARCHAR(15),
    IN _CORREO VARCHAR(45),
    IN _USERNAME VARCHAR(45),
	IN _PASSWORD VARCHAR(45),
    IN _PRIORIDAD TINYINT(4)
)
BEGIN
	INSERT INTO Usuario(dni,nombre,apellidoPaterno,apellidoMaterno,sexo,correo,username,pass,prioridad,activo,fechaRegistro)
	VALUES (_DNI,_NOMBRES,_APELLIDO_PATERNO,_APELLIDO_MATERNO,_SEXO,_CORREO,_USERNAME,_PASSWORD,_PRIORIDAD,1,CURDATE());
	SET _ID_USUARIO = @@last_insert_id;
	INSERT INTO Gerente(Usuario_CodigoUsuario) VALUES (_ID_USUARIO);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_KIT` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_KIT`(
	_CODIGO INT(11),
    _NOMBRE VARCHAR(200),
    _FAMILIA VARCHAR(80),
    _PRECIO DOUBLE,
    _PROVEEDOR INT,
    _ACTIVO TINYINT,
    _COLOR_IDCOLOR INT,
    _DESCUENTO DOUBLE,
    _UNIDADMEDIDA INT
)
BEGIN
	INSERT INTO PRODUCTO (codigo, nombre, familia, precio, Proveedor_idProveedor, activo, Color_idColor, descuento, UnidadMedida_idUnidadMedida)
    VALUES (_CODIGO, _NOMBRE, _FAMILIA, _PRECIO, _PROVEEDOR, _ACTIVO, _COLOR_IDCOLOR, _DESCUENTO, _UNIDADMEDIDA);
    INSERT INTO KIT (Producto_codigo) VALUES (codigo);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_PRODUCTO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_PRODUCTO`(
	OUT _CODIGO INT(11),
    _NOMBRE VARCHAR(200),
    _FAMILIA VARCHAR(80),
    _PRECIO DOUBLE,
    _PROVEEDOR INT,    
    _COLOR_IDCOLOR INT,
    _DESCUENTO DOUBLE,
    _UNIDADMEDIDA INT,
    _STOCKE INT,
    _STOCKM INT
)
BEGIN
	IF _COLOR_IDCOLOR = 0 AND _UNIDADMEDIDA = 0 THEN
		INSERT INTO Producto(activo, nombre, familia, precio, Proveedor_idProveedor, descuento, Stock, StockMinimo)
		VALUES (1, _NOMBRE, _FAMILIA, _PRECIO, _PROVEEDOR, _DESCUENTO, _STOCKE, _STOCKM);
        SET _CODIGO = @@last_insert_id;
        INSERT INTO Kit(Producto_codigo) VALUES (_CODIGO);
    ELSE
		INSERT INTO Producto(activo, nombre, familia, precio, Proveedor_idProveedor,  Color_idColor, descuento, UnidadMedida_idUnidadMedida, Stock, StockMinimo)
		VALUES (1, _NOMBRE, _FAMILIA, _PRECIO, _PROVEEDOR,  _COLOR_IDCOLOR, _DESCUENTO, _UNIDADMEDIDA, _STOCKE, _STOCKM);
        SET _CODIGO = @@last_insert_id;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_PRODUCTO_NUEVO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_PRODUCTO_NUEVO`(
	in _CODIGO INT(11),
    in _NOMBRE VARCHAR(200),
    in _FAMILIA VARCHAR(80),
    in _PRECIO DOUBLE,
    in _PROVEEDOR INT,
    in _COLOR_IDCOLOR INT,    
    in _STOCK DOUBLE,
    in _STOCK_MINIMO DOUBLE
)
BEGIN
	INSERT INTO Producto (codigo, nombre, familia, precio, Proveedor_idProveedor, Color_idColor, Stock, StockMinimo)
    VALUES (_CODIGO, _NOMBRE, _FAMILIA, _PRECIO, _PROVEEDOR, _COLOR_IDCOLOR,   _STOCK, _STOCK_MINIMO);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_PROVEEDOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_PROVEEDOR`(
	_NOMBRE VARCHAR(15)
)
BEGIN
	DECLARE _ID INT;
	SET _ID = last_insert_id();
	INSERT INTO Color (idColor, nombreColor)
    VALUES (_ID, _NOMBRE);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_VENDEDOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_VENDEDOR`(
	OUT _ID_USUARIO INT(11),
	IN _DNI VARCHAR(10),
    IN _NOMBRES VARCHAR(60),
    IN _APELLIDO_PATERNO VARCHAR(60),
    IN _APELLIDO_MATERNO VARCHAR(60),
    IN _SEXO VARCHAR(15),
    IN _CORREO VARCHAR(45),
    IN _USERNAME VARCHAR(45),
	IN _PASSWORD VARCHAR(45),
    IN _PRIORIDAD TINYINT(4),
    IN _META INT(11),
    IN _EFICIENCIA DOUBLE,
    IN _INFORMACION VARCHAR(45),
    IN _SEGURO VARCHAR(45),
    IN _DOMICILIO VARCHAR(45),
    IN _TELEFONO VARCHAR(15),
    IN _LOCAL_ID INT(11)
)
BEGIN
	INSERT INTO Usuario(dni,nombre,apellidoPaterno,apellidoMaterno,sexo,correo,username,pass,prioridad,activo,fechaRegistro)
	VALUES (_DNI,_NOMBRES,_APELLIDO_PATERNO,_APELLIDO_MATERNO,_SEXO,_CORREO,_USERNAME,_PASSWORD,3,1,CURDATE());
	SET _ID_USUARIO = @@last_insert_id;
	INSERT INTO Vendedor(Usuario_CodigoUsuario,
    meta,eficiencia,informacion,seguro,domicilio,telefono,horasMensuales,horasCumplidasMensuales,Local_idLocal) 
			VALUES (_ID_USUARIO,0,0.0,_INFORMACION,_SEGURO,_DOMICILIO,_TELEFONO,0,0,_LOCAL_ID);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `REGISTRAR_VENTA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`inf282g4`@`%` PROCEDURE `REGISTRAR_VENTA`(
	OUT _ID_VENTA INT(11),
	IN _TIPODOC VARCHAR(12),
    IN _SUBTOTAL DOUBLE,
    IN _TOTAL DOUBLE,
    IN _DIRECCION VARCHAR(50),
    IN _ID_CLIENTE VARCHAR(45),
    IN _ID_VENDEDOR VARCHAR(45)
)
BEGIN
	INSERT INTO Venta(fechaCompra,tipoDoc,subToltal,total,fechaEntrega,direccionDeDespacho,Cliente_codigoCliente,Vendedor_Usuario_codigoUsuario1)
	VALUES (CURDATE(),  _TIPODOC, _SUBTOTAL, _TOTAL,CURDATE(), _DIRECCION, _ID_CLIENTE, _ID_VENDEDOR);
	SET _ID_VENTA = @@last_insert_id;
END ;;
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

-- Dump completed on 2018-06-10 19:30:58
