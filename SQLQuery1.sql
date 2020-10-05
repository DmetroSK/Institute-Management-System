create database Login;
use Login;
create table loginDetails(UserName varchar(20) primary key ,Password varchar(15) );
insert into loginDetails values('admin','admin'); 
select * from loginDetails;
insert into loginDetails values(0,0); 