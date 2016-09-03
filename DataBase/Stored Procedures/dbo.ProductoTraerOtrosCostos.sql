SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProductoTraerOtrosCostos]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* trae una lista de otros costos {}{} */
	SELECT * FROM Otros_Costos
	RETURN
GO
