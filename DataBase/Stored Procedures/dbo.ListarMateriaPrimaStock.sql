SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ListarMateriaPrimaStock]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	/* SET NOCOUNT ON */
	SELECT * FROM Vista_MateriaPrima WHERE Id_Familia = 1 AND Stock_Actual < Stock_Minimo   
	RETURN
GO
