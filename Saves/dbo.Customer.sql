CREATE TABLE [dbo].[Customer]
(
	[CustomerID] INT NOT NULL PRIMARY KEY, 
    [Username] VARCHAR(50) NOT NULL, 
    [Fullname] VARCHAR(50) NOT NULL, 
    [Age] INT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NULL, 
    [PostCode] VARCHAR(50) NULL, 
    [Sex] VARCHAR(50) NULL, 
    [ContactNumber] INT NOT NULL, 
   
)
