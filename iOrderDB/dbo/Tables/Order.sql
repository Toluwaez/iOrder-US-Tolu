CREATE TABLE [dbo].[Order] (
    [OrderID]          INT      IDENTITY (1, 1) NOT NULL,
    [CustomerID]       INT      NOT NULL,
    [CreatedOn]        DATETIME NOT NULL,
    [Total]            INT      NOT NULL,
    [ConfirmationCode] INT      NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([OrderID] ASC),
    CONSTRAINT [FK_Order_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([CustomerID])
);

