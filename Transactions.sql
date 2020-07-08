use Northwind
go -- Complete Batch

-- Problems: 
-- 1. Dirty Reads:
--    rollback מתבצעת קריאה של מידע ששונה ע"י טרנסאקציה, אך המידע הולך לחזור למצבו הראשוני עקב
-- 2. Non Repeatable Read:
--    מתבצעת קריאת מידע פעמיים
--    פעם ראשונה שורה המכילה מידע א' ששונה ע"י טרנסאקציה
--    rollback פעם שנייה אותה השורה אך לאחר שהטרנסאקציה ביצעה
-- 3. Phantom Read
--    קראנו מספר שורות פעמיים
--    בפעם הראשונה היו שורות שהתווספו ע"י טרנסאקציה
--    rollback בפעם השנייה קראנו שוב, אך השורות הללו לא היו יותר עקב


-- Isolation Level   |  Dirty Reads   | Non Repeatable Reads  |  Phantom Reads
------------------------------------------------------------------------------
-- Read Uncommitted  |       V        |          V            |       V
-- Read Committed    |       X        |          V            |       V
-- Repeatable Read   |       X        |          X            |       V
-- Serializable      |       X        |          X            |       X




-- Create procedure: 
alter procedure UpdateTwoProducts(@prodID1 int, @price1 money, @prodID2 int, @price2 money) as

	--set transaction isolation level Read Uncommitted
	--set transaction isolation level Read Committed
	--set transaction isolation level Repeatable Read
	set transaction isolation level Serializable

	begin try
		begin transaction
		update Products set UnitPrice = @price1 where ProductID = @prodID1
		update Products set UnitPrice = @price2 where ProductID = @prodID2
		commit transaction
	end try
	begin catch
		rollback transaction
	end catch
go

-- Use the above procedure: 
exec UpdateTwoProducts 1, 10, 2, 20

exec UpdateTwoProducts 1, 300, 2, -200








