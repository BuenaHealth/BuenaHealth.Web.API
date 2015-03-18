--POPULATE RACE

IF NOT EXISTS (SELECT * FROM [dbo].[Ethnicity] WHERE Name = 'American Indian or Alaskan Native')
BEGIN
	INSERT INTO [dbo].[Ethnicity](Name)
	VALUES('American Indian or Alaskan Native')  
END

IF NOT EXISTS (SELECT * FROM [dbo].[Ethnicity] WHERE Name = 'Asian or Pacific Islander')
BEGIN
	INSERT INTO [dbo].[Ethnicity](Name)
	VALUES('Asian or Pacific Islander')  
END

IF NOT EXISTS (SELECT * FROM [dbo].[Ethnicity] WHERE Name = 'Black')
BEGIN
	INSERT INTO [dbo].[Ethnicity](Name)
	VALUES('Black')  
END

IF NOT EXISTS (SELECT * FROM [dbo].[Ethnicity] WHERE Name = 'White')
BEGIN
	INSERT INTO [dbo].[Ethnicity](Name)
	VALUES('White')  
END