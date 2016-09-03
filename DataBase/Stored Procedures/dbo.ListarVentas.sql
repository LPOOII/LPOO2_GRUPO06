SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ListarVentas]
	
	(
		@menor datetime,
		@mayor datetime,
		@cli int
	)
	
AS
	

	SELECT * FROM Vista_Venta_Cliente WHERE (Fecha >= @menor) and (Fecha <= @mayor) and (Codigo_Cliente LIKE @cli)
	RETURN
GO
