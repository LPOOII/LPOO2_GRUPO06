CREATE TABLE [dbo].[Familia]
(
[fam_id] [int] NOT NULL IDENTITY(1, 1),
[fam_descrip] [varchar] (80) COLLATE Modern_Spanish_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Familia] ADD CONSTRAINT [PK_Familia_1] PRIMARY KEY CLUSTERED  ([fam_id]) ON [PRIMARY]
GO
