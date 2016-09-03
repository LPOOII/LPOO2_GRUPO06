SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProductoTraerMateriasPrimas]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* trae materias primas */
	SELECT * FROM Vista_Articulos WHERE fam_id = 1
	RETURN
GO
