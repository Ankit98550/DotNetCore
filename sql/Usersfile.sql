--create database usertbl

use usertbl

create table users(id int primary key identity,name nvarchar(200),Gender nvarchar(200),age nvarchar(200),Email nvarchar(200),password nvarchar(200))

insert into users values('ankit','male',22,'ankit@revclerx.com','ankit@A')
insert into users values('Kalu','male',22,'kalu@revclerx.com','Kalu@A')

select * from users