CREATE TABLE [dbo].[Membership] (
    [MemebrshipID]   INT          NOT NULL,
    [Username]     VARCHAR(50)          NULL,
    [MembershipType] VARCHAR (50) NULL,
    [StartDate]      DATE         NULL,
    [EndDate]        DATE         NULL,
    PRIMARY KEY CLUSTERED ([MemebrshipID] ASC)
);

