SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProductoAgregarItemsOtrosCostos]
	
	(
		@cost decimal(18,0),
		@cant decimal(18,0),
		@imp decimal(18,0),
		@pro int,
		@oc int
	)
	
AS
	/* a un item de otros costos a la Bd  */
	INSERT INTO Items_Otros_Costos(costo,cantidad,importe,pro_id,oc_id) values(@cost,@cant,@imp,@pro,@oc)
	RETURN
GO
