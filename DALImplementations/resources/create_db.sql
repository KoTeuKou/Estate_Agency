﻿USE [master]
GO

/****** Object:  Database [Estate_Agency]    Script Date: 30.09.2020 18:15:28 ******/
CREATE DATABASE [Estate_Agency]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Estate_Agency', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Estate_Agency.mdf' , SIZE = 5312KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Estate_Agency_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Estate_Agency_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [Estate_Agency] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Estate_Agency].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Estate_Agency] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Estate_Agency] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Estate_Agency] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Estate_Agency] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Estate_Agency] SET ARITHABORT OFF 
GO

ALTER DATABASE [Estate_Agency] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [Estate_Agency] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Estate_Agency] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Estate_Agency] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Estate_Agency] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Estate_Agency] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Estate_Agency] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Estate_Agency] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Estate_Agency] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Estate_Agency] SET  ENABLE_BROKER 
GO

ALTER DATABASE [Estate_Agency] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Estate_Agency] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Estate_Agency] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Estate_Agency] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Estate_Agency] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Estate_Agency] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Estate_Agency] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Estate_Agency] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Estate_Agency] SET  MULTI_USER 
GO

ALTER DATABASE [Estate_Agency] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Estate_Agency] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Estate_Agency] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Estate_Agency] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [Estate_Agency] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Estate_Agency] SET  READ_WRITE 
GO

