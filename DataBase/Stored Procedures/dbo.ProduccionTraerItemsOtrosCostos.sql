SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProduccionTraerItemsOtrosCostos](@idpro int)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT * FROM Items_Otros_Costos WHERE pro_id = @idpro
	RETURN
GO
