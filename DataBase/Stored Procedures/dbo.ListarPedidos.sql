SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ListarPedidos]
	
	(
		@menor datetime,
		@mayor datetime,
		@cli int
	)
	
AS
	/* SET NOCOUNT ON */
	SELECT * FROM Vista_Pedido_Cliente WHERE (Fecha_de_Emision >= @menor) and (Fecha_de_Entrega <= @mayor) and (Codigo_Cliente LIKE @cli)
	RETURN
GO
