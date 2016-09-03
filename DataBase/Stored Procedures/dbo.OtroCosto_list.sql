SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[OtroCosto_list]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT dbo.Otros_Costos.oc_id AS 'ID', dbo.Otros_Costos.oc_descrip AS 'Descripcion', dbo.Otros_Costos.oc_costo AS 'Costo',
           dbo.Unidad_Medida.um_id AS 'ID Unidad de Medida', dbo.Unidad_Medida.um_descrip AS 'Unidad de Medida', dbo.Otros_Costos.oc_observaciones AS 'Observaciones'
    
    FROM   dbo.Otros_Costos INNER JOIN
           dbo.Unidad_Medida ON dbo.Otros_Costos.um_id = dbo.Unidad_Medida.um_id
	RETURN
GO
