CREATE TABLE [dbo].[Ethnicity] (
	[EthnicityId] BIGINT         IDENTITY (1, 1) NOT NULL,
	[Name]     NVARCHAR (100) NOT NULL,
	[ts]       rowversion     NOT NULL,
	PRIMARY KEY CLUSTERED ([EthnicityId] ASC)
);