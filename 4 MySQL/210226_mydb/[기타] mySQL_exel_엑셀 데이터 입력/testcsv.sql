-- --------------------------------------------------------
-- 호스트:                          127.0.0.1
-- 서버 버전:                        8.0.22 - MySQL Community Server - GPL
-- 서버 OS:                        Win64
-- HeidiSQL 버전:                  11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- testcsv 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `testcsv` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `testcsv`;

-- 테이블 testcsv.data2 구조 내보내기
CREATE TABLE IF NOT EXISTS `data2` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(10) NOT NULL,
  `job` varchar(10) DEFAULT NULL,
  `hobby` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 testcsv.data2:~0 rows (대략적) 내보내기
DELETE FROM `data2`;
/*!40000 ALTER TABLE `data2` DISABLE KEYS */;
INSERT INTO `data2` (`id`, `name`, `job`, `hobby`) VALUES
	(1, '파다라', '', '얕은잠'),
	(2, '자가나', '', '얕은잠'),
	(3, '김파가', '', '깊은잠'),
	(4, '마자라', '', '얕은잠'),
	(5, '김자가', '', '얕은잠'),
	(6, '마타파', '', '깊은잠'),
	(7, '김카파', '', '깊은잠'),
	(8, '라차타', '', '수면'),
	(9, '타차카', '', '잠'),
	(10, '자파카', '', '낮잠');
/*!40000 ALTER TABLE `data2` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
