/*
--CREATE TABLE dept_copy AS SELECT * FROM department;
INSERT INTO dept_copy VALUES(10, 'ACCOUNTING', 'NEW YORK');
INSERT INTO dept_copy (dno, loc, dname) VALUES (20, 'DALLAS', 'RESEARCH');

--CREATE TABLE emp_copy AS SELECT * FROM employee;
INSERT INTO emp_copy VALUES (7369,'SMITH', 'CLERK', 7902, TO_DATE('17-12-1980','dd-mm-yyyy'),800,NULL,20);
INSERT INTO dept_copy SELECT * FROM department;

CREATE SEQUENCE seq
    START WITH 1
    INCREMENT BY 1
    NOMAXVALUE
    NOMINVALUE;
    
CREATE TABLE seq_test (
    ID NUMBER PRIMARY KEY,
    title VARCHAR2(20)
    );
    
INSERT INTO seq_test VALUES(seq.NEXTVAL, '타이틀1');
INSERT INTO seq_test VALUES(seq.NEXTVAL, '타이틀2');
DROP TABLE seq_test;
SELECT * FROM user_sequences;
DROP SEQUENCE seq;

UPDATE dept_copy SET dname = 'PROGRAMMING' WHERE dno = 10;
UPDATE dept_copy SET dname = 'HR';
UPDATE dept_copy SET dname = 'PROGRAMMING', loc = 'SEOUL' WHERE dno = 10;
UPDATE dept_copy SET loc=(SELECT loc FROM dept_copy WHERE dno=20) WHERE dno=10;
DELETE emp_copy WHERE dno = (SELECT dno FROM department WHERE dname = 'SALES'); 

-- 2p, 검색
SELECT * FROM employee WHERE dno = 10;
SELECT * FROM employee WHERE ename = 'SCOTT';
SELECT * FROM employee WHERE hiredate <= '1981/01/01';
SELECT * FROM employee WHERE dno=10 AND JOB='MANAGER';
SELECT * FROM employee WHERE dno=10 OR JOB='MANAGER';
SELECT * FROM employee WHERE NOT dno=10;
SELECT * FROM employee WHERE salary BETWEEN 1000 AND 1500;
SELECT * FROM employee WHERE commission IN(300,500,1400);
SELECT * FROM employee WHERE ename LIKE 'F%';
SELECT * FROM employee WHERE ename LIKE '_A%';
SELECT * FROM employee WHERE commission IS NULL;
SELECT * FROM employee WHERE commission IS NOT NULL;
SELECT * FROM employee ORDER BY salary ASC;
SELECT * FROM employee ORDER BY salary DESC;
SELECT * FROM employee ORDER BY salary DESC, ename ASC;

SELECT SUM(salary) AS "급여총액",
    AVG(salary) AS "급여평균",
    MAX(salary) AS "최대급여",
    MIN(salary) AS "최소급여"
    FROM employee;

-- 3p

SELECT COUNT(*) AS "사원의 수" FROM employee;
SELECT COUNT(DISTINCT JOB) AS "직업 종류의 개수" FROM employee;
-- 부서 번호별 급여평균
SELECT dno AS "부서번호", AVG(salary) AS "급여 평균" FROM employee GROUP BY dno;

SELECT dno, JOB, COUNT(*), SUM(salary) FROM employee
    GROUP BY dno, JOB ORDER BY dno, JOB;

--SELECT dno, COUNT(*) from employee group by dno order by count(*);
SELECT dno, MAX(salary) FROM employee GROUP BY dno HAVING MAX(salary) >= 3000;
SELECT round(sysdate - hiredate) AS "근무일수" FROM employee;
SELECT ename, sysdate, hiredate, TRUNC(months_between(sysdate, hiredate)) FROM employee;
SELECT ename, hiredate, add_months(hiredate, 6) FROM employee;
SELECT ename, hiredate, to_char(hiredate, 'yy-mm'),
    to_char(hiredate, 'yyyy/mm/dd day') FROM employee;

SELECT to_char(sysdate, 'yyyy/mm/dd, hh24:mi:ss') FROM dual;
SELECT ename, to_char(salary, 'L999,999') FROM employee;
SELECT ename, hiredate FROM employee WHERE hiredate=TO_DATE(19810220,'yyyymmdd');

-- 4p

SELECT ename, dno,
    CASE
    WHEN dno=10 THEN 'ACCOUNTING'
    WHEN dno=20 THEN 'RESEARCH'
    WHEN dno=30 THEN 'SALES'
    WHEN dno=40 THEN 'OPERATIONS'
    ELSE 'DEFAULT'
    END AS "부서명"
    FROM employee ORDER BY dno;
    
SELECT eno, ename, JOB, salary, 
    decode(JOB, 'ANALYST', salary+200,
    'SALESMAN', salary+180,
    'MANAGER', salary+150,
    'CLERK', salary+100,
    salary) AS "보너스 지급" 
    FROM employee;

SELECT decode(dno, 10, 'ACCOUNTING',
    20, 'RESEARCH',
    30, 'SALES',
    40, 'OPERATIONS') AS "부서명",
decode(dno, 10, 'NEW YORK',
    20, 'DALLAS',
    30, 'CHICAGO',
    40, 'BOSTON') AS "지역",
COUNT(*) AS "사원수", round(AVG(salary)) AS "평균급여" FROM employee GROUP BY dno;
SELECT E.eno, E.ename, D.dname, E.dno FROM employee E, department D
    WHERE E.dno = D.dno AND E.eno=7788;
SELECT E.eno, E.ename, D.dname, dno FROM employee E JOIN department D
    USING(dno) WHERE E.eno=7788;
SELECT E.eno, E.ename, D.dname, E.dno FROM employee E JOIN department D
    ON E.dno = D.dno WHERE E.eno=7788;
SELECT E.ename, D.dname, E.salary, S.grade FROM employee E, department D, salgrade S 
    WHERE E.dno = D.dno AND salary BETWEEN losal AND hisal;
SELECT E.eno, E.ename, D.dname, dno FROM employee E NATURAL JOIN department D
    WHERE E.eno=7788;
    
-- 5p
SELECT e.ename as "사원", m.ename as "직속상관" from employee e, employee m
    WHERE e.manager = m.eno;
SELECT e.ename as "사원", m.ename as "직속상관" 
    from employee e left OUTER JOIN employee m
    on e.manager = m.eno;
SELECT E.ENAME, D.DNAME FROM EMPLOYEE E NATURAL JOIN DEPARTMENT D WHERE DNO IN(10,20,30,40)
AND E.ENAME LIKE '%A%';
SELECT ename, dno from employee where dno = (select dno from employee where ename='SCOTT');
SELECT ename from employee where eno
    in (SELECT eno from employee where manager is null);
SELECT dno, ename, job from employee WHERE dno = 
    (SELECT dno from department where dname = 'RESEARCH');
SELECT eno, ename, dno, salary from employee where salary in (SELECT min(salary) 
    from employee GROUP by dno) order by dno;
SELECT eno, ename, job, salary from employee
    where salary < any (SELECT salary from employee
    where job='SALESMAN') and job <> 'SALESMAN';

SELECT eno, ename, job, salary from employee
    where salary < all (SELECT salary from employee
    where job='SALESMAN') and job <> 'SALESMAN';

CREATE TABLE dept_copy as select * from department;
CREATE TABLE emp_copy as select * from employee;
DELETE from dept_copy;
INSERT INTO dept_copy SELECT * from department;

UPDATE dept_copy SET loc = (SELECT loc FROM dept_copy WHERE dno=20) WHERE dno=10;
UPDATE dept_copy SET dname=(SELECT dname FROM dept_copy WHERE dno=30),
    loc=(SELECT loc FROM dept_copy WHERE dno=30) WHERE dno = 10;
    
delete emp_copy where dno=(select dno from department where dname='SALES');

create or REPLACE view v_emp (사원, 사원이름, 부서번호, 담당업무) as SELECT eno,
    ename, dno, job
    from employee where job like 'SALESMAN';

drop view v_emp;

set SERVEROUTPUT on
declare
    v_eno number(4);
    v_ename employee.ename%type;

begin
    v_eno := 7788;
    v_ename := 'scott';
    dbms_output.put_line('사원번호          사원이름');
    dbms_output.put_line('-------------------------');
    dbms_output.put_line(v_eno || '           ' || v_ename);
    end;
*/
