/*
--테이블 생성
CREATE TABLE mytable (
    ID NUMBER NOT NULL, 
    NAME VARCHAR2(20) NOT NULL,
    age NUMBER NOT NULL, 
    addr VARCHAR2(80) NOT NULL,
    CONSTRAINT pk_mytable_id PRIMARY KEY(ID));

-- 데이터 입력
INSERT INTO testtable values ('bbb');
*/
/*
--개인적으로 찾아본거 
ALTER TABLE studentaddr drop PRIMARY key;
ALTER TABLE studentaddr MODIFY (ID NULL);
alter table studentaddr modify name null;

*/

/* 
--프린트물
-- 1. 생성된 행 전체 갯수
SELECT COUNT(*) from studentaddr;

-- 2. 테이블 생성
CREATE TABLE studentaddr (
    ID NUMBER NOT NULL, 
    NAME VARCHAR(20) NOT NULL,
    age NUMBER NOT NULL, 
    addr VARCHAR(80) NOT NULL,
    CONSTRAINT pk_studentaddr_id PRIMARY KEY(ID));

-- 데이터 삽입
INSERT INTO studentaddr values (1,'bbb',55,'3월 10일 실습중');

-- 시퀀스 아이디..
CREATE SEQUENCE seq_id INCREMENT by 1 START with 1;

-- 시퀀스 삭제
drop SEQUENCE seq_id;
-- [쿼리 사용 예시]
INSERT INTO studentaddr VALUES (seq_id.nextval, '이름이름', 999, '0310 실습, 주소자리');

-- 3. 테이블 정보보기
desc studentaddr;

-- 4. 테이블 수정
ALTER TABLE studentaddr add (name2 varchar2(40));
ALTER TABLE studentaddr MODIFY (name2 VARCHAR2(50));
ALTER TABLE studentaddr RENAME COLUMN name2 to name4;
ALTER TABLE studentaddr DROP COLUMN name4;

-- 6. 주키 설정
ALTER TABLE studentAddr add CONSTRAINT pk_student_id primary key(id);

--7. 기본쿼리 처리문
INSERT INTO studentaddr values (seq_id.nextval,'최길동',100,'99_3월 10일 실습중');

SELECT * from studentaddr;
SELECT id, name, age from studentaddr where id = 13;
SELECT * FROM studentaddr WHERE id = 15;
SELECT * FROM studentaddr WHERE name is null;
SELECT * FROM studentaddr WHERE name like '%길동';

SELECT * FROM studentaddr order by name;
SELECT * FROM studentaddr order by name desc;
SELECT * FROM studentaddr WHERE name like '%길동' ORDER by id desc;

delete from studentaddr where id = 30;
SELECT * FROM studentaddr WHERE name like '%길동' ORDER by id desc;
delete from studentaddr where id BETWEEN 21 and 31;
SELECT * FROM studentaddr;

UPDATE studentaddr set name = '수정했다.' where id = 2;
UPDATE studentaddr set name = '수정했다.', age= 999, addr = '수정수정수정수정수정' where id BETWEEN 1 and 32 ;

UPDATE studentaddr set name = '????', age= 555, addr = '5555555' where name like '%길동' ;
*/

SELECT * FROM studentaddr;


