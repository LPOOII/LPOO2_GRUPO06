CREATE TABLE [dbo].[Usuario]
(
[usr_id] [int] NOT NULL IDENTITY(1, 1),
[usr_nombre] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[usr_apellido] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[usr_username] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[usr_password] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[usr_email] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[rol_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuario] ADD CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED  ([usr_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuario] ADD CONSTRAINT [FK_Usuario_Roles] FOREIGN KEY ([rol_id]) REFERENCES [dbo].[Roles] ([rol_id])
GO
