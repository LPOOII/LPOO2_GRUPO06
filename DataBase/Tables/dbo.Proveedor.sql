CREATE TABLE [dbo].[Proveedor]
(
[prov_id] [int] NOT NULL IDENTITY(1, 1),
[prov_nombre] [varchar] (80) COLLATE Modern_Spanish_CI_AS NOT NULL,
[prov_domicilio] [varchar] (80) COLLATE Modern_Spanish_CI_AS NOT NULL,
[prov_departamento] [varchar] (80) COLLATE Modern_Spanish_CI_AS NOT NULL,
[prov_codigo_postal] [varchar] (20) COLLATE Modern_Spanish_CI_AS NOT NULL,
[prov_telefono] [varchar] (20) COLLATE Modern_Spanish_CI_AS NOT NULL,
[prov_email] [varchar] (80) COLLATE Modern_Spanish_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Proveedor] ADD CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED  ([prov_id]) ON [PRIMARY]
GO
