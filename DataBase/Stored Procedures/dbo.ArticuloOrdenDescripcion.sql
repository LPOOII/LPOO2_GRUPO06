SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ArticuloOrdenDescripcion]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT
		art_id AS 'ID Articulo',
		art_descrip AS 'Descripcion',
		art_costo AS 'Costo',
		art_margen_beneficio AS 'Margen Beneficio',
		art_precio AS 'Precio',
		art_stock_min AS 'Stock Minimo',
		art_stock_max AS 'Stock Maximo',
		art_stock_reposicion AS 'Stock Reposicion',
		art_stock_actual AS 'Stock Actual',
		art_maneja_stock AS 'Maneja Stock',
		fam_descrip AS 'Familia',
		um_descrip AS 'Unidad de Medida'
		FROM
		Articulo 
		INNER JOIN
		Familia ON (Articulo.fam_id = Familia.fam_id)
		INNER JOIN
		Unidad_Medida ON (Articulo.um_id = Unidad_Medida.um_id)
		ORDER BY 
		art_descrip
	RETURN
GO
