USE Store;

-- Temporary Table
SELECT ProductName, 
	Sales = CASE 
		WHEN ProductID IN (SELECT DISTINCT ProductID FROM Sales) 
			THEN CONCAT('number of sales', ' ', 
				(SELECT COUNT(Sales.ProductID) FROM Sales WHERE Sales.ProductID = Product.ProductID))
		ELSE 'unsold product'
		END 
INTO TEMPTable
FROM Product; 
GO
SELECT * FROM TEMPTable;
GO

-- Queries
-- Purchases made on products whose name starts with "L"
SELECT * 
FROM Product
JOIN Purchase ON Product.ProductID = Purchase.ProductID
WHERE ProductName LIKE 'L%';