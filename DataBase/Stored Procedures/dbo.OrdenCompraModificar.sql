SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[OrdenCompraModificar]
	
	(
	@prov int,
	@fecha datetime,
	@pag bit,
	@id int 
	)
	
AS
	UPDATE Orden_Compra SET prov_id=@prov, oc_fecha=@fecha, pagada=@pag WHERE oc_id=@id
	RETURN
GO
