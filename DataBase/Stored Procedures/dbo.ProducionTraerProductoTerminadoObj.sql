SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProducionTraerProductoTerminadoObj]
	
	(
		@articulo_id int
	)
	
AS
	/* trae un articulo, segun un determinado art_id q vienen por parametro */
	SELECT * FROM Articulo WHERE art_id=@articulo_id

	RETURN
GO
