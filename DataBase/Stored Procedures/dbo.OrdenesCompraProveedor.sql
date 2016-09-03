SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[OrdenesCompraProveedor]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* traemos todos los proveedores  */
	
	

	SELECT * FROM Proveedor
	
	RETURN
GO
