CREATE TABLE [dbo].[ItemCategory] (
    [CategoryID] INT NOT NULL,
    [ItemID]     INT NOT NULL,
    CONSTRAINT [FK_ItemCategory_Category] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[Category] ([CategoryID]),
    CONSTRAINT [FK_ItemCategory_Item] FOREIGN KEY ([ItemID]) REFERENCES [dbo].[Item] ([ItemID])
);

