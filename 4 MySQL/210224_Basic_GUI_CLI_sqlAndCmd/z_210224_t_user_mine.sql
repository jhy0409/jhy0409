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


-- z_210224_t_user_mine 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `z_210224_t_user_mine` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `z_210224_t_user_mine`;

-- 테이블 z_210224_t_user_mine.user 구조 내보내기
CREATE TABLE IF NOT EXISTS `user` (
  `i_user` int NOT NULL AUTO_INCREMENT COMMENT '넘버링',
  `user_nm` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '-' COMMENT '이름',
  `user_age` int NOT NULL DEFAULT '0' COMMENT '나이',
  `email` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '@.com' COMMENT '메일',
  `user_phone` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '010' COMMENT '전화',
  PRIMARY KEY (`i_user`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 z_210224_t_user_mine.user:~8 rows (대략적) 내보내기
DELETE FROM `user`;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` (`i_user`, `user_nm`, `user_age`, `email`, `user_phone`) VALUES
	(1, '김태연', 31, 'taeyeon_@naver.com', '01024569876'),
	(2, '이순규', 29, 'sunkyulee@daum.net', '01023451234'),
	(3, '황미영', 30, 'tiffany@naver.com', '01056563434'),
	(4, '김효연', 29, 'dj_hyo1234@naver.com', '01089892425'),
	(5, '권유리', 28, 'glass_798@daum.net', '01078905987'),
	(6, '최수영', 25, 'swimming57@naver.com', '01012340987'),
	(7, '임윤아', 27, 'yuun_aaa9@daum.net', '01079804739'),
	(8, '서주현', 24, 'seojuhyeon1@daum.net', '01029496088');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
