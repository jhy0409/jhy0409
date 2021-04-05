-- 서브쿼리는 뒤에서부터 작성
SELECT ename, dno FROM employee
    where dno = (SELECT dno from employee where ename ='SCOTT');