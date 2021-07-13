CREATE TABLE [dbo].[tblPayPeriods]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Date] DATETIME NOT NULL, 
    [RO] VARCHAR(6) NOT NULL, 
    [LaborTime] VARCHAR(4) NOT NULL
)
