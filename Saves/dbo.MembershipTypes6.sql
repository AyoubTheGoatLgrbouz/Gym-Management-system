CREATE TABLE [dbo].[MembershipTypes] (
    [MembershipTypeID]   INT           IDENTITY (1, 1) NOT NULL,
    [MembershipTypeName] VARCHAR (50)  NULL,
    [Price]              INT           NULL,
    [Benefits]           VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([MembershipTypeID] ASC)
);

