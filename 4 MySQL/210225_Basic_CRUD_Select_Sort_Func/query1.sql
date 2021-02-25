INSERT INTO t_user (i_user, user_nm, user_age) 
VALUES (0,'김순규',22);

INSERT INTO t_user (i_user, user_nm, user_age, email, user_phone, user_addr) 
VALUES (0,'이순규',29, 
'lee@naver.com','010-1111-2222',
'서울 동구 신암동');

-- 모든정보 입력 시 컬럼값 생략
INSERT INTO t_user VALUES 
(0,'홍길동',100, 
'hong@naver.com','010-1234-1234',
'조선 한양 홍대감댁',NOW());

-- 테이블의 모든데이터 삭제
-- DELETE FROM t_user;


/*
테이블 전체 삭제
DROP TABLE t_user;
*/


-- 한줄주석

/*

여러줄 주석

*/