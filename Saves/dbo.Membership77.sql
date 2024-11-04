CREATE TABLE [dbo].[Membership] (
    [MemebrshipID]   INT           IDENTITY (1, 1) NOT NULL,
    [Username]       VARCHAR (MAX) NULL,
    [MembershipType] VARCHAR (50)  NULL,
    [StartDate]      DATE          NULL,
    [IsActive]        BIT          NULL DEFAULT 0,
    PRIMARY KEY CLUSTERED ([MemebrshipID] ASC)
);

