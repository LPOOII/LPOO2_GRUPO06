SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProductoAgregar]
	
	(
		@prima decimal(18,0),
		@costo decimal(18,0),
		@final decimal(18,0),
		@id int
	)
	
AS
	/* carga en la Bd un producto */
	INSERT INTO Producto(total_materia_prima,total_otros_costos,costo_final,art_id)
                values(@prima,@costo,@final,@id)
	RETURN
GO
