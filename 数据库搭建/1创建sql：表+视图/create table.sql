drop table if exists Attendance;

drop table if exists Business;

drop table if exists OffWork;

drop table if exists Overtime;

drop table if exists Worker;

drop table if exists department;

/*==============================================================*/
/* Table: Attendance                                            */
/*==============================================================*/
create table Attendance
(
   att_num              int not null auto_increment,
   w_id                 int,
   att_start_time       datetime,
   att_end_time         datetime,
   att_absence          ENUM ('迟到','早退','旷工','正常'),
   primary key (att_num)
);

/*==============================================================*/
/* Table: Business                                              */
/*==============================================================*/
create table Business
(
   bus_num              int not null auto_increment,
   w_id                 int,
   bus_start_time       datetime,
   bus_end_time         datetime,
   bus_duration         float,
   primary key (bus_num)
);

/*==============================================================*/
/* Table: OffWork                                               */
/*==============================================================*/
create table OffWork
(
   off_num              int not null auto_increment,
   w_id                 int,
   off_start_time       datetime,
   off_end_time         datetime,
   off_duration         float,
   primary key (off_num)
);

/*==============================================================*/
/* Table: Overtime                                              */
/*==============================================================*/
create table Overtime
(
   over_num             int not null auto_increment,
   w_id                 int,
   over_start_time      datetime,
   over_end_time        datetime,
   over_duration        float,
   primary key (over_num)
);

/*==============================================================*/
/* Table: Worker                                                */
/*==============================================================*/
create table Worker
(
   w_id                 int not null auto_increment,
   w_name               varchar(10),
   w_sex                ENUM ('男','女'),
   w_age                int,
   w_telephone          varchar(15),
   w_department         int,
   w_post               ENUM ('管理岗','普通岗'),
   w_duty               varchar(10),
   w_wage               int,
   w_on_job             ENUM ('在职','离职'),
   primary key (w_id)
);

/*==============================================================*/
/* Table: department                                            */
/*==============================================================*/
create table department
(
   d_id                 int not null auto_increment,
   d_name               varchar(10),
   primary key (d_id)
);

alter table Attendance add constraint FK_Reference_5 foreign key (w_id)
      references Worker (w_id) on delete restrict on update restrict;

alter table Business add constraint FK_Reference_4 foreign key (w_id)
      references Worker (w_id) on delete restrict on update restrict;

alter table OffWork add constraint FK_Reference_3 foreign key (w_id)
      references Worker (w_id) on delete restrict on update restrict;

alter table Overtime add constraint FK_Reference_2 foreign key (w_id)
      references Worker (w_id) on delete restrict on update restrict;

alter table Worker add constraint FK_Reference_1 foreign key (w_department)
      references department (d_id) on delete restrict on update restrict;

