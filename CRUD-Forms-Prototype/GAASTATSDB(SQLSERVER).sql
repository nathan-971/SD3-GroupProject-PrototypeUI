-- Create the database
CREATE DATABASE gaastatsdb;
GO

USE gaastatsdb;
GO

-- Drop the table if it exists
IF OBJECT_ID('action', 'U') IS NOT NULL
    DROP TABLE action;
GO

-- Create 'action' table
CREATE TABLE action (
    A_ID int NOT NULL PRIMARY KEY,
    A_Title varchar(45) NOT NULL,
    A_IsPositive smallint NOT NULL,
    A_Deleted smallint NOT NULL
);
GO

-- Drop 'game' table if it exists
IF OBJECT_ID('game', 'U') IS NOT NULL
    DROP TABLE game;
GO

-- Create 'game' table
CREATE TABLE game (
    G_ID int NOT NULL PRIMARY KEY,
    G_StartTime datetime2(0) NULL,
    G_EndTime datetime2(0) NULL,
    G_Deleted smallint NOT NULL
);
GO

-- Drop 'team' table if it exists
IF OBJECT_ID('team', 'U') IS NOT NULL
    DROP TABLE team;
GO

-- Create 'team' table
CREATE TABLE team (
    T_ID int NOT NULL PRIMARY KEY,
    T_Name varchar(45) NOT NULL,
    T_Deleted smallint NOT NULL
);
GO

-- Drop 'teamgame' table if it exists
IF OBJECT_ID('teamgame', 'U') IS NOT NULL
    DROP TABLE teamgame;
GO

-- Create 'teamgame' table
CREATE TABLE teamgame (
    TG_Team int NOT NULL,
    TG_Game int NOT NULL,
    TG_Deleted smallint NOT NULL,
    PRIMARY KEY (TG_Team, TG_Game),
    CONSTRAINT FK_G FOREIGN KEY (TG_Game) REFERENCES game (G_ID) ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT FK_T FOREIGN KEY (TG_Team) REFERENCES team (T_ID) ON DELETE NO ACTION ON UPDATE NO ACTION
);

-- Drop 'zone' table if it exists
IF OBJECT_ID('zone', 'U') IS NOT NULL
    DROP TABLE zone;
GO

-- Drop 'playerpositiion' table if it exists (Correct the spelling to 'playerposition')
IF OBJECT_ID('playerpositiion', 'U') IS NOT NULL
    DROP TABLE playerpositiion;
GO

-- Create 'playerposition' table (Corrected to 'playerposition')
CREATE TABLE playerposition (
    PP_ID int NOT NULL PRIMARY KEY,
    PP_Title varchar(45) NOT NULL,
    PP_Deleted smallint NOT NULL
);
GO

-- Create 'zone' table
CREATE TABLE zone (
    Z_ID int NOT NULL PRIMARY KEY,
    Z_Title varchar(45) NOT NULL
);
GO

-- Drop 'jerseynumber' table if it exists
IF OBJECT_ID('jerseynumber', 'U') IS NOT NULL
    DROP TABLE jerseynumber;
GO

-- Create 'jerseynumber' table
CREATE TABLE jerseynumber (
    JN_ID int NOT NULL PRIMARY KEY,
    JN_Title varchar(45) NOT NULL
);
GO

-- Drop 'playeraction' table if it exists
IF OBJECT_ID('playeraction', 'U') IS NOT NULL
    DROP TABLE playeraction;
GO

-- Drop 'role' table if it exists
IF OBJECT_ID('role', 'U') IS NOT NULL
    DROP TABLE role;
GO

-- Create 'role' table
CREATE TABLE role (
    R_ID int NOT NULL PRIMARY KEY,
    R_Title varchar(45) NULL,
    R_Deleted smallint NOT NULL
);


-- Create indexes for 'teamgame'
CREATE INDEX fk_Team_has_Game_Game1_idx ON teamgame (TG_Game);
CREATE INDEX fk_Team_has_Game_Team1_idx ON teamgame (TG_Team);
GO

-- Drop 'user' table if it exists
IF OBJECT_ID('user', 'U') IS NOT NULL
    DROP TABLE [user];
GO

-- Create 'user' table
CREATE TABLE [user] (
    U_ID int NOT NULL PRIMARY KEY,
    U_Name varchar(45) NOT NULL,
    U_Email varchar(45) NOT NULL,
    U_Team int NULL,
    U_Role int NOT NULL,
    U_Position int NULL,
    U_JerseyNumber int NOT NULL,
    U_Deleted smallint NOT NULL,
    CONSTRAINT FK_JN FOREIGN KEY (U_JerseyNumber) REFERENCES jerseynumber (JN_ID) ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT FK_PP FOREIGN KEY (U_Position) REFERENCES playerposition (PP_ID) ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT FK_R FOREIGN KEY (U_Role) REFERENCES role (R_ID) ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT FK_Team FOREIGN KEY (U_Team) REFERENCES team (T_ID) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO

-- Create indexes for 'user'
CREATE INDEX FK_JN_idx ON [user] (U_JerseyNumber);
CREATE INDEX FK_R_idx ON [user] (U_Role);
CREATE INDEX FK_PP_idx ON [user] (U_Position);
CREATE INDEX FK_Team_idx ON [user] (U_Team);

-- Create 'playeraction' table
CREATE TABLE playeraction (
    PA_ID int NOT NULL PRIMARY KEY,
    PA_User int NOT NULL,
    PA_Action int NOT NULL,
    PA_Zone int NOT NULL,
    PA_Deleted smallint NOT NULL,
    CONSTRAINT FK_A FOREIGN KEY (PA_Action) REFERENCES action (A_ID) ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT FK_U FOREIGN KEY (PA_User) REFERENCES [user] (U_ID) ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT FK_Z FOREIGN KEY (PA_Zone) REFERENCES zone (Z_ID) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO

-- Create indexes for 'playeraction'
CREATE INDEX FK_Z_idx ON playeraction (PA_Zone);
CREATE INDEX FK_A_idx ON playeraction (PA_Action);
CREATE INDEX FK_U_idx ON playeraction (PA_User);
GO
