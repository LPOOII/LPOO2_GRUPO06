CREATE TABLE [dbo].[Items_Otros_Costos]
(
[item_oc_id] [int] NOT NULL IDENTITY(1, 1),
[pro_id] [int] NOT NULL,
[oc_id] [int] NOT NULL,
[costo] [decimal] (18, 0) NOT NULL,
[cantidad] [decimal] (18, 0) NOT NULL,
[importe] [decimal] (18, 0) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Items_Otros_Costos] ADD CONSTRAINT [PK_Items_Otros_Costos] PRIMARY KEY CLUSTERED  ([item_oc_id]) ON [PRIMARY]
GO
