SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[OrdenesCompraTodoc]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT oc_id AS 'Id_Orden_Compra' , prov_id AS 'Id_Proveedor',
			prov_nombre AS 'Nombre', oc_fecha AS 'Fecha', importe AS 'Importe', pagada AS 'Estado'
			 FROM Vista_Ordenes_Compra  ORDER BY prov_nombre  ASC
	RETURN
GO
