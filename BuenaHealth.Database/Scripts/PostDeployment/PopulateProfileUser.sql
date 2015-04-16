-- POPULATE PROFILEUSER

IF NOT EXISTS (SELECT * FROM  [dbo].[ProfileUser] WHERE [UserId] = 1)
BEGIN
	INSERT INTO  [dbo].[ProfileUser]([ProfileId], [UserId])
	VALUES(4,1)
END

IF NOT EXISTS (SELECT * FROM  [dbo].[ProfileUser] WHERE [UserId] = 2)
BEGIN
	INSERT INTO  [dbo].[ProfileUser]([ProfileId], [UserId])
	VALUES(5,2)
END