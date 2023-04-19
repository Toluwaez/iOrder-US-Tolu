CREATE TABLE [dbo].[CustomerContactDetail] (
    [CustomerID]  INT          NOT NULL,
    [Email]       VARCHAR (50) NULL,
    [PhoneNumber] VARCHAR (50) NULL,
    [Address]     VARCHAR (50) NULL,
    CONSTRAINT [FK_CustomerContactDetail_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([CustomerID])
);

