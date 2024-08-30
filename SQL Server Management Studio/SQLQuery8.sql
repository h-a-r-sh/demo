CREATE database Triggerdb
use Triggerdb

create table admission
(
	rollno int primary key,
	qualification varchar(20),
	percentage12th decimal(5,3)
)
drop table admission
create table hostal
(
	hostalId int primary key,
	rollno int,
	hostalName varchar(20)
)


CREATE TRIGGER insert_admission_trigger
ON admission
for insert
AS
BEGIN
	declare @rno int
	declare @hId int
	declare @hName varchar(20)
	set @hId=105
	set @hName='Shivali'
	select @rno = i.rollno from inserted i 
	insert into hostal(hostalId,rollno,hostalName) values(@hId,@rno,@hName)
END
 
insert into admission (rollno, qualification, Percentage12th)
values ( 1, 'B.Tech', 89.00)

drop trigger insert_admission_trigger

select * from admission

select * from hostal

TRUNCATE table admission


insert into hostal values(106,2, 'shivali')


SELECT *
FROM admission
INNER JOIN hostal
ON admission.rollno = hostal.rollno;
