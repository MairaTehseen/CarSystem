CREATE PROCEDURE sproc_tblStock_Update
    @StockNo int,
	@Manufacturer varchar (15),
	@Quantity int,
	@Colour varchar (15),
	@Model varchar (20),
	@Price decimal (18),
	@StockYear datetime

	AS

	update tblStock
	set Manufacturer=@Manufacturer, 
	    Quantity=@Quantity,
		Colour=@Colour,
		Model=@Model, 
		Price=@Price,
		StockYear=@StockYear

	where StockNo=@StockNo
