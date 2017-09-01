﻿CREATE TABLE [dbo].[TBL_PEDIDO] (
    [PED_DET_INT_ID]   UNIQUEIDENTIFIER CONSTRAINT [DF_TBL_PEDIDO_PED_DET_INT_ID] DEFAULT (newid()) NOT NULL,
    [PROD_INT_ID]      UNIQUEIDENTIFIER NOT NULL,
    [PED_DET_CANTIDAD] INT              NOT NULL,
    [PED_DET_PRECIO]   DECIMAL (18, 2)  NOT NULL,
    [PED_DET_FECHA]    NCHAR (10)       NOT NULL,
    CONSTRAINT [PK_TBL_PEDIDO] PRIMARY KEY CLUSTERED ([PED_DET_INT_ID] ASC),
    CONSTRAINT [FK_TBL_PEDIDO_TBL_PRODUCTO] FOREIGN KEY ([PROD_INT_ID]) REFERENCES [dbo].[TBL_PRODUCTO] ([PROD_INT_ID])
);

