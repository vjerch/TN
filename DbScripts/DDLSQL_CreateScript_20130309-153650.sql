﻿
-- ----------------------------------------------------------------------------------------------------------------
-- Generated by LLBLGen Pro v3.5  Build: December 11th, 2012
-- SQL Server 2000/2005/2008/2008R2/2012/Express DDL Script generated from project: NinjaSoftware.TrzisteNovca
-- Project filename: G:\Documents\Visual Studio 2010\Projects\NinjaSoftware.TrzisteNovca\NinjaSoftware.TrzisteNovca.llblgenproj
-- Script generated on: 09-ožu-2013 15:36.50
--
-- This is a Create script for creating a NEW data model. If you want DDL SQL for updating an existing model,
-- please create an Update script instead. 
--
-- This script might create schemas, which requires you to assign a proper user to the schema. Adjust the CREATE SCHEMA
-- statements below, if any, to avoid errors at runtime. Schemas aren't dropped in the DROP section.
--
--      >>>>> WARNING <<<<<
--      This is a CREATE script, with DROP statements for the existing tables, foreign keys and other constraints
--      This means that existing tables, data, constraints and other elements in the catalog/schemas addressed
--      are deleted. Use this Create script only to create new schemas with tables/constraints and other elements.
--
-- ----------------------------------------------------------------------------------------------------------------
-- ###############################################################################################################
-- DROP statements for existing elements. 
-- ###############################################################################################################
-- DROP statements for dropping existing elements with the same names as the ones created are commented out below. 
-- If you want to enable these statements for DROPping the existing elements first (which will remove all the data
-- in these existing elements), uncomment these statements by removing the two comment markers /* and */

-- Remove the comment marker on the NEXT line to enable DROP statements to remove existing elements
/* 

USE [NinjaSoftwareTrzisteNovca]
GO
-- ----------------------------------------------------------------------------------------------------------------
-- DROP tables for schema 'dbo' 
-- ----------------------------------------------------------------------------------------------------------------

DROP TABLE [dbo].[AuditInfo]
GO

DROP TABLE [dbo].[AuditInfoActionTypeRo]
GO

DROP TABLE [dbo].[EntityRo]
GO

DROP TABLE [dbo].[Rok]
GO

DROP TABLE [dbo].[RokTipRo]
GO

DROP TABLE [dbo].[RoleRo]
GO

DROP TABLE [dbo].[TrgovanjeGlava]
GO

DROP TABLE [dbo].[TrgovanjeStavka]
GO

DROP TABLE [dbo].[User]
GO
*/
-- Remove the comment marker on the PREVIOUS line to enable DROP statements to remove existing elements

-- ###############################################################################################################
-- Create statements for catalogs, schemas, tables and sequences
-- ###############################################################################################################
-- ----------------------------------------------------------------------------------------------------------------
-- Catalog 'NinjaSoftwareTrzisteNovca'
-- ----------------------------------------------------------------------------------------------------------------

USE master
GO
CREATE DATABASE [NinjaSoftwareTrzisteNovca] /* ON PRIMARY (NAME=NinjaSoftwareTrzisteNovca_dat, FILENAME='c:\mycatalogs\NinjaSoftwareTrzisteNovca.mdf', SIZE=10MB) */
GO


USE [NinjaSoftwareTrzisteNovca]
GO
-- ----------------------------------------------------------------------------------------------------------------
-- Schema 'dbo'
-- ----------------------------------------------------------------------------------------------------------------

-- -------[ Tables ]-----------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[AuditInfo] 
(
	[ActionDateTime] [datetime] NOT NULL, 
	[AuditInfoActionTypeId] [bigint] NOT NULL, 
	[AuditInfoId] [bigint] IDENTITY (1,1) NOT NULL, 
	[ConcurrencyGuid] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[EntityId] [bigint] NOT NULL, 
	[JsonData] [nvarchar] (MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[PrimaryKeyValue] [bigint] NOT NULL, 
	[UserId] [bigint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[AuditInfoActionTypeRo] 
(
	[AuditInfoActionTypeId] [bigint] NOT NULL, 
	[Code] [nvarchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[Name] [nvarchar] (256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[EntityRo] 
(
	[Code] [nvarchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[EntityId] [bigint] NOT NULL, 
	[Name] [nvarchar] (256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Error] 
(
	[ConcurrencyGuid] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[ErrorDateTime] [datetime] NOT NULL, 
	[ErrorId] [bigint] NOT NULL, 
	[Message] [nvarchar] (MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[ParentErrorId] [bigint] NULL, 
	[StackTrace] [nvarchar] (MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Rok] 
(
	[ConcurrencyGuid] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[Naziv] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[RokId] [bigint] IDENTITY (1,1) NOT NULL, 
	[RokTipId] [bigint] NOT NULL, 
	[Sifra] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RokTipRo] 
(
	[Code] [nvarchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[Name] [nvarchar] (256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[RokTipId] [bigint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RoleRo] 
(
	[Code] [nvarchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[Name] [nvarchar] (256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[RoleId] [bigint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TrgovanjeGlava] 
(
	[ConcurrencyGuid] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[Datum] [datetime] NOT NULL, 
	[Komentar] [nvarchar] (MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, 
	[TrgovanjeGlavaId] [bigint] IDENTITY (1,1) NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TrgovanjeStavka] 
(
	[ConcurrencyGuid] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[Ponuda] [decimal] (18, 2) NOT NULL, 
	[PonudaDodatak] [decimal] (10, 4) NOT NULL, 
	[Potraznja] [decimal] (18, 2) NOT NULL, 
	[PotraznjaDodatak] [decimal] (10, 4) NOT NULL, 
	[Promet] [decimal] (18, 2) NOT NULL, 
	[PrometDodatak] [decimal] (10, 4) NOT NULL, 
	[RokId] [bigint] NOT NULL, 
	[TrgovanjeGlavaId] [bigint] NOT NULL, 
	[TrgovanjeStavkaId] [bigint] IDENTITY (1,1) NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[User] 
(
	[ConcurrencyGuid] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[Password] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[RoleId] [bigint] NOT NULL, 
	[UserId] [bigint] IDENTITY (1,1) NOT NULL, 
	[Username] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY]
GO

-- ###############################################################################################################
-- Create statements for Primary key constraints, Foreign key constraints and Unique constraints
-- ###############################################################################################################
-- ----------------------------------------------------------------------------------------------------------------
-- Catalog 'NinjaSoftwareTrzisteNovca'
-- ----------------------------------------------------------------------------------------------------------------

USE [NinjaSoftwareTrzisteNovca]
GO
-- ----------------------------------------------------------------------------------------------------------------
-- Primary Key constraints for schema 'dbo'
-- ----------------------------------------------------------------------------------------------------------------

ALTER TABLE [dbo].[AuditInfo] WITH NOCHECK 
	ADD CONSTRAINT [PK_5fbe1ce4206a3bfa45845343663] PRIMARY KEY CLUSTERED 
	( 
		[AuditInfoId] 
	) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AuditInfoActionTypeRo] WITH NOCHECK 
	ADD CONSTRAINT [PK_057e91646e3a0b69e685e56664f] PRIMARY KEY CLUSTERED 
	( 
		[AuditInfoActionTypeId] 
	) ON [PRIMARY]
GO

ALTER TABLE [dbo].[EntityRo] WITH NOCHECK 
	ADD CONSTRAINT [PK_6a8c30d43cbb48a28f4d88e9ae8] PRIMARY KEY CLUSTERED 
	( 
		[EntityId] 
	) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Error] WITH NOCHECK 
	ADD CONSTRAINT [PK_345c01a4dadaa2743b182e09867] PRIMARY KEY CLUSTERED 
	( 
		[ErrorId] 
	) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Rok] WITH NOCHECK 
	ADD CONSTRAINT [PK_ed3032145d7ae45e490ba4237cc] PRIMARY KEY CLUSTERED 
	( 
		[RokId] 
	) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RokTipRo] WITH NOCHECK 
	ADD CONSTRAINT [PK_9fb98c240df8f0aa09ec4ceaa3b] PRIMARY KEY CLUSTERED 
	( 
		[RokTipId] 
	) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RoleRo] WITH NOCHECK 
	ADD CONSTRAINT [PK_170de0f44939388fcb1bce06ff0] PRIMARY KEY CLUSTERED 
	( 
		[RoleId] 
	) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TrgovanjeGlava] WITH NOCHECK 
	ADD CONSTRAINT [PK_e70c3a9430685d1ef18a66c72b7] PRIMARY KEY CLUSTERED 
	( 
		[TrgovanjeGlavaId] 
	) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TrgovanjeStavka] WITH NOCHECK 
	ADD CONSTRAINT [PK_b48c25d42bbbd667ce3f02e792c] PRIMARY KEY CLUSTERED 
	( 
		[TrgovanjeStavkaId] 
	) ON [PRIMARY]
GO

ALTER TABLE [dbo].[User] WITH NOCHECK 
	ADD CONSTRAINT [PK_24218b24e158ab08eb275b53ab2] PRIMARY KEY CLUSTERED 
	( 
		[UserId] 
	) ON [PRIMARY]
GO
-- ----------------------------------------------------------------------------------------------------------------
-- Unique constraints for schema 'dbo'
-- ----------------------------------------------------------------------------------------------------------------
-- ----------------------------------------------------------------------------------------------------------------
-- All foreign Key constraints
-- ----------------------------------------------------------------------------------------------------------------

ALTER TABLE [dbo].[AuditInfo] 
	ADD CONSTRAINT [FK_56ed3d44496bd1deb89aebbd528] FOREIGN KEY
	(
		[EntityId] 
	)
	REFERENCES [dbo].[EntityRo]
	(
		[EntityId] 
	)
GO

ALTER TABLE [dbo].[AuditInfo] 
	ADD CONSTRAINT [FK_cde33334db28c14fa63323491b8] FOREIGN KEY
	(
		[AuditInfoActionTypeId] 
	)
	REFERENCES [dbo].[AuditInfoActionTypeRo]
	(
		[AuditInfoActionTypeId] 
	)
GO

ALTER TABLE [dbo].[AuditInfo] 
	ADD CONSTRAINT [FK_d1b51b94d6894675b65b18ccd0f] FOREIGN KEY
	(
		[UserId] 
	)
	REFERENCES [dbo].[User]
	(
		[UserId] 
	)
GO

ALTER TABLE [dbo].[Error] 
	ADD CONSTRAINT [FK_ab4fe0247e582ce86e6abe92334] FOREIGN KEY
	(
		[ParentErrorId] 
	)
	REFERENCES [dbo].[Error]
	(
		[ErrorId] 
	)
GO

ALTER TABLE [dbo].[Rok] 
	ADD CONSTRAINT [FK_fcddd17480fa6aeed58816a30e9] FOREIGN KEY
	(
		[RokTipId] 
	)
	REFERENCES [dbo].[RokTipRo]
	(
		[RokTipId] 
	)
GO

ALTER TABLE [dbo].[TrgovanjeStavka] 
	ADD CONSTRAINT [FK_2bce43e4429a1dd42d60a67a59c] FOREIGN KEY
	(
		[RokId] 
	)
	REFERENCES [dbo].[Rok]
	(
		[RokId] 
	)
GO

ALTER TABLE [dbo].[TrgovanjeStavka] 
	ADD CONSTRAINT [FK_5baa8394c8c809c80f23bdb291e] FOREIGN KEY
	(
		[TrgovanjeGlavaId] 
	)
	REFERENCES [dbo].[TrgovanjeGlava]
	(
		[TrgovanjeGlavaId] 
	)
GO

ALTER TABLE [dbo].[User] 
	ADD CONSTRAINT [FK_a36527a479ea6a74d40fc5b5244] FOREIGN KEY
	(
		[RoleId] 
	)
	REFERENCES [dbo].[RoleRo]
	(
		[RoleId] 
	)
GO