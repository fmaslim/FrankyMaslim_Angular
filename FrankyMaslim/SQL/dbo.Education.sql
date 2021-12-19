CREATE TABLE [dbo].[Education] (
    [EducationID] INT PRIMARY KEY,
    EducationName VARCHAR(100) NOT NULL,
	CollegeName VARCHAR(100) NOT NULL,
	StartDate VARCHAR(50) NOT NULL,
	EndDate VARCHAR(50),
	Notes VARCHAR(1000)
);

