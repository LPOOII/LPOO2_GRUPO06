SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[OrdenCompraTraer]
	
	(
	@oc int
	
	)
	
AS
	SELECT prov_id FROM Orden_Compra  WHERE oc_id = @oc
	RETURN
GO
