DROP TABLE dbo.Class;
CREATE TABLE dbo.Class (
    Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    ClassName varchar(25),
    HitDie varchar(3)
);