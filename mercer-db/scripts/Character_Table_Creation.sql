CREATE TABLE dbo.Character(
    Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    CharacterName varchar(50) NOT NULL,
    ClassId int NOT NULL,
    CharacterLevel int NOT NULL,
    PlayerName varchar(50),
    RaceId int NOT NULL,
    AlignmentId int NOT NULL,
    CharacterHeight varchar(10), 
    CharcterWeight varchar(10),
    Speed int NOT NULL,
    ArmorClass int NOT NULL,
    MaxHitPoint int NOT NULL,
    CurrentHitPoint int NOT NULL
);

ALTER TABLE dbo.Character WITH CHECK ADD FOREIGN KEY(AlignmentId) REFERENCES dbo.Alignment (Id);
ALTER TABLE dbo.Character WITH CHECK ADD FOREIGN KEY(ClassId) REFERENCES dbo.Class (Id);
ALTER TABLE dbo.Character WITH CHECK ADD FOREIGN KEY(RaceId) REFERENCES dbo.CharacterRace (Id);