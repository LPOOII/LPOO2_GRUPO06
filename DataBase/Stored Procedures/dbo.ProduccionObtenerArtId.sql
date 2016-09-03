SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProduccionObtenerArtId]
	
	(
		@prodID int
	
	)
	
AS
	/* devuelve un id de un determinado articulo */
	SELECT art_id FROM Producto WHERE pro_id = @prodID
	RETURN
GO
