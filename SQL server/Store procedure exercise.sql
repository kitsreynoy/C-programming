

--1. List all products, name: GetAllProducts
  exec GetAllProducts ;

--2. Get product by ID, name: GetProductByID
   exec GetProductByID @id = 65;

--3. Add a new product, name: AddProduct
  exec AddProduct @newProductName= 'phone',
  @newCategory= 'office',
  @newPrice= 128.46,
  @newStock=12;


--4. Update product price, name: UpdateProductPrice

exec UpdateProductPrice @ProductPrice = 340.23 , @id=2;

exec UpdateProductPrice @ProductPrice = 432.9 , @id=3;

exec UpdateProductPrice @ProductPrice = 12.89 , @id=4;

exec UpdateProductPrice @ProductPrice = 455.89 , @id=5;

exec UpdateProductPrice @ProductPrice = 112.09 , @id=6;


--5. Delete product by ID, name: DeleteProduct

exec DeleteProduct @id = 54;
exec DeleteProduct @id = 55;
exec DeleteProduct @id = 56;

--6. Print product count (variable), name: ProductCount

declare @Mycount int 
exec ProductCount @count = @Mycount output;
select @Mycount;

--7. Cheapest product, name: ShowCheapestProduct
exec ShowCheapestProduct ;


--8. Most expensive product,name: ShowMostExpensive
exec ShowMostExpensive;


--9. Average stock, name: AvgStock
exec AvgStock;

--10. Total inventory value,name: TotalInventoryValue
exec TotalInventoryValue ;

--11. Product count with output, name: GetProductCount
--exec GetProductCount;
declare @TheProduct int;
exec GetProductCount @ProductCount =@TheProduct output;
select @TheProduct as [count the products];

--12. Get max price (output), name: GetMaxPrice
--exec GetMaxPrice;
declare @GetMaxofprice decimal(10,2);
exec GetMaxPrice @Maxprice = @GetMaxofprice output;
select @GetMaxofprice as [Max of price] ;

--13. Get stock by ID (output), name: GetStockByID
--exec GetStockByID @id =2;
declare @stockbyID varchar(30);
declare @Name varchar(30);
declare @categoryy varchar(30);
exec GetStockByID @stock = @stockbyID output, @productName = @Name output, @category= @categoryy output, 
@id=100;
select @stockbyID as [ Get Stock] , @Name as [Productname], @categoryy as [category];

--14. Get price by name (output), name: GetPriceByName
declare @ThePriceOfname decimal(10,2) ;
declare @stockname int ;
declare @productofName varchar(30);
exec GetPriceByName @price = @ThePriceOfname output, @stock = @stockname output, @proname = @productofName output,
@productname = 'Tablet C3';
select @ThePriceOfname as Price , @stockname as [stock] , @productofName as [product name];

15. Product exists (output), name: ProductExists
alter PROCEDURE ProductExists
    @ProductName varchar(30),
    @Exists bit OUTPUT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Products WHERE ProductName = @ProductName)
        SET @Exists = 1;
    ELSE
        SET @Exists = 0;
END;

DECLARE @Result BIT;
EXEC ProductExists @ProductName = 'Smartphone B2',  @Exists = @Result OUTPUT;
SELECT @Result AS ProductExists;




--16. Apply 10% discount, name:ApplyDiscount
--alter proc ApplyDiscount
--(@ProductID int,
--@price decimal(10,2),
--@discount decimal(10,2))
--as
--begin
--UPDATE Products
--    set Price = Price - (Price * 3 )/100 
--    Where ProductID =  @ProductID;
--end;

exec ApplyDiscount @price = 199.99, @discount = 3, @ProductID = 70;


--17. Increase stock,name: AddStock
exec AddStock @Stock = 10, @id=60;

--18. Get products by category, name: GetByCategory
exec GetByCategory18 @category = 'Electronics';


--19. Products in price range, name: GetByPriceRange

exec GetByPriceRange19 @minprice = 0.99 , @maxprice = 12.89;


--20. Low stock alert, name: LowStock

exec LowStock20 @LowOfprice = 10;

--21. Average price in category (output), name: AvgPriceByCategory

declare @AvgpriceinCategory decimal(10,2);
exec AvgPriceByCategory21   @AvgPrice = @AvgpriceinCategory  output , @category= 'Furniture' ;
select @AvgpriceinCategory ;

--22. Count in price range(output), name: CountByPriceRange

--create proc CountByPriceRange22 (@minprice decimal(10,2),
--@maxprice decimal(10,2),
--@productcount int output)
--as
--begin
--select @productcount = count(*) from products where price between  @minprice and @maxprice;

--end;
declare @result int ;
exec CountByPriceRange22  @productcount  = @result output , @minprice= 59.99, @maxprice = 129.99;
select @result ;
DECLARE @result INT;

EXEC CountByPriceRange22  
    @productcount = @result OUTPUT,  
    @minprice = 1 ,
    @maxprice = 3;

SELECT @result;


--23. Get name by ID(output), name: GetNameByID, type OUTPUT variable

create PROC GetNameByID23
(@id INT, @productName VARCHAR(100) OUTPUT)
AS
BEGIN 
--select * from products where productID = 7;

SELECT @productName = productName FROM products WHERE productID = @id;
END;

DECLARE @result VARCHAR(100);
EXEC GetNameByID23 @productName = @result OUTPUT, @id = 90;
SELECT @result as [product name];



--24. Check if stock is low (output), name: IsLowStock



--25. Auto restock if below threshold, name: AutoRestock

exec AutoRestock @RestockAmount = 30, @Threshold = 91;


--select * from products where productID = 67   order by stock ; 
--update products set stock = stock + 30 where stock < 31;

--26. Clear all stock, name: ClearStock


--create proc ClearStock
--as
--begin
--update products set stock = 0;

--end;
exec ClearStock;

--27. Delete products with 0 stock, name: DeleteEmptyStock

--create proc DeleteEmptyStock27
--as
--begin

--delete from products where stock = 0;
--end;

exec DeleteEmptyStock27;

--28. List unique categories, name: ListCategories
--create proc ListCategories28
--as
--begin
--select distinct category from products  ;
--end;

exec ListCategories28;

--29. Count products by category, name: CountByCategory
alter proc CountByCategory29
  (@category varchar (30))
as
begin 
select count(*)as [count category] from products where category = @category;

end;

exec CountByCategory29 @category = 'office';

--30. Get price & stock (dual output) , name: GetPriceAndStock
alter proc GetPriceAndStock
  (@price decimal(10,2)output, 
  @stock int output, 
  @id int)
as
begin 
select  @price = price, 
       @stock =stock
   from products where productID = @id;
end;


declare @p decimal(10,2),  @s int;
exec GetPriceAndStock 
@price = @p output,
@stock = @s output,
@id = 100;
select @p as price  , @s as stock;


--24. Check if stock is low (output), name: IsLowStock

--create proc IsLowStock24 
--as
--begin


--end;
