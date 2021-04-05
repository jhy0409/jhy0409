/*
SELECT sum(salary) as "급여총액",
    avg(salary) as "급여평균",
    max(salary) as "최대급여",
    min(salary) as "최소급여" from employee;
    
select count(*) as "사원 수" from employee;

-- DISTINCT 중복 배제
select count(DISTINCT job) as "직업 종류 개수" from employee; 
select dno as "부서 번호", avg(salary) as "급여 평균"
    from employee GROUP by dno;
SELECT dno, job, COUNT(*), sum(salary) from employee
    group by dno, job order by dno, job; 
-- desc

SELECT dno, MAX(salary) FROM employee 
    GROUP by dno having max(salary) >= 3000;

-- 동등, Equal join
select * from employee, department where employee.dno = department.dno;
*/

-- 1. 별칭 부여 employee e, department d
SELECT e.eno, e.ename, d.dname, e.dno 
    FROM employee e, department d 
    where e.dno = d.dno and e.eno = 7788;

-- 2. dno > from employee e를 참조 (생략됨)
select e.eno, e.ename, d.dname, dno 
    from employee e join department d using(dno) 
    where e.eno = 7788;

-- 3. 1==2==3
SELECT e.eno, e.ename, d.dname, e.dno 
    from employee e join department d
    on e.dno = d.dno where e.eno = 7788;
    
SELECT e.ename, d.dname, e.salary, s.grade 
    FROM employee e, department d, salgrade s
    where e.dno=d.dno and e.salary BETWEEN losal and s.hisal;
