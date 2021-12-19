CREATE TABLE [dbo].[Qualifications]
(
	[QualificationID] INT NOT NULL PRIMARY KEY,
	MainID INT NOT NULL REFERENCES [dbo].[Main](MainID),
	Description VARCHAR(MAX)
)
