
-- Run this file in sql management server to make the database and tables
-- Then Run Some Data Insertion.sql file to insert some data

CREATE DATABASE SmartCorporate;
GO
USE SmartCorporate;


-- HUB
CREATE TABLE Hub
(
    hub_id INT IDENTITY(1,1) PRIMARY KEY,
    district_location VARCHAR(255) NOT NULL,
    architectural_layout VARCHAR(255) NOT NULL
);

-- WORKSPACE
CREATE TABLE Workspace
(
    workspace_id INT IDENTITY(1,1) PRIMARY KEY,
    hub_id INT NOT NULL,
    type VARCHAR(100) NOT NULL,
    rate DECIMAL(10,2) NOT NULL
);

-- MEMBER
CREATE TABLE Member
(
    member_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    corporate_affiliation VARCHAR(255)
);

-- EQUIPMENT
CREATE TABLE Equipment
(
    equipment_id INT IDENTITY(1,1) PRIMARY KEY,
    type VARCHAR(100) NOT NULL
);

-- RESERVATION
CREATE TABLE Reservation
(
    reservation_id INT IDENTITY(1,1) PRIMARY KEY,
    member_id INT NOT NULL,
    workspace_id INT NOT NULL,
	equipment_id INT NOT NULL,
    rate DECIMAL(10,2) NOT NULL,
    reservation_date DATETIME NOT NULL
);



ALTER TABLE Workspace
ADD CONSTRAINT FK_Workspace_Hub
FOREIGN KEY (hub_id)
REFERENCES Hub(hub_id);


ALTER TABLE Reservation
ADD CONSTRAINT FK_Reservation_Member
FOREIGN KEY (member_id)
REFERENCES Member(member_id);


ALTER TABLE Reservation
ADD CONSTRAINT FK_Reservation_Workspace
FOREIGN KEY (workspace_id)
REFERENCES Workspace(workspace_id);

ALTER TABLE Reservation
ADD CONSTRAINT FK_Reservation_Equipment
FOREIGN KEY (equipment_id)
REFERENCES Equipment(equipment_id);
