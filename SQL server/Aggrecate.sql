SELECT TOP (1000) [transaction_id]
      ,[product_name]
      ,[quantity]
      ,[sale_price]
  FROM transactions


select AVG(p.sale_price)  from transactions p; 

select * from [dbo].[transactions] l;

select AVG(p.sale_price) as sale_price_averages, p.product_name  from transactions p group by p.product_name; 
select SUM(p.sale_price) as sale_price_total, p.product_name  from transactions p group by p.product_name; 

select n.quantity as [amount quantities], n.sale_price from [dbo].[transactions] n;

select * from transactions p where p.sale_price > (select avg(a.sale_price)from transactions a);

select avg(a.sale_price)from transactions a

select * from transactions p where p.sale_price >= 20;