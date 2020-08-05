CREATE TABLE dbo.SubClass(
    Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    SubClassName varchar(255),
    ClassId int NOT NULL
);
ALTER TABLE dbo.SubClass WITH CHECK ADD FOREIGN KEY(ClassId) REFERENCES dbo.Class (Id);