create proc SP_Price 
as 
begin
 select unitprice* (UnitsInStock + ISNULL (UnitsOnOrder,0))as Price from [dbo].[Products] b ;

end;

----select unitprice* (UnitsInStock + UnitsOnOrder)as Price from [dbo].[Products] b ;
 
 --select unitprice* (UnitsInStock + ISNULL (UnitsOnOrder,0))as Price from [dbo].[Products] b ;

 USE [EmployeeDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_Price]    Script Date: 7/14/2025 10:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_Price] 
as 
begin
 select unitprice* (UnitsInStock + ISNULL (UnitsOnOrder,0))as Price from [dbo].[Products] b ;

end;

exec SP_Price;
