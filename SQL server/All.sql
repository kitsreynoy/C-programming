--Query: Find employees whose salary is greater than all salaries in the 'Finance' department.
SELECT first_name, last_name, salary
FROM employees
WHERE salary > ALL (SELECT salary FROM employees WHERE department_id = 2);--60000.00  72000.00
--SELECT salary FROM employees WHERE department_id = 2;

select * from [dbo].[departments] d;

select * from [dbo].[employees] e;