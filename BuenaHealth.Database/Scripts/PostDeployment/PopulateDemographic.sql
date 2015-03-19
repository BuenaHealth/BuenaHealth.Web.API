--INSERT INTO DEMOGRAPHIC TABLE


IF NOT EXISTS (SELECT * FROM [dbo].[Demographic] WHERE [UserId] = 1)
BEGIN
	INSERT INTO [dbo].[Demographic]([UserId]
		,[SexId]
		,[LanguageId]
		,[RaceId]
		,[EthnicityId])
	VALUES(1,1,1,1,1)  
END

IF NOT EXISTS (SELECT * FROM [dbo].[Demographic] WHERE [UserId] = 2)
BEGIN
	INSERT INTO [dbo].[Demographic]([UserId]
		,[SexId]
		,[LanguageId]
		,[RaceId]
		,[EthnicityId])
	VALUES(2,2,2,2,2)
END

IF NOT EXISTS (SELECT * FROM [dbo].[Demographic] WHERE [UserId] = 3)
BEGIN
	INSERT INTO [dbo].[Demographic]([UserId]
		,[SexId]
        ,[LanguageId]
        ,[RaceId]
        ,[EthnicityId])
	VALUES(3,2,1,3,3)  
END