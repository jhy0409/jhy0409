/*
-- 조건검색
-- 내림차순 정렬
SELECT i_user, user_nm, user_age FROM t_user
	WHERE user_age > 20 AND user_age < 102
	ORDER BY user_age DESC;

-- 조건검색
-- 오름차순 정렬,                   별칭 붙이기
SELECT i_user, user_nm, user_age AS "나이(세)"
	FROM t_user
	WHERE user_age >= 20 AND user_age <= 102
	ORDER BY user_age ASC;

	
SELECT i_user, user_nm, user_age FROM t_user
	WHERE user_age IstudentN (20, 22, 100) -- 해당 값이면
	ORDER BY i_user; -- 아이디로 정렬 asc(어센딩, 오름차순) 생략
	-- 생략시 asc 붙은 것과 동일
	
SELECT i_user, user_nm, user_age FROM t_user
	WHERE user_age IN (20, 22, 100) -- 나이가 해당조건,
	ORDER BY user_age DESC, user_nm ASC; -- 정렬, 나이: 내림차순, 이름: 오름차순,  한글 : 2바이트 유니코드
	`tables`student
	
SELECT user_nm AS "성명", user_age AS "나이"
	FROM t_user WHERE user_age IN (20, 22, 100)
	ORDER BY i_user DESC; -- 기본값 asc
	
-- 20~100사이
SELECT user_nm AS "성명", user_age AS "나이"
	FROM t_user WHERE user_age BETWEEN 20 AND 100 -- 범위값 포함, <=, >= **
	ORDER BY i_user DESC; -- 최신정보로 출력

SELECT user_nm AS "성명", user_age AS "나이"
	FROM t_user WHERE user_age >=20 and user_age <=100 -- 범위값 포함, <=, >= ***, (** == ***)
	ORDER BY i_user DESC;

SELECT user_nm AS "성명", user_age AS "나이"
	FROM t_user WHERE user_nm LIKE '전__' -- 글자, 자릿수 관계x nxdd동, 강%, '홍%', '홍__'(자릿수 지정)
	ORDER BY user_age asc;

	
-- mysql 함수
SELECT SUM(user_age) AS '나이의 총계' FROM t_user;
SELECT MAX(user_age) AS '가장 나이 많은 사람' FROM t_user;
SELECT AVG(user_age) AS '평균나이' FROM t_user;
*/
SELECT COUNT(i_user) AS '데이터 개수' FROM t_user; -- not null값





