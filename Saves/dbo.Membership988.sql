CREATE TABLE [dbo].[Membership] (
    [MemebrshipID]   INT          NOT NULL,
    [CustomerID]     INT          NULL,
    [MembershipType] VARCHAR (50) NULL,
    [StartDate]      DATE         NULL,
    [EndDate]        DATE         NULL,
    PRIMARY KEY CLUSTERED ([MemebrshipID] ASC)
);

