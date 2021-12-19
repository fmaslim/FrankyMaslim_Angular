CREATE TABLE [dbo].[ExperienceDescriptions]
(
	[ExperienceDescriptionID] INT NOT NULL PRIMARY KEY,
	ExperienceID INT NOT NULL REFERENCES [dbo].[Experiences](ExperienceID),
	Description VARCHAR(MAX)
)
