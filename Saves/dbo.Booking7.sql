CREATE TABLE [dbo].[Booking] (
    [BookingID]   INT  IDENTITY (1, 1) NOT NULL,
    [ClassID]     INT  NULL,
    [CustomerID]  INT  NULL,
    [BookingDate] DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([BookingID] ASC)
);

