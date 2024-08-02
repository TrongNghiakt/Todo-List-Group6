CREATE DATABASE ToDoListDB;

USE ToDoListDB;

CREATE TABLE Tasks (
    Id INT PRIMARY KEY IDENTITY(1,1),
    StartTime DATETIME ,
    Description NVARCHAR(MAX),
    EndTime DATETIME,
    Priority varchar(5),
	isChecked bit

);

 Create table FinishTask(
	id int primary key,
    StartTime DATETIME,
	EndTime DATETIME,
    Description NVARCHAR(MAX),
	Priority varchar(5)
	foreign key(id) references Tasks(id)
 );
insert Tasks(Description,StartTime,EndTime,Priority)
VALUES 
( 'Description for Task 1', '2024-07-30 09:00:00', '2024-07-30 11:00:00', 'I'),
('Description for Task 2', '2024-07-30 11:00:00', '2024-07-30 13:00:00', 'II'),
('Description for Task 3', '2024-07-30 14:00:00', '2024-07-30 16:00:00', 'III'),
('Description for Task 4', '2024-07-31 09:00:00', '2024-07-31 11:00:00', 'IV'),
('Description for Task 5', '2024-07-31 11:00:00', '2024-07-31 13:00:00', 'I'),
('Description for Task 6', '2024-07-31 14:00:00', '2024-07-31 16:00:00', 'I'),
('Description for Task 7', '2024-08-01 09:00:00', '2024-08-01 11:00:00', 'I'),
('Description for Task 8', '2024-08-01 11:00:00', '2024-08-01 13:00:00', 'I'),
('Description for Task 9', '2024-08-01 14:00:00', '2024-08-01 16:00:00', 'I'),
('Description for Task 10', '2024-08-02 09:00:00', '2024-08-02 11:00:00', 'I');

select * from Tasks