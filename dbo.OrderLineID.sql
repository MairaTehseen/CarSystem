CREATE TABLE [dbo].[tblOrderLineID] (
    [OrderLineID] INT NOT NULL,
    [OrderID]     INT NULL,
    [ProductID]   INT NULL,
    [Quantity]    INT NULL,
    PRIMARY KEY CLUSTERED ([OrderLineID] ASC)
);

