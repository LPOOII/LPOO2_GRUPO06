SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[OrdenPagoProveedor]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	SELECT * FROM Proveedor
	--SELECT op_id AS 'Id_Orden_Pago', prov_id AS 'Id_Proveedor', prov_nombre AS 'Nombre', op_fecha AS 'Fecha', op_importe AS 'Importe'  FROM Vista_Ordenes_Pago
	RETURN
GO
