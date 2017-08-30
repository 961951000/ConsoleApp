/*
Navicat SQL Server Data Transfer

Source Server         : 127.0.0.1
Source Server Version : 110000
Source Host           : 127.0.0.1:1433
Source Database       : Test
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 110000
File Encoding         : 65001

Date: 2017-08-30 20:42:52
*/


-- ----------------------------
-- Table structure for School
-- ----------------------------
DROP TABLE [dbo].[School]
GO
CREATE TABLE [dbo].[School] (
[SchoolId] int NOT NULL IDENTITY(1,1) ,
[SchoolName] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[School]', RESEED, 2)
GO

-- ----------------------------
-- Table structure for Student
-- ----------------------------
DROP TABLE [dbo].[Student]
GO
CREATE TABLE [dbo].[Student] (
[StudentId] int NOT NULL IDENTITY(1,1) ,
[StudentName] varchar(255) NULL ,
[SchoolRefId] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Student]', RESEED, 4)
GO

-- ----------------------------
-- Indexes structure for table School
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table School
-- ----------------------------
ALTER TABLE [dbo].[School] ADD PRIMARY KEY ([SchoolId])
GO

-- ----------------------------
-- Indexes structure for table Student
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD PRIMARY KEY ([StudentId])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Student]
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD FOREIGN KEY ([SchoolRefId]) REFERENCES [dbo].[School] ([SchoolId]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
