CREATE TABLE [dbo].[Factura]
(
[fac_id] [int] NOT NULL IDENTITY(1, 1),
[ped_id] [int] NOT NULL,
[cli_id] [int] NOT NULL,
[fac_numero] [int] NOT NULL,
[fac_fecha] [datetime] NOT NULL,
[fp_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Factura] ADD CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED  ([fac_id]) ON [PRIMARY]
GO
