CREATE TABLE [dbo].[Orden_Produccion]
(
[op_id] [int] NOT NULL IDENTITY(1, 1),
[op_fecha] [datetime] NOT NULL,
[pro_id] [int] NOT NULL,
[cantidad] [decimal] (18, 0) NOT NULL,
[total_materia_prima] [decimal] (18, 0) NOT NULL,
[total_otros_costos] [decimal] (18, 0) NOT NULL,
[costo_final] [decimal] (18, 0) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orden_Produccion] ADD CONSTRAINT [PK_Orden_Produccion] PRIMARY KEY CLUSTERED  ([op_id]) ON [PRIMARY]
GO
