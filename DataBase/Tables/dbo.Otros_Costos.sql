CREATE TABLE [dbo].[Otros_Costos]
(
[oc_id] [int] NOT NULL IDENTITY(1, 1),
[oc_descrip] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[um_id] [int] NOT NULL,
[oc_costo] [decimal] (18, 0) NOT NULL,
[oc_observaciones] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Otros_Costos] ADD CONSTRAINT [PK_Otros_Costos] PRIMARY KEY CLUSTERED  ([oc_id]) ON [PRIMARY]
GO
