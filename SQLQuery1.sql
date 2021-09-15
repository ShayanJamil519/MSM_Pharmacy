create database pharmacy1

create table users(
id int identity(1,1) primary key,
userRole varchar(50) not null,
name varchar(250) not null,
dob varchar(250) not null,
mobile bigint not null,
email varchar(250) not null,
username varchar(250) unique not null,
pass varchar(250) not null
)
insert into users values('Administrator', 'Maaz', 'Thursday October 31, 2020', 12334, 'Adil@gmail.com', 'maaz', 'maaz')

delete from users

select * from users

create table medicc(
id int identity(1,1) primary key,
mid varchar(250) not null,
mname varchar(250) not null,
mnumber varchar(250) not null,
mDate varchar(250) not null,
eDate varchar(250) not null,
quantity bigint not null,
perUnit bigint not null
);


insert into medicc values ('123456', 'cbc', 'D500', '7/7/2011', '4/14/2022', 140, 200)
insert into medicc values ('34521', 'abc', 'abc', '10/1/2020', '2/16/2021', 6, 250)
insert into medicc values ('123', 'acd', 'gh78', '10/1/2020', '7/13/2020', 6, 452)
insert into medicc values ('512', 'p200', '552336', '6/23/2020', '5/20/2021', 150, 25)
insert into medicc values ('5555', 'N30', '456321', '7/14/2020', '3/24/2022', 603, 243)
insert into medicc values ('11111', 'xyz', '123456', '6/9/2020', '1/14/2021', 160, 167)



select * from medicc

select * from medicc where eDate >= getdate()
