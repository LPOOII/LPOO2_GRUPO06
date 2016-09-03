CREATE TABLE [dbo].[Orden_Pago]
(
[op_id] [int] NOT NULL IDENTITY(1, 1),
[oc_id] [int] NOT NULL,
[prov_id] [int] NOT NULL,
[op_fecha] [datetime] NOT NULL,
[op_importe] [decimal] (18, 0) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orden_Pago] ADD CONSTRAINT [PK_Orden_Pago] PRIMARY KEY CLUSTERED  ([op_id]) ON [PRIMARY]
GO
