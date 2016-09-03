SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[OrdenCompraTraerObjet]
	
	(
	@id int
	
	)
	
AS
	SELECT * FROM Orden_Compra WHERE oc_id=@id
	RETURN
GO
