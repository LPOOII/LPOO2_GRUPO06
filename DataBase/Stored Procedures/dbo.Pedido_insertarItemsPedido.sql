SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Pedido_insertarItemsPedido] (@ped_id int, @art_id int, 
											@precio decimal, @cantidad decimal, @importe decimal)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	INSERT INTO Items_Pedido (ped_id, art_id, precio, cantidad, importe) 
	VALUES (@ped_id, @art_id, @precio, @cantidad, @importe)
	RETURN
GO
