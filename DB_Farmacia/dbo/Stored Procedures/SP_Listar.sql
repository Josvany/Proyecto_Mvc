﻿
CREATE PROCEDURE SP_Listar
@table AS VARCHAR(MAX)

AS

BEGIN 
	DECLARE @Query VARCHAR(MAX)
	--DECLARE @table varchar(max) = 'CAT_CATEGORIA'

	SET @Query = 'SELECT * FROM ' + QUOTENAME(@table)
	EXEC sp_sqlexec @Query

END