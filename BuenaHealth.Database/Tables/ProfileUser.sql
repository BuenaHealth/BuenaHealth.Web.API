CREATE TABLE [dbo].[ProfileUser]
(
	[ProfileId] bigint NOT NULL,
	[UserId] bigint not null,
	[ts] rowversion not null,
	primary key (ProfileId, UserId),
	foreign key (UserId) references dbo.[User] (UserId),
	foreign key (ProfileId) references [dbo].[Profile] (ProfileId) 
)
go

create index ix_ProfileUser_UserId on ProfileUser(UserId)
go