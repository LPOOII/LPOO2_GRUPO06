SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Sp_Cliente_DeleteCliente](@id int)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	--Eliminamos el cliente
	DELETE FROM Cliente
    WHERE cli_id = @id
	RETURN
GO
