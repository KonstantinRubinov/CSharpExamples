-- View

use Northwind
go

create view CustomersWithFax as
select CompanyName, ContactName, Phone, Fax, Country, City from Customers where Fax is not null
go


select * from CustomersWithFax
select * from CustomersWithFax where Country = 'USA'
select CompanyName, ContactName, Fax from CustomersWithFax where Country = 'UK'


drop view CustomersWithFax 


select CompanyName, ContactName, Phone, Fax, Country, City from Customers where Fax is not null and country = 'USA'
select CompanyName, ContactName, Phone, Fax, Country, City from Customers where Fax is not null and country = 'UK'
select CompanyName, ContactName, Phone, Fax, Country, City from Customers where Fax is not null and CompanyName like 'A%'



