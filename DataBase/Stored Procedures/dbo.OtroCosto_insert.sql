SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[OtroCosto_insert](@descrip varchar(50), @um int, @costo decimal(18,0), @obs varchar(50))
AS
--guardamos otro costo  a la base
	INSERT INTO Otros_Costos(oc_descrip,um_id,oc_costo,oc_observaciones) 
        VALUES(@descrip,@um,@costo,@obs)
	RETURN
GO
