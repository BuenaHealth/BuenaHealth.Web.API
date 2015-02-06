CREATE TABLE [dbo].[Demographic] (
	[DemographicId] BIGINT         IDENTITY (1, 1) NOT NULL,
	[Name]     NVARCHAR (100) NOT NULL,
	[SexId] BIGINT         NOT NULL,
	[LanguageId] BIGINT         NOT NULL,
	[RaceId] BIGINT         NOT NULL,
	[EthnicityId] BIGINT         NOT NULL,
	[ts]       rowversion     NOT NULL,
	PRIMARY KEY CLUSTERED ([DemographicId] ASC)
	FOREIGN KEY ([SexId]) REFERENCES [dbo].Sex ([SexId]),
	FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Language] ([LanguageId]),
	FOREIGN KEY ([RaceId]) REFERENCES [dbo].[Race] ([RaceId])
	FOREIGN KEY ([EthnicityId]) REFERENCES [dbo].[Ethnicity] ([EthnicityId])
);