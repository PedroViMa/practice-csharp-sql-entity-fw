-- Store Procedure for Adding Products
CREATE PROCEDURE AddProduct
	@ProductName varchar(255),
	@Price decimal(10,2),
	@Description text = null,
	@Quantity int = 0
AS
BEGIN

	INSERT INTO Product
	(ProductName, Description, Price, StockQuantity)
	VALUES
	(@ProductName, @Description, @Price, @Quantity);

END;
GO

-- Store Procedure for Listing Products
CREATE PROCEDURE ListProducts
AS
BEGIN
	SELECT * FROM Product;
END;
GO

-- Store Procedure for Updating a Product Price
CREATE PROCEDURE UpdateProductPrice
(
	@ProductId int,
	@Price decimal(10,2)
)
AS
BEGIN
	
	UPDATE Product
	SET Price = @Price
	WHERE ProductID = @ProductId;

END;
GO

-- Store Procedure for Updating a Product Stock
CREATE PROCEDURE UpdateProductAddToStock
(
	@ProductId int,
	@Quantity int
)
AS
BEGIN

	UPDATE Product
	SET StockQuantity += @Quantity
	WHERE ProductID = @ProductId;

END;
GO

-- Store Procedure for Deleting a Product
CREATE PROCEDURE DeleteProduct
(
	@ProductId int
)
AS
BEGIN

	DELETE FROM Product
	WHERE ProductID = @ProductId;

END;
GO

-- Store Procedure for Purchasing Pruducts
CREATE PROCEDURE PurchaseProduct
(
	@ProductId int,
	@Quantity int,
	@Cost decimal(10, 2)
)
AS
BEGIN
	BEGIN TRANSACTION TS_UpdateProduct
END;