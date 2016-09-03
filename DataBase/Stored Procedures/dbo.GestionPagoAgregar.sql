SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[GestionPagoAgregar]
	
	(
	@oc int,
	@prov int,
	@fec datetime,
	@imp decimal(18,0)
	)
	
AS
	/* SET NOCOUNT ON */
	INSERT INTO Orden_Pago (oc_id,prov_id,op_fecha,op_importe) VALUES (@oc,@prov,@fec,@imp)
	RETURN
GO
