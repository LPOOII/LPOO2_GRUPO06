SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProductoTraerProductosTerminados]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* trae productos terminados */
	SELECT * FROM Vista_Articulos WHERE fam_id = 2
	RETURN
GO
