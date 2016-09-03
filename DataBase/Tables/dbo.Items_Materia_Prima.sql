CREATE TABLE [dbo].[Items_Materia_Prima]
(
[item_mp_id] [int] NOT NULL IDENTITY(1, 1),
[pro_id] [int] NOT NULL,
[art_id] [int] NOT NULL,
[costo] [decimal] (18, 0) NOT NULL,
[cantidad] [decimal] (18, 0) NOT NULL,
[importe] [decimal] (18, 0) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Items_Materia_Prima] ADD CONSTRAINT [PK_Items_Materia_Prima] PRIMARY KEY CLUSTERED  ([item_mp_id]) ON [PRIMARY]
GO
