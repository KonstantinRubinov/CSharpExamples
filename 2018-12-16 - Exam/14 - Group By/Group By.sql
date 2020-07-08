
use Northwind

select max(UnitPrice) from Products

select CategoryID, max(UnitPrice) from Products
group by CategoryID


