-- 부하직원
SELECT ename FROM employee WHERE eno IN
(SELECT eno FROM employee WHERE MANAGER IS NULL);

-- <> : 다르다. 
SELECT eno, ename, JOB, salary FROM employee
    WHERE salary < ALL (SELECT salary FROM employee
    WHERE JOB = 'SALESMAN') AND JOB <> 'SALESMAN';

-- CREATE TABLE dept_copy AS SELECT * FROM department;

UPDATE dept_copy set loc=(SELECT loc FROM dept_copy WHERE dno=20)
    WHERE dno=10;