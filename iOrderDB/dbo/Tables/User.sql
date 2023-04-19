CREATE TABLE [dbo].[User] (
    [UserID]     INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (50)  NOT NULL,
    [LastName]   VARCHAR (50)  NOT NULL,
    [Salt]       VARCHAR (25)  NOT NULL,
    [Password]   VARCHAR (300) NOT NULL,
    [LastLogged] DATETIME      NOT NULL,
    [Role]       INT           NOT NULL,
    [Username]   VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserID] ASC)
);



