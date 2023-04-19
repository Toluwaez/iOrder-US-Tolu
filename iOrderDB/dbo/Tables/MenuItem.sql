CREATE TABLE [dbo].[MenuItem] (
    [MenuID] INT NOT NULL,
    [ItemID] INT NOT NULL,
    CONSTRAINT [PK_MenuItem] PRIMARY KEY CLUSTERED ([ItemID] ASC),
    CONSTRAINT [FK_MenuItem_Item] FOREIGN KEY ([ItemID]) REFERENCES [dbo].[Item] ([ItemID]),
    CONSTRAINT [FK_MenuItem_Menu] FOREIGN KEY ([MenuID]) REFERENCES [dbo].[Menu] ([MenuID])
);



