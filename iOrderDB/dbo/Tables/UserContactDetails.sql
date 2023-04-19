CREATE TABLE [dbo].[UserContactDetails] (
    [UserID]      INT          NOT NULL,
    [Email]       VARCHAR (50) NULL,
    [PhoneNumber] VARCHAR (50) NULL,
    [Address]     VARCHAR (50) NULL,
    CONSTRAINT [FK_UserContactDetails_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([UserID])
);

