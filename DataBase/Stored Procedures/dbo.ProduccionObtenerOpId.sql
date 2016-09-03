SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProduccionObtenerOpId]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/*obtiene el ultimo id generado de la tabla Orden_Produccion*/ 
	SELECT TOP 1 * FROM Orden_Produccion ORDER BY op_id DESC
	RETURN
GO
