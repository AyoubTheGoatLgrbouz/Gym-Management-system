CREATE TABLE [dbo].[Membership]
(
	[Customer's Id] INT NOT NULL PRIMARY KEY, 
    [Surname] VARCHAR(50) NULL, 
    [Contact number] INT NULL, 
    [Start Date] DATE NULL, 
    [End Date] DATE NULL, 
    [Membership Type] VARCHAR(50) NULL, 
    [Payment Status] VARCHAR(50) NULL
)
