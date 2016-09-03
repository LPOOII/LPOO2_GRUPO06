CREATE TABLE [dbo].[Producto]
(
[pro_id] [int] NOT NULL IDENTITY(1, 1),
[total_materia_prima] [decimal] (18, 0) NOT NULL,
[total_otros_costos] [decimal] (18, 0) NOT NULL,
[costo_final] [decimal] (18, 0) NOT NULL,
[art_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Producto] ADD CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED  ([pro_id]) ON [PRIMARY]
GO
