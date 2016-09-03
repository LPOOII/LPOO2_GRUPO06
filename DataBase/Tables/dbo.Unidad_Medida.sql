CREATE TABLE [dbo].[Unidad_Medida]
(
[um_id] [int] NOT NULL IDENTITY(1, 1),
[um_descrip] [varchar] (80) COLLATE Modern_Spanish_CI_AS NOT NULL,
[um_abrev] [varchar] (20) COLLATE Modern_Spanish_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Unidad_Medida] ADD CONSTRAINT [PK_Unidad_Medida] PRIMARY KEY CLUSTERED  ([um_id]) ON [PRIMARY]
GO
