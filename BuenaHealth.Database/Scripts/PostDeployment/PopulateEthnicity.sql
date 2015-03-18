--POPULATE ETHNICITY

IF NOT EXISTS (SELECT * FROM [dbo].[Ethnicity] WHERE Name = 'Mexican')
BEGIN
	INSERT INTO [dbo].[Ethnicity](Name)
	VALUES('Mexican')  
END

IF NOT EXISTS (SELECT * FROM [dbo].[Ethnicity] WHERE Name = 'Hispanic origin')
BEGIN
	INSERT INTO [dbo].[Ethnicity](Name)
	VALUES('Hispanic origin')
END

IF NOT EXISTS (SELECT * FROM [dbo].[Ethnicity] WHERE Name = 'Not of Hispanic origin')
BEGIN
	INSERT INTO [dbo].[Ethnicity](Name)
	VALUES('Not of Hispanic origin')  
END