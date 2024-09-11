-- View to show ONLY the purchased products
CREATE VIEW PurchasedProductsView AS
SELECT DISTINCT p.ProductID, p.ProductName
FROM Product p
JOIN Purchase ON p.ProductID = Purchase.ProductID;
GO

-- View to show ONLY the sold prodcuts
CREATE VIEW SoldProdcutsView AS
SELECT DISTINCT  p.ProductID, p.ProductName
FROM Product p
JOIN Sales ON p.ProductID = Sales.ProductID;
GO

-- View that show the product that have purchases and sells
CREATE VIEW SoldAndPurchasedProductsView AS
SELECT DISTINCT p.ProductID, p.ProductName
FROM Product p
JOIN Sales ON p.ProductID = Sales.ProductID
JOIN Purchase ON p.ProductID = Sales.ProductID;
GO

-- View that shows the avg of each grouo sold
CREATE VIEW MonthlySellsView AS
SELECT MONTH(SaleDate) month, AVG(TotalAmount) avg_sold, MAX(TotalAmount) most_expensive, MIN(TotalAmount) cheapest
FROM Sales s
JOIN Product p ON s.ProductID = p.ProductID
GROUP BY  MONTH(SaleDate);