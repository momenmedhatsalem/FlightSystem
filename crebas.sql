/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2022                    */
/* Created on:     04/05/2024 5:32:27 PM                        */
/*==============================================================*/

use FlightDB
if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOARDING') and o.name = 'FK_BOARDING_BOARDING_FLIGHT')
alter table BOARDING
   drop constraint FK_BOARDING_BOARDING_FLIGHT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOARDING') and o.name = 'FK_BOARDING_BOARDING2_PASSENGE')
alter table BOARDING
   drop constraint FK_BOARDING_BOARDING2_PASSENGE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_MANAGES_USER')
alter table BOOKING
   drop constraint FK_BOOKING_MANAGES_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SCHEMA_1.FLIGHT') and o.name = 'FK_FLIGHT_FROM_AIRPORT')
alter table SCHEMA_1.FLIGHT
   drop constraint FK_FLIGHT_FROM_AIRPORT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SCHEMA_1.FLIGHT') and o.name = 'FK_FLIGHT_HAS_AIRCRAFT')
alter table SCHEMA_1.FLIGHT
   drop constraint FK_FLIGHT_HAS_AIRCRAFT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SCHEMA_1.FLIGHT') and o.name = 'FK_FLIGHT_TO_AIRPORT')
alter table SCHEMA_1.FLIGHT
   drop constraint FK_FLIGHT_TO_AIRPORT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RESERVES') and o.name = 'FK_RESERVES_RESERVES_BOOKING')
alter table RESERVES
   drop constraint FK_RESERVES_RESERVES_BOOKING
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RESERVES') and o.name = 'FK_RESERVES_RESERVES2_FLIGHT')
alter table RESERVES
   drop constraint FK_RESERVES_RESERVES2_FLIGHT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TICKET') and o.name = 'FK_TICKET_GENERATES_BOOKING')
alter table TICKET
   drop constraint FK_TICKET_GENERATES_BOOKING
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRCRAFT')
            and   type = 'U')
   drop table AIRCRAFT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AIRPORT')
            and   type = 'U')
   drop table AIRPORT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOARDING')
            and   name  = 'BOARDING2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOARDING.BOARDING2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOARDING')
            and   name  = 'BOARDING_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOARDING.BOARDING_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOARDING')
            and   type = 'U')
   drop table BOARDING
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'MANAGES_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.MANAGES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOKING')
            and   type = 'U')
   drop table BOOKING
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SCHEMA_1.FLIGHT')
            and   name  = 'TO_FK'
            and   indid > 0
            and   indid < 255)
   drop index SCHEMA_1.FLIGHT.TO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SCHEMA_1.FLIGHT')
            and   name  = 'FROM_FK'
            and   indid > 0
            and   indid < 255)
   drop index SCHEMA_1.FLIGHT.FROM_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SCHEMA_1.FLIGHT')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index SCHEMA_1.FLIGHT.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SCHEMA_1.FLIGHT')
            and   type = 'U')
   drop table SCHEMA_1.FLIGHT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PASSENGER')
            and   type = 'U')
   drop table PASSENGER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RESERVES')
            and   name  = 'RESERVES2_FK'
            and   indid > 0
            and   indid < 255)
   drop index RESERVES.RESERVES2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RESERVES')
            and   name  = 'RESERVES_FK'
            and   indid > 0
            and   indid < 255)
   drop index RESERVES.RESERVES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RESERVES')
            and   type = 'U')
   drop table RESERVES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TICKET')
            and   name  = 'GENERATES_FK'
            and   indid > 0
            and   indid < 255)
   drop index TICKET.GENERATES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TICKET')
            and   type = 'U')
   drop table TICKET
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

drop schema SCHEMA_1
go

/*==============================================================*/
/* User: SCHEMA_1                                               */
/*==============================================================*/
create schema SCHEMA_1
go

/*==============================================================*/
/* Table: AIRCRAFT                                              */
/*==============================================================*/
create table AIRCRAFT (
   AIRCRAFTID           int                  IDENTITY(1,1)   not null,
   AIRCRAFTNAME         varchar(40)          not null,
   MANUFACTURER         varchar(40)          not null,
   CAPACITY             int                  not null,
   MODEL                varchar(6)           not null,
   constraint PK_AIRCRAFT primary key (AIRCRAFTID)
)
go

/*==============================================================*/
/* Table: AIRPORT                                               */
/*==============================================================*/
create table AIRPORT (
   AIRPORTID            int                  not null,
   AIRPORTNAME          varchar(40)          not null,
   IATACODE             int                  not null,
   CITY                 varchar(40)          not null,
   COUNTRY              varchar(25)          not null,
   constraint PK_AIRPORT primary key (AIRPORTID)
)
go

/*==============================================================*/
/* Table: BOARDING                                              */
/*==============================================================*/
create table BOARDING (
   FLI_FLIGHTID         int                  not null,
   PAS_PASSENGERID      int                  not null,
   constraint PK_BOARDING primary key (FLI_FLIGHTID, PAS_PASSENGERID)
)
go

/*==============================================================*/
/* Index: BOARDING_FK                                           */
/*==============================================================*/




create nonclustered index BOARDING_FK on BOARDING (FLI_FLIGHTID ASC)
go

/*==============================================================*/
/* Index: BOARDING2_FK                                          */
/*==============================================================*/




create nonclustered index BOARDING2_FK on BOARDING (PAS_PASSENGERID ASC)
go

/*==============================================================*/
/* Table: BOOKING                                               */
/*==============================================================*/
create table BOOKING (
   BOOKINGID            int                  IDENTITY(1,1)    not null,
   USE_USERID           int                  not null,
   BOOKINGSTATUS        varchar(40)          not null,
   BOOKINGTIME          datetime             not null,
   constraint PK_BOOKING primary key (BOOKINGID)
)
go

/*==============================================================*/
/* Index: MANAGES_FK                                            */
/*==============================================================*/




create nonclustered index MANAGES_FK on BOOKING (USE_USERID ASC)
go

/*==============================================================*/
/* Table: FLIGHT                                                */
/*==============================================================*/
create table SCHEMA_1.FLIGHT (
   FLIGHTID             int                  IDENTITY(1,1)    not null,
   AIR_AIRCRAFTID       int                  not null,
   DEPARTURE_AIRPORTID2 int                  not null,
   ARRIVAL_AIRPORTID2   int                  not null,
   AVAIABLESEATS        int                  not null,
   ARRIVALDATE          datetime             not null,
   DEPARTUREDATE        datetime             not null,
   FLIGHTDURATION       datetime             null,
   constraint PK_FLIGHT primary key (FLIGHTID)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on SCHEMA_1.FLIGHT (AIR_AIRCRAFTID ASC)
go

/*==============================================================*/
/* Index: FROM_FK                                               */
/*==============================================================*/




create nonclustered index FROM_FK on SCHEMA_1.FLIGHT (DEPARTURE_AIRPORTID2 ASC)
go

/*==============================================================*/
/* Index: TO_FK                                                 */
/*==============================================================*/




create nonclustered index TO_FK on SCHEMA_1.FLIGHT (ARRIVAL_AIRPORTID2 ASC)
go

/*==============================================================*/
/* Table: PASSENGER                                             */
/*==============================================================*/
create table PASSENGER (
   PASSENGERID          int                  IDENTITY(1,1)  not null,
   FIRSTNAME            varchar(25)          not null,
   LASTNAME             varchar(25)          not null,
   PHONE                varchar(16)          not null,
   constraint PK_PASSENGER primary key (PASSENGERID)
)
go

/*==============================================================*/
/* Table: RESERVES                                              */
/*==============================================================*/
create table RESERVES (
   BOO_BOOKINGID        int                  not null,
   FLI_FLIGHTID         int                  not null,
   constraint PK_RESERVES primary key (BOO_BOOKINGID, FLI_FLIGHTID)
)
go

/*==============================================================*/
/* Index: RESERVES_FK                                           */
/*==============================================================*/




create nonclustered index RESERVES_FK on RESERVES (BOO_BOOKINGID ASC)
go

/*==============================================================*/
/* Index: RESERVES2_FK                                          */
/*==============================================================*/




create nonclustered index RESERVES2_FK on RESERVES (FLI_FLIGHTID ASC)
go

/*==============================================================*/
/* Table: TICKET                                                */
/*==============================================================*/
create table TICKET (
   BOO_BOOKINGID        int                  not null,
   SEATNUMBER           int                  not null,
   TICKETCLASS          varchar(15)          not null,
   constraint PK_TICKET primary key (BOO_BOOKINGID, SEATNUMBER)
)
go

/*==============================================================*/
/* Index: GENERATES_FK                                          */
/*==============================================================*/




create nonclustered index GENERATES_FK on TICKET (BOO_BOOKINGID ASC)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   USERID               int                  IDENTITY(1,1)    not null,
   EMAIL                varchar(40)          not null,
   FIRSTNAME            varchar(25)          not null,
   LASTNAME             varchar(25)          not null,
   ISADMIN              bit                  not null,
   PASSWORD             varchar(64)          not null,
   PHONE                varchar(16)          null,
   constraint PK_USER primary key (USERID)
)
go

alter table BOARDING
   add constraint FK_BOARDING_BOARDING_FLIGHT foreign key (FLI_FLIGHTID)
      references SCHEMA_1.FLIGHT (FLIGHTID)
go

alter table BOARDING
   add constraint FK_BOARDING_BOARDING2_PASSENGE foreign key (PAS_PASSENGERID)
      references PASSENGER (PASSENGERID)
go

alter table BOOKING
   add constraint FK_BOOKING_MANAGES_USER foreign key (USE_USERID)
      references "USER" (USERID)
go

alter table SCHEMA_1.FLIGHT
   add constraint FK_FLIGHT_FROM_AIRPORT foreign key (DEPARTURE_AIRPORTID2)
      references AIRPORT (AIRPORTID)
go

alter table SCHEMA_1.FLIGHT
   add constraint FK_FLIGHT_HAS_AIRCRAFT foreign key (AIR_AIRCRAFTID)
      references AIRCRAFT (AIRCRAFTID)
go

alter table SCHEMA_1.FLIGHT
   add constraint FK_FLIGHT_TO_AIRPORT foreign key (ARRIVAL_AIRPORTID2)
      references AIRPORT (AIRPORTID)
go

alter table RESERVES
   add constraint FK_RESERVES_RESERVES_BOOKING foreign key (BOO_BOOKINGID)
      references BOOKING (BOOKINGID)
go

alter table RESERVES
   add constraint FK_RESERVES_RESERVES2_FLIGHT foreign key (FLI_FLIGHTID)
      references SCHEMA_1.FLIGHT (FLIGHTID)
go

alter table TICKET
   add constraint FK_TICKET_GENERATES_BOOKING foreign key (BOO_BOOKINGID)
      references BOOKING (BOOKINGID)
go

-- Inserting data into the AIRPORT table
INSERT INTO AIRPORT (AIRPORTID, AIRPORTNAME, IATACODE, CITY, COUNTRY) VALUES
(1, 'John F. Kennedy International Airport', 123, 'New York', 'USA'),
(2, 'Los Angeles International Airport', 456, 'Los Angeles', 'USA'),
(3, 'Heathrow Airport', 789, 'London', 'UK'),
(4, 'Charles de Gaulle Airport', 101, 'Paris', 'France'),
(5, 'Cairo International Airport', 222, 'Cairo', 'Egypt');
