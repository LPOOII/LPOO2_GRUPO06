SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProductoActualizarProductoTerminado]
	
	(
		@artId int,
		@descrip varchar(80),
		@costo decimal(18,0),
		@margBen decimal(18,0),
		@precio decimal(18,0),
		@stkmin decimal(18,0),
		@stkmax decimal(18,0),
		@stkrep decimal(18,0),
		@stkactual decimal(18,0),
		@manjstk bit,
		@fam int,
		@unMed int
	)
	
AS
	/* actualiza un producto(de articulo) segun un objeto q viene como parametro a modificar */
	 update Articulo
       set art_descrip=@descrip, art_costo=@costo, art_margen_beneficio=@margBen,
           art_precio=@precio, art_stock_min=@stkmin, art_stock_max=@stkmax,
           art_stock_reposicion=@stkrep, art_stock_actual=@stkactual, 
           art_maneja_stock=@manjstk, fam_id=@fam, um_id=@unMed
           where art_id=@artId
	RETURN
GO
