SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[OtroCosto_dalete](@id int)
	
AS
--Eliminamos el cliente
	DELETE FROM Otros_Costos
    WHERE oc_id = @id
	RETURN
GO
