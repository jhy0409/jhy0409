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


-- z_210225_1_yonsup_mine 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `z_210225_1_yonsup_mine` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `z_210225_1_yonsup_mine`;

-- 테이블 z_210225_1_yonsup_mine.namecard 구조 내보내기
CREATE TABLE IF NOT EXISTS `namecard` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(20) DEFAULT NULL,
  `tel` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 z_210225_1_yonsup_mine.namecard:~1 rows (대략적) 내보내기
DELETE FROM `namecard`;
/*!40000 ALTER TABLE `namecard` DISABLE KEYS */;
INSERT INTO `namecard` (`id`, `name`, `tel`) VALUES
	(1, '홍길동', '011-111-1234'),
	(2, '가나다', '010-9999-9999'),
	(3, '라마바', '010-2222-2222'),
	(4, '이길동', '222');
/*!40000 ALTER TABLE `namecard` ENABLE KEYS */;

-- 테이블 z_210225_1_yonsup_mine.t_user 구조 내보내기
CREATE TABLE IF NOT EXISTS `t_user` (
  `i_user` int NOT NULL AUTO_INCREMENT,
  `user_nm` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '',
  `user_age` int DEFAULT NULL,
  `email` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '0',
  `user_phone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '0',
  `user_addr` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '0',
  `r_dt` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`i_user`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 z_210225_1_yonsup_mine.t_user:~8 rows (대략적) 내보내기
DELETE FROM `t_user`;
/*!40000 ALTER TABLE `t_user` DISABLE KEYS */;
INSERT INTO `t_user` (`i_user`, `user_nm`, `user_age`, `email`, `user_phone`, `user_addr`, `r_dt`) VALUES
	(2, '이순규', 29, 'lee@naver.com', '010-1111-2222', '서울 동구 신암동', '2021-02-25 10:39:43'),
	(3, '이순규', 29, 'lee@naver.com', '010-1111-2222', '서울 동구 신암동', '2021-02-25 10:44:12'),
	(6, '이순규', 29, 'lee@naver.com', '010-1111-2222', '서울 동구 신암동', '2021-02-25 10:44:25'),
	(7, '이순규', 29, 'lee@naver.com', '010-1111-2222', '서울 동구 신암동', '2021-02-25 10:45:02'),
	(8, '이순규', 0, '0', '0', '0', '2021-02-25 10:48:35'),
	(9, '이순규', NULL, '0', '0', '0', '2021-02-25 10:50:41'),
	(10, '이순규', 22, '0', '0', '0', '2021-02-25 10:53:03'),
	(11, '이순규', 22, '0', '0', '0', '2021-02-25 10:54:02'),
	(12, '복습', 99, '0', '0', '0', '2021-02-25 15:34:24'),
	(13, '복습', 555, '0', '0', '0', '2021-02-25 15:44:49'),
	(14, '홍길동', 100, 'hong@naver.com', '010-1234-1234', '조선 한양 홍대감댁', '2021-02-25 15:48:59'),
	(15, '홍길동', 100, 'hong@naver.com', '010-1234-1234', '조선 한양 홍대감댁', '2021-02-25 15:48:59'),
	(16, '홍길동', 100, 'ssss.com', '010-1234-1234', '조선 한양 홍대감댁', '2021-02-25 15:48:59');
/*!40000 ALTER TABLE `t_user` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
