CREATE TABLE [dbo].[Pedido]
(
[ped_id] [int] NOT NULL IDENTITY(1, 1),
[cli_id] [int] NOT NULL,
[ped_fecha_emision] [datetime] NOT NULL,
[ped_fecha_entrega] [datetime] NOT NULL,
[ped_facturado] [bit] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pedido] ADD CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED  ([ped_id]) ON [PRIMARY]
GO
