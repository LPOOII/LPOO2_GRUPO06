SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ListaOrdenCompra]
	
	(
	@prov int
	
	)
	

AS
	
	SELECT oc_id AS 'Id_Orden_Compra' , prov_id AS 'Id_Proveedor',
			prov_nombre AS 'Nombre', oc_fecha AS 'Fecha', importe AS 'Importe', pagada AS 'Estado'
			 FROM Vista_Ordenes_Compra WHERE prov_id = @prov ORDER BY prov_nombre  ASC
	RETURN
GO
