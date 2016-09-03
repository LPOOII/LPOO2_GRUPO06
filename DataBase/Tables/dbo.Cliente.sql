CREATE TABLE [dbo].[Cliente]
(
[cli_id] [int] NOT NULL IDENTITY(1, 1),
[cli_nombre] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[cli_domicilio] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[cli_departamento] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[cli_codigo_postal] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[cli_telefono] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[cli_email] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL,
[cli_fecha_nac] [datetime] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente] ADD CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED  ([cli_id]) ON [PRIMARY]
GO
