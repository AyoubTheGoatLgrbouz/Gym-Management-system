CREATE TABLE [dbo].[Classes] (
    [ClassID]      INT           IDENTITY (1, 1) NOT NULL,
    [ClassName]    VARCHAR (100) NOT NULL,
    [InstructorID] INT           NOT NULL,
    [ClassDate]    DATE          NOT NULL,
    [StartTime]    TIME (7)      NOT NULL,
    [Duration]     INT           NOT NULL,
    [Capacity]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ClassID] ASC),
    FOREIGN KEY ([InstructorID]) REFERENCES [dbo].[Instructors] ([InstructorID])
);

