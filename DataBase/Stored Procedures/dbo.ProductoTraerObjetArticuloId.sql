SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProductoTraerObjetArticuloId]
	
	(
		
		@articulo_id int
	)
	
AS
	/* trae un objeto especifico de acuerdo a un id*/
	SELECT * FROM Articulo WHERE art_id=@articulo_id
	RETURN
GO
