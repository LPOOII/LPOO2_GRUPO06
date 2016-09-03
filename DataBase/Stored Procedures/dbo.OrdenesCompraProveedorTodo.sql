SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[OrdenesCompraProveedorTodo]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	SELECT dbo.Orden_Compra.oc_id, dbo.Orden_Compra.prov_id, dbo.Proveedor.prov_nombre, dbo.Orden_Compra.oc_fecha, dbo.Orden_Compra.pagada
	FROM   dbo.Orden_Compra INNER JOIN
           dbo.Proveedor ON dbo.Orden_Compra.prov_id = dbo.Proveedor.prov_id
	RETURN
GO
