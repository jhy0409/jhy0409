-- 사용자함수, 프로시저, 트리거...
-- View 가상테이블 : 생성/삭제만 dba가 개발자한테 주는거 물리적존재x, 보안때문에 사용..
-- 지울 때 drop view
CREATE or REPLACE VIEW v_emp (사원, 사원이름, 부서번호, 담당업무)
    as SELECT eno, ename, dno, job
    from employee where job like 'SALESMAN';
    
-- PL/SQL
set SERVEROUTPUT on;
DECLARE
    v_eno number(4); -- 변수선언
    v_ename employee.ename%type; -- 타입 그대로 가져옴
    
begin
    v_eno := 7788; -- 변수 초기화
    v_ename := 'scott';
    dbms_output.put_line('사원번호             사원이름');
    dbms_output.put_line('-----------------------------');
    dbms_output.put_line(v_eno ||'               '||v_ename);
end;    