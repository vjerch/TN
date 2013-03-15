﻿
-- ----------------------------------------------------------------------------------------------------------------
-- Generated by LLBLGen Pro v3.5  Build: December 11th, 2012
-- SQL Server 2000/2005/2008/2008R2/2012/Express DDL Script generated from project: NinjaSoftware.TrzisteNovca
-- Project filename: G:\Documents\Visual Studio 2010\Projects\NinjaSoftware.TrzisteNovca\NinjaSoftware.TrzisteNovca.llblgenproj
-- Script generated on: 15-ožu-2013 13:34.13
--
-- This is an Update script for updating an existing data model to a newer version. If you want DDL SQL for a new model,
-- please create a Create script instead. 
--
-- This script might create schemas, which requires you to assign a proper user to the schema. Adjust the CREATE SCHEMA
-- statements below, if any, to avoid errors at runtime.
--
-- Please run the scripts in the right order, use the timestamp in the filename and inside this script for that.
-- This script might need adjustment in some statements. You should consider this script as a starting point for
-- upgrading the existing data model.
-- ----------------------------------------------------------------------------------------------------------------
-- ###############################################################################################################
-- Drop constraints referring to elements which are changed in this script (constraints are recreated later on)
-- ###############################################################################################################

--USE [TrzisteNovca]
--GO

-- ###############################################################################################################
-- Rename statements
-- ###############################################################################################################

--USE [NinjaSoftwareTrzisteNovca]
--GO

--EXEC sp_renamedb '[NinjaSoftwareTrzisteNovca]', 'TrzisteNovca'
--GO

-- ###############################################################################################################
-- DROP statements for elements no longer needed or replaced elements.
-- ###############################################################################################################

USE [TrzisteNovca]
GO

ALTER TABLE [dbo].[Rok] DROP CONSTRAINT [FK_fcddd17480fa6aeed58816a30e9]
GO

ALTER TABLE [dbo].[TrgovanjeStavka] DROP CONSTRAINT [FK_2bce43e4429a1dd42d60a67a59c]
GO

ALTER TABLE [dbo].[TrgovanjeStavka] DROP COLUMN [RokId]
GO

DROP TABLE [dbo].[Rok]
GO

DROP TABLE [dbo].[RokTipRo]
GO

-- ###############################################################################################################
-- ADD statements for new elements (except FK/UC)
-- ###############################################################################################################

USE [TrzisteNovca]
GO

CREATE TABLE [dbo].[TrgovanjeVrstaRo] 
(
	[Code] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[Name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[SifraSlog] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[TrgovanjeVrstaId] [bigint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ValutaRo] 
(
	[Code] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[Name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[SifraSlog] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL, 
	[ValutaId] [bigint] NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TrgovanjeStavka] 
	ADD [TrgovanjeVrstaId] [bigint] NOT NULL
GO

ALTER TABLE [dbo].[TrgovanjeStavka] 
	ADD [ValutaId] [bigint] NOT NULL
GO

-- ###############################################################################################################
-- ALTER statements for table fields and ADD statements for new primary key constraints
-- ###############################################################################################################

USE [TrzisteNovca]
GO

ALTER TABLE [dbo].[TrgovanjeVrstaRo] WITH NOCHECK 
	ADD CONSTRAINT [PK_3cca2ad49d385ff03e172ae6088] PRIMARY KEY CLUSTERED 
	( 
		[TrgovanjeVrstaId] 
	) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ValutaRo] WITH NOCHECK 
	ADD CONSTRAINT [PK_11cce9f433e95c5a2f16f294f4f] PRIMARY KEY CLUSTERED 
	( 
		[ValutaId] 
	) ON [PRIMARY]
GO

-- ###############################################################################################################
-- ADD statements for new foreign key constraints and unique constraints
-- ###############################################################################################################

USE [TrzisteNovca]
GO

ALTER TABLE [dbo].[TrgovanjeStavka] 
	ADD CONSTRAINT [FK_19da4ca4001a005135d8dfe21a6] FOREIGN KEY
	(
		[ValutaId] 
	)
	REFERENCES [dbo].[ValutaRo]
	(
		[ValutaId] 
	)
GO

ALTER TABLE [dbo].[TrgovanjeStavka] 
	ADD CONSTRAINT [FK_7b4eb684576806c575613e1514c] FOREIGN KEY
	(
		[TrgovanjeVrstaId] 
	)
	REFERENCES [dbo].[TrgovanjeVrstaRo]
	(
		[TrgovanjeVrstaId] 
	)
GO
