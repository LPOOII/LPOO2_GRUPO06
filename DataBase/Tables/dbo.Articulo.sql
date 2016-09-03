CREATE TABLE [dbo].[Articulo]
(
[art_id] [int] NOT NULL IDENTITY(1, 1),
[art_descrip] [varchar] (80) COLLATE Modern_Spanish_CI_AS NOT NULL,
[art_costo] [decimal] (18, 0) NOT NULL,
[art_margen_beneficio] [decimal] (18, 0) NULL,
[art_precio] [decimal] (18, 0) NOT NULL,
[art_stock_min] [decimal] (18, 0) NOT NULL,
[art_stock_max] [decimal] (18, 0) NOT NULL,
[art_stock_reposicion] [decimal] (18, 0) NOT NULL,
[art_stock_actual] [decimal] (18, 0) NOT NULL,
[art_maneja_stock] [bit] NOT NULL,
[fam_id] [int] NOT NULL,
[um_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Articulo] ADD CONSTRAINT [PK_Articulo] PRIMARY KEY CLUSTERED  ([art_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Articulo] ADD CONSTRAINT [FK_Articulo_Familia] FOREIGN KEY ([fam_id]) REFERENCES [dbo].[Familia] ([fam_id])
GO
ALTER TABLE [dbo].[Articulo] ADD CONSTRAINT [FK_Articulo_Unidad_Medida] FOREIGN KEY ([um_id]) REFERENCES [dbo].[Unidad_Medida] ([um_id])
GO
