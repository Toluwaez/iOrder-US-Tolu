CREATE TABLE [dbo].[Item] (
    [ItemID]    INT           IDENTITY (1, 1) NOT NULL,
    [Image]     VARCHAR (150) NULL,
    [Name]      VARCHAR (50)  NOT NULL,
    [Price]     DECIMAL (18)  NOT NULL,
    [Available] BIT           NOT NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([ItemID] ASC)
);

