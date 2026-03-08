
--creating EventDb Databse
CREATE DATABASE EventDb;

-- using the database
USE EventDb;
GO

-- creating UserInfo Table
CREATE TABLE UserInfo (
  EmailId varchar(50) PRIMARY KEY, -- UNIQUE and NOT NULL

  UserName varchar(50) NOT NULL ,

  Role varchar(20) NOT NULL CHECK(Role IN ('Admin','Participant')), -- checking whether Admin or Participant

  Password varchar(20) NOT NULL CHECK(LEN(Password) BETWEEN 6 AND 20) -- checking length of password must be b/w 6 and 20
);

-- creating EventDetails Table
CREATE TABLE EventDetails (
    EventId INT PRIMARY KEY,

    EventName VARCHAR(50) NOT NULL CHECK (LEN(EventName) BETWEEN 1 AND 50),-- checking length of event name 

    EventCategory VARCHAR(50) NOT NULL CHECK (LEN(EventCategory) BETWEEN 1 AND 50), -- checking length of event category

    EventDate DATETIME NOT NULL,

    Description VARCHAR(255) NULL,

    Status VARCHAR(20) NOT NULL CHECK (Status IN ('Active','In-Active')) -- checking status whether it's Active or In-Active
);

-- creating SpeakersDetails Table
CREATE TABLE SpeakersDetails (
    SpeakerId INT PRIMARY KEY,
    SpeakerName VARCHAR(50) NOT NULL);

-- creating SessionInfo Table
CREATE TABLE SessionInfo (
    SessionId INT PRIMARY KEY,
    EventId INT NOT NULL,
    SessionTitle varchar(50) NOT NULL,
    SpeakerId INT NOT NULL,
    Description varchar(100),
    SessionStart DATETIME NOT NULL,
    SessionEnd DATETIME NOT NULL,
    SessionUrl varchar(100)

    CONSTRAINT FK_Session_Event 
        FOREIGN KEY(EventId) REFERENCES EventDetails(EventId), -- Foreign Key to ensure each session belongs to an existing event

    CONSTRAINT FK_Session_Speaker 
        FOREIGN KEY(SpeakerId) REFERENCES SpeakersDetails(SpeakerId) -- Foreign Key to ensure each session is assigned to a valid speaker
);

-- creating ParticipantEventDetails Table
CREATE TABLE ParticipantEventDetails (
    Id INT PRIMARY KEY,
    ParticipantEmailId varchar(50) NOT NULL,
    EventId INT NOT NULL,
    SessionId INT NOT NULL,
    IsAttended BIT NOT NULL CHECK(IsAttended IN(0,1)) -- Indicates whether the participant attended the session (1 = Yes, 0 = No)
);
-- inserting values into UserInfo Table
INSERT INTO UserInfo VALUES
('admin@gmail.com', 'AdminUser', 'Admin', 'adminuser'), 
('ravi@gmail.com', 'Ravi', 'Participant', 'ravixyz');

-- inserting values into EventDetails Table
INSERT INTO EventDetails VALUES 
(1,'Tech Talks', 'Technology', '2026-03-16', 'Talk about Trending Tech Stacks', 'Active' ),
(2, 'Workshop', 'IT', '2026-02-22', 'Training regarding some useful techniques', 'In-Active');

-- inserting values into SpeakersDetails Table
INSERT INTO SpeakersDetails VALUES 
(101, 'Dr.Sharma'),
(102, 'Rama Dutt');

-- inserting values into SessionInfo Table
INSERT INTO SessionInfo VALUES
(1001,1, 'AI Trends', 101, 'Discussion on AI', '2026-03-16 10:00:00', '2026-03-16 12:00:00', 'http://sessionlink.com');

-- inserting values into ParticipantEventDetails Table
INSERT INTO ParticipantEventDetails VALUES
(1,'ravi@gmail.com', 1, 1001, 1);

-- retrieving the UserInfo detailss
select * from UserInfo;

-- retrieving the EventDetails 
select * from EventDetails;

-- retieving the SpeakersDetails
select * from SpeakersDetails;

-- retreiving the SessionInfo Details
select * from SessionInfo;

-- retreiving the ParticipantEventDetails
select * from ParticipantEventDetails;