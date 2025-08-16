


SELECT ProductName, UnitPrice * (UnitsInStock + isnull(UnitsOnOrder,0)) as PriceCalculate
FROM Products;

select * from Products;

SELECT ProductName, UnitPrice * (UnitsInStock + COALESCE(UnitsOnOrder,0)) as PriceCalculate
FROM Products;

--select productName,
--case 
--when  then null
--else 0
--end from Products;

SELECT ProductName, UnitPrice * (UnitsInStock + case
                                                  when UnitsOnOrder is null then 100
                                                   else UnitsOnOrder
                                                   end ) as PriceCalculate,
 case 
    when UnitPrice * (UnitsInStock + case
                                            when UnitsOnOrder is null then 100
                                            else UnitsOnOrder
   end ) >= 400 then 'Good'
   else 'Bad' end as price 
   from products;

   SELECT 
  ProductName,
  PriceCalculate,
  CASE 
    WHEN PriceCalculate >= 300 THEN 'Good'
    ELSE 'Bad'
  END AS Price
FROM (
  SELECT 
    ProductName,
    UnitPrice * (UnitsInStock + CASE 
                                  WHEN UnitsOnOrder IS NULL THEN 100 
                                  ELSE UnitsOnOrder 
                                END) AS PriceCalculate
  FROM Products
) AS Sub;

