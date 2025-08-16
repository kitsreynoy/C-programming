
--1. Get student names and their class names.
select * from students;
select * from classes;

select x.student_id,x.student_name,z.class_name,z.class_id from students x inner join  classes z on
x.class_id = z.class_id ;

select x.student_id,x.student_name,z.class_name,z.class_id from students x inner join  classes z on
x.class_id = z.class_id where z.class_id = 103;

select x.student_id,x.student_name,z.class_name,z.class_id from students x inner join  classes z on
x.class_id = z.class_id where z.class_name= 'class C';

 





















select * from customers;
select * from orders;

select * from [dbo].[Customers] l;

select * from [dbo].[Orders] r;

select * from customers c 
inner join Orders r on c.customerid=r.customerid

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

