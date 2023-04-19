CREATE TABLE [dbo].[Customer] (
    [CustomerID] INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (50)  NOT NULL,
    [LastName]   VARCHAR (50)  NOT NULL,
    [Salt]       VARCHAR (25)  NOT NULL,
    [Password]   VARCHAR (300) NOT NULL,
    [LastLogged] DATETIME      NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);

