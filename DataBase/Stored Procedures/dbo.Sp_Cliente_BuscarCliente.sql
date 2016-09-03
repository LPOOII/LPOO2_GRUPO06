SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Sp_Cliente_BuscarCliente](@nom varchar(50), @dom varchar(50))
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT 
    cli_nombre as 'Cliente', cli_domicilio as 'Domicilio', cli_departamento as 'Departamento', cli_codigo_postal as 'Codigo Postal' 
    ,cli_telefono as 'Telefono' ,cli_email as 'Email', cli_fecha_nac as 'Fecha Nacimiento', cli_id as 'Id'
    FROM Cliente
    WHERE cli_nombre LIKE @nom AND cli_domicilio LIKE @dom
	RETURN
GO
