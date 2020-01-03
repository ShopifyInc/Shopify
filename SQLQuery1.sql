CREATE TABLE [dbo].[StockDetails] (
    [ProductID]   VARCHAR (50) NOT NULL,
    [ProductName] VARCHAR (50) NOT NULL,
    [UnitPrice]   FLOAT (53)   NOT NULL,
    [Quantity]    FLOAT (53)   NOT NULL,
    [SupplierID]  VARCHAR (50) NOT NULL,
    [Date]        VARCHAR (50) NULL,
    [stockTotal]  INT          NULL,
    PRIMARY KEY CLUSTERED ([ProductID] ASC)
);