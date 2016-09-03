SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Pedido_insertar] (@cli int, @femision date, @fentrega date, @facturado bit)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	INSERT INTO Pedido (cli_id, ped_fecha_emision, ped_fecha_entrega, ped_facturado) 
	VALUES (@cli, @femision, @fentrega, @facturado)
	RETURN

GO
