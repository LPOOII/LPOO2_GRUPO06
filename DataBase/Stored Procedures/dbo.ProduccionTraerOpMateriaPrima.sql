SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ProduccionTraerOpMateriaPrima]
	
	(
		@op int
	)
	
AS
	/* trae una lista de OP_Items_Materia_Prima de acuerdo a un parametro*/
	SELECT * FROM OP_Items_Materia_Prima WHERE op_id = @op
	RETURN
GO
