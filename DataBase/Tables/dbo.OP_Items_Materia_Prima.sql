CREATE TABLE [dbo].[OP_Items_Materia_Prima]
(
[op_item_mp_id] [int] NOT NULL IDENTITY(1, 1),
[op_id] [int] NOT NULL,
[art_id] [int] NOT NULL,
[costo] [decimal] (18, 0) NOT NULL,
[cantidad] [decimal] (18, 0) NOT NULL,
[importe] [decimal] (18, 0) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OP_Items_Materia_Prima] ADD CONSTRAINT [PK_OP_Items_Materia_Prima] PRIMARY KEY CLUSTERED  ([op_item_mp_id]) ON [PRIMARY]
GO
