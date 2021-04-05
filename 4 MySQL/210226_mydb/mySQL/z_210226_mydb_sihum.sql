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


-- z_210226_mydb_sihum 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `z_210226_mydb_sihum` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `z_210226_mydb_sihum`;

-- 테이블 z_210226_mydb_sihum.namecard 구조 내보내기
CREATE TABLE IF NOT EXISTS `namecard` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(20) NOT NULL,
  `phone` varchar(20) NOT NULL DEFAULT '',
  `address` varchar(100) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 z_210226_mydb_sihum.namecard:~10 rows (대략적) 내보내기
DELETE FROM `namecard`;
/*!40000 ALTER TABLE `namecard` DISABLE KEYS */;
INSERT INTO `namecard` (`id`, `name`, `phone`, `address`) VALUES
	(1, '아자차', '999-9999-9999', '경기도 평리2동'),
	(2, '타하김', '010-1118-2220', '대구 평리9동'),
	(3, '사바타', '010-1120-2216', '대구 평리10동'),
	(4, '하마카', '010-1120-1113', '전라도 평리9동'),
	(5, '하가타', '010-1116-2215', '대전 평리1동'),
	(6, '박가파', '010-2216-1114', '인천 평리2동'),
	(7, '자바아', '010-1120-1112', '인천 평리6동'),
	(8, '자타카', '010-1120-1119', '인천 평리6동'),
	(9, '마나자', '010-2217-1119', '울산 평리10동'),
	(10, '사김바', '010-1118-1111', '서울 평리4동');
/*!40000 ALTER TABLE `namecard` ENABLE KEYS */;

-- 테이블 z_210226_mydb_sihum.userinfo 구조 내보내기
CREATE TABLE IF NOT EXISTS `userinfo` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(20) NOT NULL DEFAULT '',
  `job` varchar(20) DEFAULT NULL,
  `hobby` varchar(20) DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 z_210226_mydb_sihum.userinfo:~10 rows (대략적) 내보내기
DELETE FROM `userinfo`;
/*!40000 ALTER TABLE `userinfo` DISABLE KEYS */;
INSERT INTO `userinfo` (`id`, `name`, `job`, `hobby`) VALUES
	(1, '아자차', NULL, '깊은잠'),
	(2, '타하김', NULL, '낮잠'),
	(3, '사바타', NULL, '얕은잠'),
	(4, '하마카', NULL, '얕은잠'),
	(5, '하가타', NULL, '깊은잠'),
	(6, '박가파', NULL, '얕은잠'),
	(7, '자바아', NULL, '깊은잠'),
	(8, '자타카', NULL, '깊은잠'),
	(9, '마나자', NULL, '낮잠'),
	(10, '사김바', NULL, '깊은잠');
/*!40000 ALTER TABLE `userinfo` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
