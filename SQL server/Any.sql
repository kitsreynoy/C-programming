SELECT first_name, last_name, salary
FROM employees
WHERE salary < ANY (SELECT salary FROM employees WHERE department_id = 5);--50000.00  65000.00
--SELECT salary as salaryforSale FROM employees WHERE department_id = 5;

--select * from [dbo].[departments] d;

select * from [dbo].[employees] e;