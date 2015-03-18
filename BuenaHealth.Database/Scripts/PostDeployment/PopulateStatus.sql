--POPULATE STATUS

IF NOT EXISTS (SELECT * FROM [dbo].[Status] WHERE Name = 'Not Statrted')
BEGIN
	INSERT INTO [dbo].[Status](Name, Ordinal)
	VALUES('Not Started', 0)
END

IF NOT EXISTS (SELECT * FROM [dbo].[Status] WHERE Name = 'In Progress')
BEGIN
	INSERT INTO [dbo].[Status](Name, Ordinal)
	VALUES('In Progress', 1)
END

IF NOT EXISTS (SELECT * FROM [dbo].[Status] WHERE Name = 'Completed')
BEGIN
	INSERT INTO [dbo].[Status](Name, Ordinal)
	VALUES('Completed', 2)
END
