SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ListarOrdenProduccion]
	
	
AS
	/* SET NOCOUNT ON */
	SELECT * FROM Vista_Orden_Produccion 
	
	RETURN

GO
