DROP TABLE dbo.Player;
CREATE TABLE Player(
    Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    firstname varchar(50) NOT NULL,
    lastname varchar(50) NOT NULL,
    email varchar(50) NOT NULL,
    username varchar(25) NOT NULL,
    created datetime NOT NULL,
    active bit NOT NULL
);