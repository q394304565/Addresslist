/*==============================================================*/
/* Database name:  CLM                                          */
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     14-8-14 15:45:47                             */
/*==============================================================*/


drop database CLM
go

/*==============================================================*/
/* Database: CLM                                                */
/*==============================================================*/
create database CLM
go

use CLM
go

/*==============================================================*/
/* Table: TB_ContactPerson                                      */
/*==============================================================*/
create table TB_ContactPerson (
   Id                   int                  identity(1,1) not for replication,
   Name                 nvarchar(50)         null,
   UType                int                  not null,
   Sex                  int                  null default 0,
   Birthday             nvarchar(50)         null,
   Callphone            nvarchar(20)         null,
   Telephone            nvarchar(20)         null,
   EMail                nvarchar(50)         null,
   Address              nvarchar(100)        null,
   Favicon              image                null,
   UId                  int                  not null,
   Deleted              bit                  not null default 0,
   constraint PK_TB_CONTACTPERSON primary key (Id)
)
go

/*==============================================================*/
/* Table: TB_ContactPersonGroup                                 */
/*==============================================================*/
create table TB_ContactPersonGroup (
   Id                   int                  identity(1,1) not for replication,
   Name                 nvarchar(50)         not null,
   ParentId             int                  not null default 0,
   UId                  int                  not null,
   Deleted              bit                  not null default 0,
   constraint PK_TB_CONTACTPERSONGROUP primary key (Id)
)
go

/*==============================================================*/
/* Table: TB_Gallery                                            */
/*==============================================================*/
create table TB_Gallery (
   Id                   int                  identity(1,1) not for replication,
   Name                 nvarchar(100)        not null,
   GImage               image                not null,
   UId                  int                  not null,
   Deleted              bit                  not null default 0,
   constraint PK_TB_GALLERY primary key (Id)
)
go

/*==============================================================*/
/* Table: TB_User                                               */
/*==============================================================*/
create table TB_User (
   Id                   int                  identity(1,1) not for replication,
   UName                nvarchar(20)         not null,
   Name                 nvarchar(20)         not null,
   Password             nvarchar(20)         not null,
   Sex                  int                  null default 0,
   Birthday             nvarchar(50)         null,
   Callphone            nvarchar(20)         null,
   TelePhone            nvarchar(20)         null,
   Email                nvarchar(50)         null,
   Address              nvarchar(100)        null,
   Favicon              image                null,
   UType                int                  not null default 0,
   Deleted              bit                  not null default 0,
   constraint PK_TB_USER primary key (Id)
)
go

