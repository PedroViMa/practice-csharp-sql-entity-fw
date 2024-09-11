-- Populating Product Table
INSERT INTO Product
(ProductName, Description, Price, StockQuantity)
VALUES
('Libreta Scribess', 'Libreta Scribess colores varios, hoja cuadro pequeno', 10.5, 7),
('Lapicero Tic Negro', 'Lapicero Tic tinta negro, punta fina', 15, 5),
('Estuche Rayo McKuin', null, 150.5, 17),
('Mochila', null, 300.5, 15),
('Tijeras', null, 10.5, 6),
('Post-in', null, 7.5, 10),
('Lapicero Paper-Late Azul', 'Lapicero de la marca PaperMate tinta azul, punta regular de gel.', 10.5, 4),
('Lapicero Tic Rojo', 'Lapicero Tic tinta negro, punta fina', 15, 20),
('Caja Sorpresa', null, 50.5, 5),
('Plumines', null, 10.5, 10)

-- Populating Purchase Table
INSERT INTO Purchase
(ProductID, QuantityPurchased, PurchaseDate, TotalCost)
VALUES
(1, 10,  DATETIMEFROMPARTS ( 2024 , 6 , 30 , 12 , 0 , 0 , 0), 90.89),
(2, 5, DATETIMEFROMPARTS ( 2024 , 6 , 30 , 12 , 0 , 0 , 0), 59.99),
(3, 10,  DATETIMEFROMPARTS ( 2024 , 6 , 30 , 12 , 0 , 0 , 0), 999.99),
(4, 10,  DATETIMEFROMPARTS ( 2024 , 6 , 30 , 12 , 0 , 0 , 0), 2699.89),
(5, 10,  DATETIMEFROMPARTS ( 2024 , 6 , 30 , 12 , 0 , 0 , 0), 90.89),
(6, 10,  DATETIMEFROMPARTS ( 2024 , 6 , 30 , 12 , 0 , 0 , 0), 69.89),
(3, 5, DATETIMEFROMPARTS ( 2024 , 7 , 5 , 12 , 0 , 0 , 0), 499.49),
(1, 5, DATETIMEFROMPARTS ( 2024 , 8 , 5 , 12 , 0 , 0 , 0), 45.49),
(4, 5, DATETIMEFROMPARTS ( 2024 , 8 , 5 , 12 , 0 , 0 , 0), 499.99),
(3, 5, DATETIMEFROMPARTS ( 2024 , 8 , 5 , 12 , 0 , 0 , 0), 499.49)

-- Populating Sales Table
INSERT INTO Sales
(ProductID, QuantitySold, SaleDate, TotalAmount)
VALUES
(1, 2,  DATETIMEFROMPARTS ( 2024 , 8 , 30 , 12 , 0 , 0 , 0), 250.89),
(3, 1, DATETIMEFROMPARTS ( 2024 , 8 , 30 , 12 , 0 , 0 , 0), 300.99),
(5, 3,  DATETIMEFROMPARTS ( 2024 , 8 , 30 , 12 , 0 , 0 , 0), 200.89),
(7, 1,  DATETIMEFROMPARTS ( 2024 , 8 , 30 , 12 , 0 , 0 , 0), 650.89),
(1, 1,  DATETIMEFROMPARTS ( 2024 , 8 , 30 , 12 , 0 , 0 , 0), 450.89),
(1, 5,  DATETIMEFROMPARTS ( 2024 , 8 , 30 , 12 , 0 , 0 , 0), 550.89),
(3, 2, DATETIMEFROMPARTS ( 2024 , 9 , 5 , 12 , 0 , 0 , 0), 100.49),
(5, 1, GETDATE(), 125.49),
(7, 5, GETDATE(), 324.99),
(7, 5, GETDATE(), 150.49)

