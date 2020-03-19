CREATE PROCEDURE sproc_tblStock_Insert
	@Manufacturer varchar (15),
	@Quantity int,
	@Colour varchar (15),
	@Model varchar (20),
	@Price decimal (18),
	@StockYear datetime
	AS
	INSERT INTO tblStock (Manufacturer, Quantity, Colour, Model, Price, StockYear)
	values (@Manufacturer, @Quantity, @Colour, @Model, @Price, @StockYear)

return @@Identity
