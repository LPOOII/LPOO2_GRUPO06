CREATE TABLE [dbo].[Historial_Login]
(
[hlog_id] [int] NOT NULL IDENTITY(1, 1),
[hlog_fecha_hora] [datetime] NOT NULL,
[usr_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Historial_Login] ADD CONSTRAINT [PK_Historial_Login] PRIMARY KEY CLUSTERED  ([hlog_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Historial_Login] ADD CONSTRAINT [FK_Historial_Login_Usuario] FOREIGN KEY ([usr_id]) REFERENCES [dbo].[Usuario] ([usr_id])
GO
