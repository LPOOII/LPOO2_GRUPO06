SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ListarOrdenProduccionFecha]
	(
	@menor datetime,
	@mayor datetime
	)
	
AS
	/* SET NOCOUNT ON op_fecha */
	SELECT * FROM Vista_Orden_Produccion 
	WHERE (Fecha >= @menor) and  (Fecha <= @mayor)
	RETURN

GO
