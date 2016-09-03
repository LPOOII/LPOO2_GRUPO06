SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Sp_Cliente_ListCliente]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	--Listamos todos los clientes
	SELECT
    cli_nombre as 'Cliente', cli_domicilio as 'Domicilio', cli_departamento as 'Departamento', cli_codigo_postal as 'Codigo Postal' 
    ,cli_telefono as 'Telefono' ,cli_email as 'Email', cli_fecha_nac as 'Fecha Nacimiento', cli_id as 'Id'
    FROM Cliente
	RETURN
GO
