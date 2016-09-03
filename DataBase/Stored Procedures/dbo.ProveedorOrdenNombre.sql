SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProveedorOrdenNombre]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT 
		prov_id AS 'Id',
		prov_nombre AS 'Nombre',
		prov_domicilio AS 'Domicilio',
		prov_departamento AS 'Departamento',
		prov_codigo_postal AS 'Codigo Postal',
		prov_telefono AS 'Telefono',
		prov_email AS 'Email'
	FROM
		Proveedor
	ORDER BY
		prov_nombre
	RETURN
GO
