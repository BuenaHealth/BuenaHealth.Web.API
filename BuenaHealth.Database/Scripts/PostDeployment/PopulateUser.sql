--POPULATE USE

IF NOT EXISTS (SELECT * FROM [dbo].[User] WHERE Username = 'erangel')
BEGIN
	INSERT INTO [dbo].[User]([Firstname]
           ,[Lastname]
           ,[Username])
	VALUES('Eddie','Rangel','erangel')
END


IF NOT EXISTS (SELECT * FROM [dbo].[User] WHERE Username = 'bhogg')
BEGIN
	INSERT INTO [dbo].[User]([Firstname]
           ,[Lastname]
           ,[Username])
	VALUES ('Boss', 'Hogg', 'bhogg')
END


IF NOT EXISTS (SELECT * FROM [dbo].[User] WHERE Username = 'jbob')
BEGIN
	INSERT INTO [dbo].[User]([Firstname]
           ,[Lastname]
           ,[Username])
	VALUES('Jim', 'Bob', 'jbob')
END


IF NOT EXISTS (SELECT * FROM [dbo].[User] WHERE Username = 'jdoe')
BEGIN
	INSERT INTO [dbo].[User]([Firstname]
           ,[Lastname]
           ,[Username])
	VALUES('John', 'Doe', 'jdoe')
END