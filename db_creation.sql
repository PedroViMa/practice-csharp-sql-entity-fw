-- Create Store Database
CREATE DATABASE Store
USE Store
GO

-- Create Product Table
CREATE TABLE Product (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName VARCHAR(255) NOT NULL,
    Description TEXT,
    Price DECIMAL(10, 2) NOT NULL,
    StockQuantity INT NOT NULL
);

-- Create Sales Table
CREATE TABLE Sales (
    SalesID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT,
    QuantitySold INT NOT NULL,
    SaleDate DATETIME NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

-- Create Purchase Table
CREATE TABLE Purchase (
    PurchaseID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT,
    QuantityPurchased INT NOT NULL,
    PurchaseDate DATETIME NOT NULL,
    TotalCost DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);
