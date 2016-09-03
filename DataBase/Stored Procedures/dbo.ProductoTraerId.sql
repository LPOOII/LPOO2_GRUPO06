SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProductoTraerId]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* trae el ultimo id de la tabla producto  */
	SELECT TOP 1 * FROM Producto ORDER BY pro_id DESC
	RETURN
GO
