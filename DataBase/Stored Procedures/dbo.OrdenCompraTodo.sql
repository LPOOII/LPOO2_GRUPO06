SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[OrdenCompraTodo]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/*SELECT * FROM Orden_Compra WHERE pagada = 'False'*/
	SELECT     dbo.Orden_Compra.oc_id, dbo.Orden_Compra.oc_fecha, dbo.Orden_Compra.pagada, dbo.Orden_Compra.prov_id, dbo.Proveedor.prov_nombre
FROM         dbo.Orden_Compra INNER JOIN
                      dbo.Proveedor ON dbo.Orden_Compra.prov_id = dbo.Proveedor.prov_id
					  WHERE dbo.Orden_Compra.pagada = 'False'
	RETURN
GO
