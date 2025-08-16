select * from customers;
select * from Orders;

select * from [dbo].[Customers] l;
vgb
select * from [dbo].[Orders] r;

select * from customers c 
inner join Orders r on c.customerid=r.customerid
bvvgb
select c.customerid, c.customername, r.orderid, r.amount from customers c 
inner join Orders r on c.customerid=r.customerid

select c.customerid, c.customername, r.orderid, r.amount from customers c 
inner join Orders r on c.customerid=r.customerid 
where c.customerid =3;

select a.customerid, a.customerName,  a.city,b.orderid,b.amount from customers a inner join orders b on
a.customerid = b.customerid where b.customerid = 1 or b.customerid=3 ;

select n.customerid,n.city, r.amount from customers n inner join 
orders r on n.customerid= r.customerid
where n.customerid =1;

select * from cus



CREATE TABLE Students (
    student_id INT PRIMARY KEY,
    student_name VARCHAR(100),
    class_id INT
);

-- Table: Classes
CREATE TABLE Classes (
    class_id INT PRIMARY KEY,
    class_name VARCHAR(100),
    teacher_id INT
);

-- Table: Teachers
CREATE TABLE Teachers (
    teacher_id INT PRIMARY KEY,
    teacher_name VARCHAR(100)
);

-- Table: Enrollments
CREATE TABLE Enrollments (
    enrollment_id INT PRIMARY KEY,
    student_id INT,
    subject_id INT
);

-- Table: Subjects
CREATE TABLE Subjects (
    subject_id INT PRIMARY KEY,
    subject_name VARCHAR(100)
);