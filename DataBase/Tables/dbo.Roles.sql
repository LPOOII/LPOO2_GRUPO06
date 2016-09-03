CREATE TABLE [dbo].[Roles]
(
[rol_id] [int] NOT NULL IDENTITY(1, 1),
[rol_descrip] [varchar] (80) COLLATE Modern_Spanish_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Roles] ADD CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED  ([rol_id]) ON [PRIMARY]
GO
