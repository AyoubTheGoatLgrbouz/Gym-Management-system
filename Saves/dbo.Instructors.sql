CREATE TABLE [dbo].[Instructors] (
    [InstructorID]   INT           IDENTITY (1, 1) NOT NULL,
    [InstructorName] VARCHAR (100) NOT NULL,
    [Specialization] VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([InstructorID] ASC)
);

