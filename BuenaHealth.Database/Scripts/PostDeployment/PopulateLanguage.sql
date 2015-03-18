--POPULATE LANGAUGES

IF NOT EXISTS (SELECT * FROM [dbo].[Language] WHERE NAME = 'English')
BEGIN
	INSERT INTO [dbo].[Language](Name)
	VALUES('English')
END

IF NOT EXISTS (SELECT * FROM [dbo].[Language] WHERE NAME = 'Spanish')
BEGIN
	INSERT INTO [dbo].[Language](Name)
	VALUES('Spanish')
END