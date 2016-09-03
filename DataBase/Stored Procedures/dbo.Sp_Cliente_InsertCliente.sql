SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Sp_Cliente_InsertCliente](@nom varchar(50), @dom varchar(50), @dep varchar(50), @cp varchar(50), @tel varchar(50), @mail varchar(50), @fecha datetime)
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	--guadamos un cliente a la base
	INSERT INTO Cliente(cli_nombre,cli_domicilio,cli_departamento,
                cli_codigo_postal,cli_telefono,cli_email,cli_fecha_nac) 
        VALUES(@nom,@dom,@dep,@cp,@tel,@mail,@fecha)
	RETURN
GO
