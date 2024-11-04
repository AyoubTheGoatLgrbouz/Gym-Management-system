CREATE TABLE [dbo].[Registration] (
    [Username]      VARCHAR (50) NULL,
    [Fullname]      VARCHAR (50) NULL,
    [Age]           INT          NULL,
    [Email]         VARCHAR (50) NULL,
    [Password]      VARCHAR (50) NULL,
    [PostCode]      VARCHAR (50) NULL,
    [Sex]           VARCHAR (50) NULL,
    [ContactNumber] INT          NULL, 
    [CustomerID] INT NOT NULL, 
    CONSTRAINT [PK_Registration] PRIMARY KEY ([CustomerID])
);

