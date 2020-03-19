CREATE PROCEDURE sproc_tblStock_Insert
	@StockNo int,
	@Manufacturer char(10),
	@Quantity int,
	@Colour char(10),
	@Model char(15),
	@Price numeric(18,0),
	@Year date

    AS

	INSERT INTO tblStock (StockNo, Manufacturer, Quantity, Colour, Model, Price, Year)
	values (@StockNo, @Manufacturer, @Quantity, @Quantity, @Colour, @Model, @Price, @Year)

RETURN @@Identity
