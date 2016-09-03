SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProduccionTraerItemsMateriaPrima](@idpro int)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* traer una lista de items de materia prima de acuerdo al parametro @idpro */
	SELECT * FROM Items_Materia_Prima WHERE pro_id = @idpro
	RETURN
GO
