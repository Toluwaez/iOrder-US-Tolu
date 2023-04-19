CREATE TABLE [dbo].[Menu] (
    [MenuID]       INT          IDENTITY (1, 1) NOT NULL,
    [RestaurantID] INT          NOT NULL,
    [Name]         VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED ([MenuID] ASC),
    CONSTRAINT [FK_Menu_Restaurant] FOREIGN KEY ([RestaurantID]) REFERENCES [dbo].[Restaurant] ([RestaurantID])
);

