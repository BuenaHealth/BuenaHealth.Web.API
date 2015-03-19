-- POPULATE PROFILE

IF NOT EXISTS (SELECT * FROM [dbo].[Profile] WHERE [Name] = 'Rangel Profile')
BEGIN
	INSERT INTO [dbo].[Profile]([Name]
           ,[StatusId]
           ,[CreatedDate]
           ,[StartDate]
           ,[CreatedUserId])
	VALUES('Rangel Profile',1,GETDATE()-2,GETDATE(),1)
END


IF NOT EXISTS (SELECT * FROM [dbo].[Profile] WHERE [Name] = 'Hogg Profile')
BEGIN
	INSERT INTO [dbo].[Profile]([Name]
           ,[StatusId]
           ,[CreatedDate]
           ,[StartDate]
           ,[CreatedUserId])
	VALUES('Hogg Profile',2,GETDATE()-2,GETDATE(),2)
END


IF NOT EXISTS (SELECT * FROM [dbo].[Profile] WHERE [Name] = 'Bob Profile')
BEGIN
	INSERT INTO [dbo].[Profile]([Name]
           ,[StatusId]
           ,[CreatedDate]
           ,[StartDate]
           ,[CreatedUserId])
	VALUES('Bob Profile',3,GETDATE()-2,GETDATE(),3)
END
