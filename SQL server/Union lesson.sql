select * from Employees_Europe;
select * from Employees_US;

select   EmployeeID, FirstName, LastName, Country from Employees_Europe 
union select  EmployeeID, FirstName, LastName, Country from Employees_US;


select EmployeeID, FirstName, LastName, Country from Employees_Europe 
union all select EmployeeID, FirstName, LastName, Country from Employees_US;

--update Employees_US set country = 'UK' where EmployeeID = '3';--
