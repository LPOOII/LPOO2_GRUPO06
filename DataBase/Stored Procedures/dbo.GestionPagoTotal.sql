SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[GestionPagoTotal]
	
	(
	@idc int
	
	)
	
AS
	SELECT sum(importe) FROM Items_Orden_Compra WHERE oc_id = @idc
	RETURN
GO
