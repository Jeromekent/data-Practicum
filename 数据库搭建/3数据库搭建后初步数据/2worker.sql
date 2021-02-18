/*
SQLyog Ultimate v12.09 (64 bit)
MySQL - 5.5.40 
*********************************************************************
*/
/*!40101 SET NAMES utf8 */;

create table `worker` (
	`w_id` varchar (30),
	`w_name` varchar (30),
	`w_sex` varchar (3),
	`w_age` int (11),
	`w_telephone` varchar (45),
	`w_department` varchar (30),
	`w_post` varchar (9),
	`w_duty` varchar (30),
	`w_wage` int (11),
	`w_on_job` varchar (6)
); 
insert into `worker` (`w_id`, `w_name`, `w_sex`, `w_age`, `w_telephone`, `w_department`, `w_post`, `w_duty`, `w_wage`, `w_on_job`) values('1','Tom','男','27','123456789','1','管理岗','财务管理员','6000','在职');
insert into `worker` (`w_id`, `w_name`, `w_sex`, `w_age`, `w_telephone`, `w_department`, `w_post`, `w_duty`, `w_wage`, `w_on_job`) values('2','Jerry','男','45','789456123','2','普通岗','销售员','3000','在职');
insert into `worker` (`w_id`, `w_name`, `w_sex`, `w_age`, `w_telephone`, `w_department`, `w_post`, `w_duty`, `w_wage`, `w_on_job`) values('3','Lily','女','32','456312789','3','普通岗','招聘员','3500','在职');
insert into `worker` (`w_id`, `w_name`, `w_sex`, `w_age`, `w_telephone`, `w_department`, `w_post`, `w_duty`, `w_wage`, `w_on_job`) values('4','Amy','女','36','789132456','4','普通岗','程序员','4000','离职');
