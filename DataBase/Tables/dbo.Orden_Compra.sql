CREATE TABLE [dbo].[Orden_Compra]
(
[oc_id] [int] NOT NULL IDENTITY(1, 1),
[oc_fecha] [datetime] NOT NULL,
[pagada] [bit] NOT NULL,
[prov_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orden_Compra] ADD CONSTRAINT [PK_Orden_Compra] PRIMARY KEY CLUSTERED  ([oc_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orden_Compra] ADD CONSTRAINT [FK_Orden_Compra_Proveedor] FOREIGN KEY ([prov_id]) REFERENCES [dbo].[Proveedor] ([prov_id])
GO
