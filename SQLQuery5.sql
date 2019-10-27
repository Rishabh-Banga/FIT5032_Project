--creating table "Customer"
CREATE TABLE [dbo].[Customer]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [FirstName] NVARCHAR(MAX) NOT NULL,
	[LastName] NVARCHAR(MAX) NOT NULL,
	[CustEmail] NVARCHAR(MAX) NOT NULL,
	[LicNo] INT NOT NULL,
	[PhNo] INT NOT NULL,
	[CustId] NVARCHAR(MAX) NOT NULL 
	PRIMARY KEY (Id)
);
GO

--creating table "Car"
CREATE TABLE [dbo].[Car]
(
	[CarId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [CarName] NVARCHAR(MAX) NOT NULL,
	[CarModel] NVARCHAR(MAX) NOT NULL,
	[CarManDate] DATE NOT NULL,
	[CarPrice] INT NOT NULL,
	[CarMinKm] INT NOT NULL,
	[CarNoSeat] INT NOT NULL,
	[CarNo] INT NOT NULL
);
GO

--creating table "Booking"
CREATE TABLE [dbo].[Booking]
(
	[BookId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [BookFrom] DATE NOT NULL,
	[BookTo] DATE NOT NULL
);
GO

--creating table "Payment"
CREATE TABLE [dbo].[Payment]
(
	--[CustId] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(MAX) NOT NULL,
	[LastName] NVARCHAR(MAX) NOT NULL,
	[CustEmail] NVARCHAR(MAX) NOT NULL,
	[LicNo] INT NOT NULL,
	[PhNo] INT NOT NULL
);
GO
