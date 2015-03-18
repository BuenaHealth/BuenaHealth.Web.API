CREATE TABLE [dbo].[Language] (
	[LanguageId] BIGINT         IDENTITY (1, 1) NOT NULL,
	[Name]     NVARCHAR (100) NOT NULL,
	[ts]       rowversion     NOT NULL,
	PRIMARY KEY CLUSTERED ([LanguageId] ASC)
);