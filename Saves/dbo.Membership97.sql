CREATE TABLE [dbo].[Membership] (
    [Customer's Id]   INT          NOT NULL,
    [Surname]         VARCHAR (50) NULL,
    [ContactNumber]  INT          NULL,
    [StartDate]      DATE         NULL,
    [EndDate]        DATE         NULL,
    [MembershipType] VARCHAR (50) NULL,
    [PaymentStatus]  VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Customer's Id] ASC)
);

