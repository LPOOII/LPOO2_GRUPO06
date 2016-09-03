SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProductoAgregarItemsMateriaPrima]
	
	(
		@cost decimal(18,0),
		@cant decimal(18,0),
		@imp decimal(18,0),
		@pro int,
		@art int
	)
	
AS
	/* a un item de materia prima a la Bd */
	INSERT INTO Items_Materia_Prima(costo,cantidad,importe,pro_id,art_id) values(@cost,@cant,@imp,@pro,@art)
	RETURN
GO
