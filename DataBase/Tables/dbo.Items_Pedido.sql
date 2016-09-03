CREATE TABLE [dbo].[Items_Pedido]
(
[item_ped_id] [int] NOT NULL IDENTITY(1, 1),
[ped_id] [int] NOT NULL,
[art_id] [int] NOT NULL,
[precio] [decimal] (18, 0) NOT NULL,
[cantidad] [decimal] (18, 0) NOT NULL,
[importe] [decimal] (18, 0) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Items_Pedido] ADD CONSTRAINT [PK_Items_Pedido] PRIMARY KEY CLUSTERED  ([item_ped_id]) ON [PRIMARY]
GO
