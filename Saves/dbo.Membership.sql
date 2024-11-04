CREATE TABLE [dbo].[Membership]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Customer's ID] NCHAR(10) NULL, 
    [Surname] VARCHAR(50) NULL, 
    [Contact Number] INT NULL, 
    [Start Day] DATE NULL, 
    [End Day] DATE NULL, 
    [membership type ] VARCHAR(50) NULL, 
    [Payment Status] VARCHAR(50) NULL
)
