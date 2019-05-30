
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/08/2019 20:16:49
-- Generated from EDMX file: C:\Users\ercan\source\Arastirmalarim\EFCodefirst\ModelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Sergen];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[CRM].[FK_CRM_Adresler_dbo_Musteriler_refMusteriId]', 'F') IS NOT NULL
    ALTER TABLE [CRM].[Adresler] DROP CONSTRAINT [FK_CRM_Adresler_dbo_Musteriler_refMusteriId];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[CRM].[Adresler]', 'U') IS NOT NULL
    DROP TABLE [CRM].[Adresler];
GO
IF OBJECT_ID(N'[dbo].[__MigrationHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[__MigrationHistory];
GO
IF OBJECT_ID(N'[dbo].[ils]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ils];
GO
IF OBJECT_ID(N'[dbo].[Musteriler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Musteriler];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'KisiSet'
CREATE TABLE [dbo].[KisiSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ad] nvarchar(max)  NOT NULL,
    [soyad] nvarchar(max)  NOT NULL,
    [Dtarihi] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Adresler'
CREATE TABLE [dbo].[Adresler] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Adres1] nvarchar(100)  NULL,
    [Adres2] nvarchar(100)  NULL,
    [il] nvarchar(15)  NULL,
    [ilce] nvarchar(15)  NULL,
    [PostaKodu] nvarchar(10)  NULL,
    [refMusteriId] int  NOT NULL
);
GO

-- Creating table 'C__MigrationHistory'
CREATE TABLE [dbo].[C__MigrationHistory] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ContextKey] nvarchar(300)  NOT NULL,
    [Model] varbinary(max)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'ils'
CREATE TABLE [dbo].[ils] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Sehir] nvarchar(max)  NULL,
    [PlakaKodu] nvarchar(max)  NULL,
    [TelefonKodu] nvarchar(max)  NULL
);
GO

-- Creating table 'Musteriler'
CREATE TABLE [dbo].[Musteriler] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ad] nvarchar(30)  NOT NULL,
    [Soyad] nvarchar(30)  NOT NULL,
    [Unvan] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'KisiSet'
ALTER TABLE [dbo].[KisiSet]
ADD CONSTRAINT [PK_KisiSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Adresler'
ALTER TABLE [dbo].[Adresler]
ADD CONSTRAINT [PK_Adresler]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [MigrationId], [ContextKey] in table 'C__MigrationHistory'
ALTER TABLE [dbo].[C__MigrationHistory]
ADD CONSTRAINT [PK_C__MigrationHistory]
    PRIMARY KEY CLUSTERED ([MigrationId], [ContextKey] ASC);
GO

-- Creating primary key on [Id] in table 'ils'
ALTER TABLE [dbo].[ils]
ADD CONSTRAINT [PK_ils]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Musteriler'
ALTER TABLE [dbo].[Musteriler]
ADD CONSTRAINT [PK_Musteriler]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [refMusteriId] in table 'Adresler'
ALTER TABLE [dbo].[Adresler]
ADD CONSTRAINT [FK_CRM_Adresler_dbo_Musteriler_refMusteriId]
    FOREIGN KEY ([refMusteriId])
    REFERENCES [dbo].[Musteriler]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CRM_Adresler_dbo_Musteriler_refMusteriId'
CREATE INDEX [IX_FK_CRM_Adresler_dbo_Musteriler_refMusteriId]
ON [dbo].[Adresler]
    ([refMusteriId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------