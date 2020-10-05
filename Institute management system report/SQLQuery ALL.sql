create database RITdb;

use RITdb;

select * from student;
drop table student;

create table student(stu_ID varchar(12),stu_reg_no varchar(8),stu_name varchar(30),stu_NIC bigint,tel bigint,address varchar(30),email varchar(30),dob date,qualification varchar(50),G_name varchar(30),G_tel bigint,batch varchar(5),course_ID varchar(8),primary key(stu_ID,stu_reg_no) );
insert into student values('ST20171P001','RIT001','Erandi Fernando',9633248774,714486331,'Boralesgamuwa','erandifreando90@gmail.com','1997-03-01','GCE A/L,GCE O/L','Renuka Fernando',0714486331,'17.1','DCSD');
insert into student values('ST20171P002','RIT002','Chanuka Perera',962324837946,778934826,'Nugegoda','chanukaperera70@gmail.com','1996-06-23','GCE A/L,GCE O/L,AAT','Nandana Perera',717799642,'17.1','DSE');
insert into student values('ST20171P003','RIT003','Saduni Gamage',971237548765,714239750,'Kaluthara','sanduni786@gmail.com','1996-07-3','GCE A/L,GCE O/L','Nalin Gamage',717799633,'17.1','DSE');
insert into student values('ST20171P004','RIT004','Lakmal Abeysinghe',981276479876,764050137,'Gampaha','lakmalabesinhge@gmail.com','1996-04-30','GCE A/L,GCE O/L','Ruwan Abeysinghe',717769665,'17.1','DCSD');
insert into student values('ST20171P005','RIT005','Hashani Samaranayaka',966587643567,784453997,'Kurunagala','hasani@gmail.com','1996-04-2','GCE A/L,GCE O/L','Jayath Samaranayake',717710642,'17.1','DCSD');
insert into student values('ST20171P006','RIT006','Dasun Nawagamuwa',969567456345,724697341,'Kaluthara','dasun98@gmail.com','1996-04-4','GCE A/L,GCE O/L,AAT','Deepika Nawagamuwa',717788842,'17.1','DSE');
insert into student values('ST20171P007','RIT007','Ayesha Perera',969356479745,112813167,'Gampaha','ayesha89@gmail.com','1996-05-23','GCE A/L,GCE O/L,AAT','Gangani Perera',717790002,'17.1','DCN');
insert into student values('ST20171P008','RIT008','Ranuka Balasuriya',982369303748,112562789,'Kurunagala','ranukabalasuriya@gmail.com','1998-07-23','GCE A/L,GCE O/L','Ramesh Balasuriya',778899642,'17.1','DCSD');
insert into student values('ST20171P009','RIT009','Gayan Nanayakkara',927890348567,754739752,'Panadura','gayannanayakkara@gmail.com','1995-05-02','GCE A/L,GCE O/L','M.Mohomed',717790992,'17.1','DSE');
insert into student values('ST20171P010','RIT010','Sadani Bandara',960923763487,754039761,'Boralesgamuwa','sandanibandaara@gmail.com','1998-09-27','GCE A/L,GCE O/L,AAT','Jayarathna Nanayakkara',712356642,'17.1','DCSD');
select * from student;
drop table student;
delete from student where stu_ID='DD'  ;

create table attendence(stu_ID varchar(12),module_code varchar(15),attendence int,primary key (stu_ID,module_code));
insert into attendence values('ST20171P001','INTRO',80);
insert into attendence values('ST20171P001','GAD',75);
insert into attendence values('ST20171P001','SAD',85);
insert into attendence values('ST20171P001','OOP',89);
insert into attendence values('ST20171P001','DBMS',90);
insert into attendence values('ST20171P005','INTRO',100);
insert into attendence values('ST20171P001','QTC',84);
insert into attendence values('ST20171P002','INTRO',70);
insert into attendence values('ST20171P003','INTRO',95);
insert into attendence values('ST20171P004','INTRO',78);
select*from attendence;
delete from attendence where stu_ID='ST2'  ;

create table exam_result(stu_ID varchar(12),module_code varchar(15),results char(3),batch varchar(5),course_code varchar(10),date date ,primary key (stu_ID,course_code,module_code));
Insert into exam_result values('ST20171P001','INTRO','A','17.1','DCSD','2018-05-13');
Insert into exam_result values('ST20171P002','GAD','A+','17.1','DCN','2018-05-14');
Insert into exam_result values('ST20171P003','SAD','B','17.1','DSE','2018-05-15');
Insert into exam_result values('ST20171P004','OOP','B-','17.1','DCSD','2018-05-13');
Insert into exam_result values('ST20171P005','DBMS','A-','17.1','DCSD','2018-05-14');
Insert into exam_result values('ST20171P006','INTRO','A+','17.1','DSE','2018-05-15');
Insert into exam_result values('ST20171P007','QTC','B','17.1','DCN','2018-05-13');
Insert into exam_result values('ST20171P008','INTRO','B+','17.1','DCSD','2018-05-14');
Insert into exam_result values('ST20171P009','INTRO','A','17.1','DSE','2018-05-15');
Insert into exam_result values('ST20171P010','INTRO','A','17.1','DCSD','2018-05-13');
select * from exam_result;
drop table payment;
delete from exam_result where stu_ID='ST001'  ;

create table payment(pay_code varchar(10),pay_amount decimal(10,2),pay_method varchar(10),stu_ID varchar(12),batch varchar(5),stu_reg_no varchar(10),pay_date date,primary key (pay_code));
Insert into payment values('P001',200000.00,'CARD','ST20171P001','17.1','RIT001','2018-05-13');
Insert into payment values('P002',200000.00,'CARD','ST20171P002','17.1','RIT002','2018-05-14');
Insert into payment values('P003',200000.00,'CARD','ST20171P003','17.1','RIT003','2018-05-15');
Insert into payment values('P004',200000.00,'CARD','ST20171P004','17.1','RIT004','2018-05-16');
Insert into payment values('P005',200000.00,'CARD','ST20171P005','17.1','RIT005','2018-05-17');
Insert into payment values('P006',200000.00,'CARD','ST20171P006','17.1','RIT006','2018-05-18');
Insert into payment values('P007',200000.00,'CARD','ST20171P007','17.1','RIT007','2018-05-18');
Insert into payment values('P008',200000.00,'CARD','ST20171P008','17.1','RIT008','2018-05-18');
Insert into payment values('P009',200000.00,'CARD','ST20171P009','17.1','RIT009','2018-05-19');
Insert into payment values('P010',200000.00,'CARD','ST20171P010','17.1','RIT010','2018-05-20');
select*from payment;
delete from payment where pay_code='123'  ;
drop table payment;

create table signup(stu_ID varchar(12),pay_code varchar(10),email varchar(60),password varchar(10),primary key(stu_ID));
insert into signup values('ST20171P001','P0001','erandi@gmail.com','0');
insert into signup values('ST20171P002','P0002','chanukaperera70@gmail.com','1');
insert into signup values('ST20171P003','P0003','sanduni786@gmail.com','2');
insert into signup values('ST20171P004','P0004','lakmalabesinhge@gmail.com','3');
insert into signup values('ST20171P005','P0005','hasani@gmail.com','4');
insert into signup values('ST20171P006','P0006','dasun98@gmail.com','5');
insert into signup values('ST20171P007','P0007','ayesha89@gmail.com','6');
insert into signup values('ST20171P008','P0008','ranukabalasuriya@gmail.com','7');
insert into signup values('ST20171P009','P0009','gayannanayakkara@gmail.com','8');
insert into signup values('ST20171P010','P0010','sandanibandaara@gmail.com','9');
select * from signup;
drop table signup;

create table course(course_ID varchar(15) ,course_name varchar(50), primary key(course_ID));
insert into course values('DCSD','DIPLOMA IN COMPUTER SYSTEM DESIGN');
insert into course values('DCN','DIPLOMA IN COMPUTER NETWORK');
insert into course values('DSE','DIPLOMA IN SOFTWARE ENGINEERING');
select * from course;

create table stu__course(stu_ID varchar(12),course_ID varchar(15),  primary key(stu_ID,course_ID));
insert into stu__course values('ST20171P001','DSCD');
insert into stu__course values('ST20171P002','DSE');
insert into stu__course values('ST20171P003','DSE');
insert into stu__course values('ST20171P004','DSCD');
insert into stu__course values('ST20171P005','DSCD');
insert into stu__course values('ST20171P006','DSE');
insert into stu__course values('ST20171P007','DCN');
insert into stu__course values('ST20171P008','DSCD');
insert into stu__course values('ST20171P009','DSE');
insert into stu__course values('ST20171P010','DSCD');

create table module(module_code varchar(50),module_name varchar(50),course_ID varchar(15), primary key(module_code,course_ID));
Insert into module values('INTRO','INTRODUCTION TO COMPUTER SCIENCE','DCSD');
Insert into module values('GAD','GUI APPLICATION DEVELOPMENT','DSE');
Insert into module values('SAD','SYSTEM ANALYS AND DESIGN','DSE');
Insert into module values('OOP','OBJECT ORIENTED PROGRAMMING','DCSD');
Insert into module values('DBMS','DATABASE MANAGEMENT SYSTEM','DCSD');
Insert into module values('INTRO','INTRODUCTION TO COMPUTER SCIENCE','DSE');
Insert into module values('QTC','QUANTITY TECHNIQUE FOR COMPUTING','DCN');
Insert into module values('INTRO','INTRODUCTION TO COMPUTER SCIENCE','HNDCSD');
Insert into module values('INTRO','INTRODUCTION TO COMPUTER SCIENCE','HNDSE');
Insert into module values('INTRO','INTRODUCTION TO COMPUTER SCIENCE','HNDCN');
select * from module;

create table lec_shedule(Date date ,Batch varchar(10),Morning_Lecture varchar(30),Afternoon_Lecture varchar(30),course_ID varchar(15), primary key(Date,Batch));
select * from lec_shedule;
insert into lec_shedule values('2018-05-13','17.1','Mr.Prabath','Mrs.Gayani','DCSD');
insert into lec_shedule values('2018-05-14','17.2','Mr.Prabath','Mrs.Gayani','DSE');
insert into lec_shedule values('2018-05-15','17.1','Mrs.Gayani','Mrs.Gayani','DSE');
insert into lec_shedule values('2018-05-16','17.2','Mr.Prabath','Mr.Prabath','DCSD');
insert into lec_shedule values('2018-05-17','17.1','Mr.amila','Mrs.Gayani','DCSD');
insert into lec_shedule values('2018-05-18','17.2','Mr.Prabath','Mrs.Gayani','DSE');
insert into lec_shedule values('2018-05-19','17.1','Mr.Prabath','Mr.Amila','DCN');
insert into lec_shedule values('2018-05-20','17.2','Mr.Prabath','Mrs.Gayani','DCSD');
insert into lec_shedule values('2018-05-21','17.1','Mrs.Gayani','Mrs.Gayani','DSE');
insert into lec_shedule values('2018-05-22','17.2','Mr.Prabath','Mrs.Gayani','DCSD');

create table stu_shedule(lec_date date ,batch varchar(10),course_ID varchar(15),m_lec_module varchar(30),a_lec_module varchar(30),primary key(lec_date,batch,course_ID));
insert into stu_shedule values('2018-05-13','17.2','DCSD','OOP','GAD');
insert into stu_shedule values('2018-05-14','17.2','DSE','OOP','GAD');
insert into stu_shedule values('2018-05-15','17.2','DSE','GAD','GAD');
insert into stu_shedule values('2018-05-16','17.2','DCSD','OOP','OOP');
insert into stu_shedule values('2018-05-17','17.2','DCSD','CO','SAD');
insert into stu_shedule values('2018-05-18','17.2','DSE','CO','SAD');
insert into stu_shedule values('2018-05-19','17.2','DCN','SAD','CO');
insert into stu_shedule values('2018-05-20','17.2','DCSD','CO','SAD');
insert into stu_shedule values('2018-05-21','17.2','DSE','GAD','SAD');
insert into stu_shedule values('2018-05-22','17.2','DCSD','OOP','SAD');
drop table stu_shedule;
select * from stu_shedule;
delete from stu_shedule where lec_date='2018-05-13'  ;

create table staff(staff_ID varchar(12),name varchar(40),department varchar(20),email varchar(30),join_date date,qualification varchar(100), primary key(staff_ID));
insert into staff values('LE200801','Mr.Prabath','Lecture','prabath@gmail.com','2008-05-07','Bsc');
insert into staff values('LE200802','Mrs.Gayani','Lecture','gayani@gmail.com','2008-05-08','Bsc');
insert into staff values('LE200803','Mr.Amila','Lecture','amila@gmail.com','2008-05-09','Bsc');
select * from staff;
drop table staff;

create table login(username varchar(12) primary key,password varchar(10));
insert into login values('ST','0');
insert into login values('LE','0');
insert into login values('AC','0');
insert into login values('EX','0');
insert into login values('MI','0');
select * from login;
delete from login where username='ST20171P001';
select * from login;

create table exam_dates(course_ID varchar(15),batch varchar(10),module_code varchar(50),Date date,primary key(course_ID,batch,module_code));
insert into exam_dates values('DSE','17.2','SAD','2018-05-08');
insert into exam_dates values('DCN','17.2','GAD','2018-05-10');
insert into exam_dates values('DCSD','17.2','OOP','2018-05-13');
insert into exam_dates values('DSE','17.2','CO','2018-05-16');
insert into exam_dates values('DCSD','17.2','QTC','2018-05-20');
insert into exam_dates values('DCN','17.1','INTRO','2018-05-23');
insert into exam_dates values('DCSD','17.1','DBMS','2018-05-27');
select *from exam_dates;
delete from exam_dates where course_ID='DSE';

