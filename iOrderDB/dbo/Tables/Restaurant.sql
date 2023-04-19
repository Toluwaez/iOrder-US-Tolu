CREATE TABLE [dbo].[Restaurant] (
    [RestaurantID] INT           IDENTITY (1, 1) NOT NULL,
    [UserID]       INT           NOT NULL,
    [Name]         VARCHAR (50)  NOT NULL,
    [Schedule]     VARCHAR (100) NOT NULL,
    [Email]        VARCHAR (50)  NOT NULL,
    [PhoneNumber]  VARCHAR (50)  NOT NULL,
    [Address]      VARCHAR (50)  NOT NULL,
    [CreatedOn]    DATETIME      NOT NULL,
    [Image]        VARCHAR (100) NULL,
    CONSTRAINT [PK_Restaurant] PRIMARY KEY CLUSTERED ([RestaurantID] ASC)
);



