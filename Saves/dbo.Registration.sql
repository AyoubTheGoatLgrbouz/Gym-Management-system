CREATE TABLE [dbo].[Registration] (
    [Id]               INT           NOT NULL,
    [Username]        NVARCHAR (50) NULL,
    [Surname]          NVARCHAR (50) NULL,
    [Age]              NCHAR (10)    NULL,
    [Email]            NVARCHAR (50) NULL,
    [Password]         NCHAR (10)    NULL,
    [Confirm Password] NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

