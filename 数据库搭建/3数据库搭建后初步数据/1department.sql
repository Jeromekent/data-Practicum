/*
SQLyog Ultimate v12.09 (64 bit)
MySQL - 5.5.40 
*********************************************************************
*/
/*!40101 SET NAMES utf8 */;

create table `department` (
	`d_id` varchar (15),
	`d_name` varchar (30)
); 
insert into `department` (`d_id`, `d_name`) values('1','财务部');
insert into `department` (`d_id`, `d_name`) values('2','销售部');
insert into `department` (`d_id`, `d_name`) values('3','人力部');
insert into `department` (`d_id`, `d_name`) values('4','行政部');
insert into `department` (`d_id`, `d_name`) values('5','工程部');
