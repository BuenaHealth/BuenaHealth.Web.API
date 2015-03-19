-- POPULATE PROFILEUSER

IF NOT EXISTS (SELECT * FROM  [dbo].[ProfileUser] WHERE [UserId] = 1)
BEGIN
	INSERT INTO  [dbo].[ProfileUser]([ProfileId], [UserId])
	VALUES(1,1)
END

IF NOT EXISTS (SELECT * FROM  [dbo].[ProfileUser] WHERE [UserId] = 2)
BEGIN
	INSERT INTO  [dbo].[ProfileUser]([ProfileId], [UserId])
	VALUES(2,2)
END