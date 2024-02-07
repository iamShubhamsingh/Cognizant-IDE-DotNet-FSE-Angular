CREATE PROCEDURE RetrieveDeptSalary
AS
BEGIN
    SELECT
    d.deptno,
    d.deptname,
    SUM(e.salary) as total_salary
    FROM Department d
    INNER JOIN Employee e ON d.deptno = e.workdept
    GROUP BY d.deptno, d.deptname
    HAVING SUM(e.salary) > 50000
END
GO