--POPULATE RACE

IF NOT EXISTS (SELECT * FROM [dbo].[Race] WHERE Name = 'American Indian or Alaskan Native')
BEGIN
	INSERT INTO [dbo].[Race](Name)
	VALUES('American Indian or Alaskan Native')  
END

IF NOT EXISTS (SELECT * FROM [dbo].[Race] WHERE Name = 'Asian or Pacific Islander')
BEGIN
	INSERT INTO [dbo].[Race](Name)
	VALUES('Asian or Pacific Islander')  
END

IF NOT EXISTS (SELECT * FROM [dbo].[Race]WHERE Name = 'Black')
BEGIN
	INSERT INTO [dbo].[Race](Name)
	VALUES('Black')  
END

IF NOT EXISTS (SELECT * FROM [dbo].[Race] WHERE Name = 'White')
BEGIN
	INSERT INTO [dbo].[Race](Name)
	VALUES('White')  
END