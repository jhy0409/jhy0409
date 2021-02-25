-- 모든 컬럼의 정보 검색
SELECT * FROM t_user;

-- 테이블의 모든데이터 삭제
-- DELETE FROM t_user;

-- 테이블 자체를 삭제
-- DROP table sakilat_user;

-- 특정 정보값 삭제
-- DELETE FROM t_user WHERE i_user = 17;
-- DELETE FROM t_user WHERE user_nm = '이순규';

-- 수정
-- UPDATE t_user SET user_nm = '홍길동' WHERE user_nm = '김순규';

-- C생성 R읽기 U수정 D삭제
-- 검색, del삭제, insert추가, update수정

-- 검색, 특정 컬럼값 지정
-- SELECT user_nm, user_age, r_dt FROM t_user;

-- 모든 컬럼의 정보 검색
-- SELECT * FROM t_user;