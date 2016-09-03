CREATE TABLE [dbo].[Forma_Pago]
(
[fp_id] [int] NOT NULL IDENTITY(1, 1),
[fp_descrip] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Forma_Pago] ADD CONSTRAINT [PK_Forma_Pago] PRIMARY KEY CLUSTERED  ([fp_id]) ON [PRIMARY]
GO
