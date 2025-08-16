
---
-- Insert data into Employees table
INSERT INTO Employees (EmployeeID, FirstName, LastName, Department, Salary) 
VALUES 
(1, 'John', 'Doe', 'HR', 50000),
(2, 'Jane', 'Smith', 'Finance', 60000),
(3, 'Sam', 'Brown', 'Engineering', 70000);
-- Add more rows as needed up to 50

-- Insert data into Departments table
INSERT INTO Departments (DepartmentID, DepartmentName, Location) 
VALUES 
(1, 'HR', 'New York'),
(2, 'Finance', 'Los Angeles'),
(3, 'Engineering', 'San Francisco');
-- Add more rows as needed up to 50

-- Insert data into Projects table
INSERT INTO Projects (ProjectID, ProjectName, DepartmentID, StartDate, EndDate) 
VALUES 
(1, 'Project Alpha', 1, '2023-01-01', '2023-12-31'),
(2, 'Project Beta', 2, '2023-03-01', '2023-06-30'),
(3, 'Project Gamma', 3, '2023-05-01', '2023-11-30');
-- Add more rows as needed up to 50



select * from Employees;
select * from Departments;
select * from Projects;


-------------------All Question------------
1. Select all employees from the Employees table.
select * from employees;

2. Select distinct department names from the Employees table.
select distinct department from Employees;

3. Select employees with a salary greater than 60000.
select * from employees where salary>60000;

4. Select all employees and order them by their salary in descending order.
select * from employees order by salary desc; 

5.Select employees who work in the HR department and have a salary greater than 50000.
select * from employees where department='HR' and salary>50000;

6.Select employees who are either in HR or Engineering departments.
select * from employees where  department ='HR' or department='Engineering' ;

7.Select employees who are not in the Finance department.
select * from employees where not department='Finance';

8.Insert a new employee into the Employees table.



9.Select employees who do not have a department listed (NULL value).
select * from employees where  department is null ;

--10.Update the salary of an employee in the HR department to 55000.
--Update employees set salary =55000 where department = 'HR';

--11.Delete a record of an employee with EmployeeID 3.
--Delete from employees where EmployeeID ='3';

--12.Select the top 5 highest-paid employees.
select top 5 * from employees;

--13.Find the average salary of all employees.
select avg(salary)as SalaryAVG from employees;

--14.Find the minimum and maximum salary in the Employees table.
select min(salary)as MIN , max(salary)as MAX from Employees;

--15.Count the number of employees in each department.
select count(*)as[Count number] from employees ;

--16.Find the total salary paid to all employees.
select salary from employees ;

--17.Find the average salary of employees in the Engineering department.
select avg(salary)as SalaryAVG from employees where department = 'Engineering';

--18.Select employees whose names start with 'J'.
select * from employees where firstName like 'J%';

--19.Select all employees whose department name contains 'Finance'.
select * from employees where department='Finance';

--20.Select employees whose department is either HR or Engineering.
select * from employees where department  = 'Engineering' or  department='HR';

--21.Select employees whose salaries are between 50000 and 70000.
select * from employees where salary between '50000' and '70000';

--22.Select employees and display their salary with an alias 'AnnualSalary'.
select count(salary)as AnnualSalary from employees ;


select * from Projects;
select * from Employees;
select * from Departments;


--23.Select employees along with their department details using an inner join."
select * from employees inner join departments on employees.employeeID = departments.departmentID 

--24.Select all employees and their project details, including employees with no project.(left join)
select * from Employees left join projects on employees.employeeID = projects.projectID;

--25.Select all projects and their associated employees using a right join.
select * from Projects right join employees on projects.projectID = employees.employeeID;

--26.Select all employees and projects, even if there is no match.
select * from employees full outer join projects on employees.employeeID = projects.projectID;
select * from employees full outer join projects on employees.employeeID = projects.departmentID;


--27.Select employees and match them with their manager (self join).
select * from employees ;


--28.Select all employee names from the Employees table and all project names from the Projects table using UNION.
select FirstName,LastName from employees union all select projectName from projects;


--29.Group employees by department and count the number of employees in each department.
select department , count(employeeID)as [count employee] from employees group by department ;

--30.Group employees by department and display departments with more than 5 employees.
select department from employees group by department ;

--31.Check if any employee exists in the Engineering department.
select case when exists ( select * from employees w where w.department = 'Engerneering') then 'YES' 
else 'NO' end as DepartmentName from employees w;


--32.Find all employees who do not have a department assigned.
select * from employees where department is null;
select * from employees where ;

--33.Select all employees who have a department assigned.
select * from employees where department is not null; 
select * from employees where ;

--34.Find employees whose salary is greater than 60000 and who work in either HR or Engineering.
select * from employees where salary>60000 and department='HR' and department='Engineering';

--35.Order employees by salary in descending order.
select * from employees order by salary desc;

--36.Count the number of distinct departments in the Employees table."
select distinct count(department)as [Count Number of distinct] from Employees;

--37.Select employees whose department is listed in a subquery of department names.
select * from employees 

--38.Select employees and their projects using a join on the DepartmentID.
select * from employees inner join projects on employees.employeeID = projects.DepartmentID;


--39.Display departments with an average salary greater than 60000.
select avg(salary)as [Salary of department] from employees where salary> 60000;

--40.Select the top 5 highest-paid employees and order them by salary.
select top 5 * from employees  order by salary  ;

--41.Select employees who have a salary greater than the average salary.
select avg(salary) from employees having avg(salary) > 50000;
select * from employees a where a.salary > (select avg(salary) from employees); (--subquery) 

--42.Select employees and display their salary level as 'High', 'Medium', or 'Low' based on salary.
select case when q.salary >=60000 then 'Great A'
            when q.salary between 55000 and 60000 then 'Great B'
			else 'Great C' end as LevelSalary
from employees q  ;

--43.Select distinct department names where salary is greater than 50000.
select distinct Department from employees where salary > 50000;
 

--44.Select employees who do not work in HR or Finance.
select * from employees where department not in( 'HR' , 'Finance');

--45. Join Employees and Departments tables and display employees who work in 'HR'.
select * from Employees inner join Departments on Employees.EmployeeID = Departments.DepartmentID where department = 'HR';

--46.Select employees and their project details, including those without projects.
select * from employees left join projects on employees.employeeID = projects.projectID;


--47.Group projects by department and count how many projects each department has.
select count(department) , project from departments group by project ;

--48.Update the department of an employee with EmployeeID 5.

--49.Delete employees who have not been assigned to any project.
--50.Delete employees who have not been assigned to any project.
Delete from employees where projects   


select * from Departments;

select * from Employees;

select * from Projects;

















select * from Projects;
select * from Employees;
select * from Departments;


--1. Select all employees from the Employees table.
select * from employees;

--2. Select distinct department names from the Employees table.
select distinct department from Employees;

--3. Select employees with a salary greater than 60000.
select * from employees where salary >= 60000;

--4. Select all employees and order them by their salary in descending order.
select * from employees where salary = 60000 order by salary desc;

--5.Select employees who work in the HR department and have a salary greater than 50000.
select * from employees where department = 'HR'and salary >50000;  

--6.Select employees who are either in HR or Engineering departments.
select * from employees where department = 'HR' or  department = 'Engineering';

--7.Select employees who are not in the Finance department.
select * from employees where department <> 'Finance';

--8.Insert a new employee into the Employees table.
INSERT INTO Employees (EmployeeID, FirstName, LastName, Department, Salary)
VALUES
(3, 'sok', 'daro', 'IT', 10000),
(4, 'sok', 'daro', 'IT', 50000),
(5, 'koy', 'mary', 'IT', 13000),
(6, 'by', 'bouhy', 'IT', 60000),
(7, 'kea', 'kimheng', 'IT', 80000),
(8, 'chhorn', 'vanneth', 'IT', 110000),
(9, 'kong', 'kimran', 'IT', 90000),
(10, 'keo', 'domra', 'IT', 30000),
(11, 'kong', 'nita', 'IT', 80000),
(12, 'sok', 'reaksa', 'IT', 20000),
(13, 'sok', 'rathna', 'IT', 40000),
(14, 'Kit', 'sreynoy', 'IT', 70000);

--9.Select employees who do not have a department listed (NULL value).
select * from employees where department is null; 


--10.Update the salary of an employee in the HR department to 55000.
--Update employees set salary =55000 where department = 'HR';

--11.Delete a record of an employee with EmployeeID 3.
--Delete from employees where EmployeeID ='3';

--12.Select the top 5 highest-paid employees.
select top 5 * from employees order by salary desc;

--13.Find the average salary of all employees.
select avg(salary) as [avg of salary] from employees;

--14.Find the minimum and maximum salary in the Employees table.


--15.Count the number of employees in each department.

--16.Find the total salary paid to all employees.

--17.Find the average salary of employees in the Engineering department.

--18.Select employees whose names start with 'J'.

--19.Select all employees whose department name contains 'Finance'.

--20.Select employees whose department is either HR or Engineering.

--21.Select employees whose salaries are between 50000 and 70000.

--22.Select employees and display their salary with an alias 'AnnualSalary'.


select * from Projects;
select * from Employees;
select * from Departments;


--23.Select employees along with their department details using an inner join."

--24.Select all employees and their project details, including employees with no project.(left join)

--25.Select all projects and their associated employees using a right join.

--26.Select all employees and projects, even if there is no match.


--27.Select employees and match them with their manager (self join).


--28.Select all employee names from the Employees table and all project names from the Projects table using UNION.


--29.Group employees by department and count the number of employees in each department.

--30.Group employees by department and display departments with more than 5 employees.

--31.Check if any employee exists in the Engineering department.


--32.Find all employees who do not have a department assigned.

--33.Select all employees who have a department assigned.

--34.Find employees whose salary is greater than 60000 and who work in either HR or Engineering.

--35.Order employees by salary in descending order.

--36.Count the number of distinct departments in the Employees table."

--37.Select employees whose department is listed in a subquery of department names.

--38.Select employees and their projects using a join on the DepartmentID.


--39.Display departments with an average salary greater than 60000.

--40.Select the top 5 highest-paid employees and order them by salary.

--41.Select employees who have a salary greater than the average salary.
 (--subquery) 

--42.Select employees and display their salary level as 'High', 'Medium', or 'Low' based on salary.


--43.Select distinct department names where salary is greater than 50000.
 

--44.Select employees who do not work in HR or Finance.

--45. Join Employees and Departments tables and display employees who work in 'HR'.

--46.Select employees and their project details, including those without projects.


--47.Group projects by department and count how many projects each department has.

--48.Update the department of an employee with EmployeeID 5.

--49.Delete employees who have not been assigned to any project.


--50.Delete employees who have not been assigned to any project.
