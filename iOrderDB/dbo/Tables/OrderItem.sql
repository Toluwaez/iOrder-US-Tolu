CREATE TABLE [dbo].[OrderItem] (
    [OrderItemID] INT          IDENTITY (1, 1) NOT NULL,
    [ItemID]      INT          NOT NULL,
    [Price]       DECIMAL (18) NOT NULL,
    CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED ([OrderItemID] ASC),
    CONSTRAINT [FK_OrderItem_Item] FOREIGN KEY ([ItemID]) REFERENCES [dbo].[Item] ([ItemID])
);

