CREATE TABLE [dbo].[tblStock] (
    [Car_ID]           INT          NOT NULL,
    [Car_Manufacturer] CHAR (15)    NULL,
    [Car_Quantity]     INT          NULL,
    [Colour]           CHAR (10)    NULL,
    [Model]            CHAR (15)    NULL,
    [Price]            NUMERIC (18) NULL,
    [Year]             DATE         NULL,
    PRIMARY KEY CLUSTERED ([Car_ID] ASC)
);

