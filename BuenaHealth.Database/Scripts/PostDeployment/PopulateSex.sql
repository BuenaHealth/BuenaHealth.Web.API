--POPULATE SEX

IF NOT EXISTS (SELECT * FROM [dbo].[Sex] WHERE Name = 'Male')
BEGIN
	INSERT INTO [dbo].[Sex](Name)
	VALUES('Male')
END


IF NOT EXISTS (SELECT * FROM [dbo].[Sex] WHERE Name = 'Female')
BEGIN
	INSERT INTO [dbo].[Sex](Name)
	VALUES('Female')
END


IF NOT EXISTS (SELECT * FROM [dbo].[Sex] WHERE Name = 'Transgender')
BEGIN
	INSERT INTO [dbo].[Sex](Name)
	VALUES('Transgender')
END