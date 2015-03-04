declare @statusId int, 
		@profileId int,
		@userId int

IF NOT EXISTS (SELECT * FROM [User] WHERE Username = 'bhogg')
	INSERT INTO [dbo].[User] ([FirstName],[LastName],[UserName])
	VALUES(N'Boss',N'Hogg',N'bhogg')


IF NOT EXISTS (select * from [User] where Username = 'jbob')
	INSERT into [dbo].[User] ([Firstname], [Lastname], [Username]) 
		VALUES (N'Jim', N'Bob', N'jbob')

IF NOT EXISTS (select * from [User] where Username = 'jdoe')
	INSERT into [dbo].[User] ([Firstname], [Lastname], [Username]) 
		VALUES (N'John', N'Doe', N'jdoe')

IF NOT EXISTS (select * from [dbo].[Profile] where Subject = 'Test Task')
begin
	select top 1 @statusId = StatusId from Status order by StatusId;
	select top 1 @userId = UserId from [User] order by UserId;

	insert into dbo.Profile(Subject, StartDate, StatusId, CreatedDate, CreatedUserId)
		values('Test Task', getdate(), @statusId, getdate(), @userId);

	set @profileId = SCOPE_IDENTITY();
	
	INSERT [dbo].[ProfileUser] ([ProfileId], [UserId]) 
		VALUES (@profileId, @userId)
end
	