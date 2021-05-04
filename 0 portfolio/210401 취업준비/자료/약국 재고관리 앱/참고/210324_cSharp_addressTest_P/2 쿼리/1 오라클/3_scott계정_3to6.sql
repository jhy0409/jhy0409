/*
-- 3. 이름의 끝자리가 ‘동'으로 끝나는 모든 이름을 검색하고 id 가 내림차순으로 정렬하시오. 
SELECT * from namecard where name like '%동' order by id desc;

-- 4. 김길동의 이름을 검색하여 전우치로 변경하고 name이 오름차순으로 정렬하시오. 
UPDATE namecard set name='전우치' where name = '김길동';
select * from namecard order by name;

-- 5. 전우치 이름을 검색하여 정보를 삭제하시오. 
DELETE from namecard where name = '전우치';
select * from namecard;

-- 6. namecard를 복사하여 namecard_copy 테이블을 생성하시오.
-- - 단, 김길동 데이터만 namecard_copy에 복사되게 하시오.

CREATE TABLE namecard_copy as SELECT * from namecard where name like '김길동';
*/