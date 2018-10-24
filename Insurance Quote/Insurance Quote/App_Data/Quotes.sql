CREATE TABLE [dbo].[Table]
(
	[Id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
	[FirstName] VARCHAR(20) NOT NULL,
	[LastName] VARCHAR(20) NOT NULL,
	[EmailAddress] VARCHAR(50) NOT NULL,
	[Birthday] DateTime NOT NULL,
	[CarYear] INT NOT NULL,
	[CarMake] VARCHAR(20) NOT NULL,
	[CarModel] VARCHAR(20) NOT NULL,
	[DUI] BIT NOT NULL,
	[SpeedingTicket] INT NOT NULL,
	[Coverage] BIT NOT NULL,
	[QuoteAmount] DECIMAL NOT NULL
)
