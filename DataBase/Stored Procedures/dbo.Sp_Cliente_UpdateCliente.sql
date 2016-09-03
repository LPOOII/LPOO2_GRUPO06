SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Sp_Cliente_UpdateCliente](@id int, @nom varchar(50), @dom varchar(50), @dep varchar(50), @cp varchar(50), @tel varchar(50), @mail varchar(50), @fecha datetime)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	--actualizamos el cliente
	UPDATE Cliente
    SET cli_nombre = @nom, cli_domicilio = @dom, cli_departamento = @dep, cli_codigo_postal = @cp 
        ,cli_telefono = @tel ,cli_email = @mail, cli_fecha_nac = @fecha
    WHERE cli_id = @id
	RETURN
GO
