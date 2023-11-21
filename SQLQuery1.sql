CREATE TABLE Customer(
	[CustomerID] INT PRIMARY KEY,
	[CustomerName] VARCHAR(50),
	[CustomerEmail] VARCHAR(50),
	[CustomerPassword] VARCHAR(50),
	[CustomerGender] VARCHAR(6),
	[CustomerAddress] VARCHAR(100),
	[CustomerRole] VARCHAR(5)
)

CREATE TABLE Artist(
	[ArtistID] INT PRIMARY KEY,
	[ArtistName] VARCHAR(50),
	[ArtistImage] VARCHAR(50)
)

CREATE TABLE TransactionHeader(
	[TransactionID] INT PRIMARY KEY,
	[TransactionDate] DATE,
	[CustomerID] INT FOREIGN KEY REFERENCES Customer([CustomerID])
)

CREATE TABLE Album(
	[AlbumID] INT PRIMARY KEY,
	[ArtistID] INT FOREIGN KEY REFERENCES Artist([ArtistID]),
	[AlbumName] VARCHAR(50),
	[AlbumImage] VARCHAR(50),
	[AlbumStock] INT,
	[AlbumDescription] VARCHAR(255)
)

CREATE TABLE TransactionDetail(
	[TransactionID] INT FOREIGN KEY REFERENCES TransactionHeader([TransactionID]),
	[AlbumID] INT FOREIGN KEY REFERENCES Album([AlbumID]),
	[Quantity] INT,
	PRIMARY KEY ([TransactionID], [AlbumID])	
)

CREATE TABLE CART(
	[CustomerID] INT FOREIGN KEY REFERENCES Customer([CustomerID]),
	[AlbumID] INT FOREIGN KEY REFERENCES Album([AlbumID]),
	[Qty] INT,
	PRIMARY KEY ([CustomerID], [AlbumID])
)

