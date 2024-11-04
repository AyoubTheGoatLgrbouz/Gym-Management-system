CREATE TABLE [dbo].[Membership] (
    [MemebrshipID]   INT           IDENTITY (1, 1) NOT NULL,
    [Username]       VARCHAR (MAX) NULL,
    [MembershipType] VARCHAR (50)  NULL,
    [StartDate]      DATE          NULL,
    [EndDate]        DATE          NULL,
    [IsActive]       BIT           DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([MemebrshipID] ASC)
);

