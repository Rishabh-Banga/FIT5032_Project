--creating table 'Customer'
CREATE TABLE [dbo].[Customer]
(
	[Cust_Id] INT IDENTITY(1,1) NOT NULL,
	[FirstName] nvarchar(max) NOT NULL,
	[LastName] nvarchar(max) NOT NULL,
	[Email] nvarchar(max) NOT NULL,
	[Mob_no] INT NOT NULL,
	[Lic_no] INT NOT NULL,
	PRIMARY KEY (Cust_Id)

)

--creating table 'Booking'
CREATE TABLE [dbo].[Booking]
(
	[Book_Id] INT IDENTITY(1,1) NOT NULL,
	[FirstName] nvarchar(max) NOT NULL,
	[LastName] nvarchar(max) NOT NULL,
	[Email] nvarchar(max) NOT NULL,
	[Mob_no] INT NOT NULL,
	[Lic_no] INT NOT NULL,
	PRIMARY KEY (Cust_Id)

)
