CREATE TABLE [dbo].[TechnicalSkills] (
    [TechnicalSkillID] INT PRIMARY KEY,
    TechnicalSkillName VARCHAR(100) NOT NULL,
	TechnicalSkillCategoryID INT REFERENCES [dbo].[TechnicalSkillCategories](TechnicalSkillCategoryID) NOT NULL
);

