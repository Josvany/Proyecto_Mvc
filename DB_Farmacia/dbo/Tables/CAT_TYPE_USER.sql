﻿CREATE TABLE [dbo].[CAT_TYPE_USER]
(
	CAT_TYP_USER   UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL  PRIMARY KEY,
	CAT_TYP_NAME  NVARCHAR(50) NOT NULL

)
