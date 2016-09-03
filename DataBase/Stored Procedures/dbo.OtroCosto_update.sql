SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[OtroCosto_update](@id int, @descrip varchar(50), @um int, @costo decimal(18,0), @obs varchar(50))
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* actualizamos el costo*/
	UPDATE Otros_Costos SET oc_descrip = @descrip,um_id = @um,oc_costo = @costo,oc_observaciones= @obs
	WHERE oc_id= @id
	RETURN
GO
