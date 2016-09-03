CREATE TABLE [dbo].[Items_Orden_Compra]
(
[item_oc_id] [int] NOT NULL IDENTITY(1, 1),
[costo] [decimal] (18, 0) NOT NULL,
[cantidad] [decimal] (18, 0) NOT NULL,
[importe] [decimal] (18, 0) NOT NULL,
[oc_id] [int] NOT NULL,
[art_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Items_Orden_Compra] ADD CONSTRAINT [PK_Items_Orden_Compra] PRIMARY KEY CLUSTERED  ([item_oc_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Items_Orden_Compra] ADD CONSTRAINT [FK_Items_Orden_Compra_Articulo] FOREIGN KEY ([art_id]) REFERENCES [dbo].[Articulo] ([art_id])
GO
ALTER TABLE [dbo].[Items_Orden_Compra] ADD CONSTRAINT [FK_Items_Orden_Compra_Orden_Compra] FOREIGN KEY ([oc_id]) REFERENCES [dbo].[Orden_Compra] ([oc_id])
GO
