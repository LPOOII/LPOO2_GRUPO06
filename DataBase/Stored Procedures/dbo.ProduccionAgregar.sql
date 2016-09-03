SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProduccionAgregar]
	
	(
		@fec datetime, 
		@pro int, 
		@cant decimal(18,0), 
		@mp decimal(18,0),
		@oc decimal(18,0), 
		@cf decimal(18,0) 
	)
	
AS
	/* carga una orden de produccion */
	INSERT INTO Orden_Produccion (op_fecha, pro_id, cantidad,total_materia_prima, total_otros_costos, costo_final)
                                values (@fec,@pro,@cant,@mp,@oc,@cf)
	RETURN
GO
