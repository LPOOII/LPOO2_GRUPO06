SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProduccionAgregarOpItemsMateriaPrima]
	
	(
		@op int,
		@art int,
		@cos decimal(18,0),
		@cant decimal(18,0),
		@imp decimal(18,0)
	)
	
AS
	
	/* Guarda una Orden_Produccion_Items_Materia_Prima */
	INSERT INTO OP_Items_Materia_Prima (op_id, art_id, costo, cantidad, importe)
                                values (@op,@art,@cos,@cant,@imp)
	RETURN
GO
