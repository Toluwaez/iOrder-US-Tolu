CREATE TABLE [dbo].[OrderDetail] (
    [OrderID]     INT NOT NULL,
    [OrderItemID] INT NOT NULL,
    CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Order] ([OrderID]),
    CONSTRAINT [FK_OrderDetail_OrderItem] FOREIGN KEY ([OrderItemID]) REFERENCES [dbo].[OrderItem] ([OrderItemID])
);

