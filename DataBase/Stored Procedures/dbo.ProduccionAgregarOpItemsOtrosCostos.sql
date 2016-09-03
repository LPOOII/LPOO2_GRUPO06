SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProduccionAgregarOpItemsOtrosCostos]
	
	(
		
		@op int,
		@oc int,
		@cos decimal(18,0),
		@cant decimal(18,0),
		@imp decimal(18,0)
	)
	
AS
	/* guarda op_items_otros_costos en la bd */
	INSERT INTO OP_Items_Otros_Costos (op_id, oc_id, costo, cantidad, importe)
                                values (@op,@oc,@cos,@cant,@imp)
	RETURN
GO
