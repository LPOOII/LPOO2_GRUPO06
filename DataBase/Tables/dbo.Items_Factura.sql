CREATE TABLE [dbo].[Items_Factura]
(
[item_fac_id] [int] NOT NULL IDENTITY(1, 1),
[fac_id] [int] NOT NULL,
[art_id] [int] NOT NULL,
[precio] [decimal] (18, 0) NOT NULL,
[cantidad] [decimal] (18, 0) NOT NULL,
[importe] [decimal] (18, 0) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Items_Factura] ADD CONSTRAINT [PK_Items_Factura] PRIMARY KEY CLUSTERED  ([item_fac_id]) ON [PRIMARY]
GO
