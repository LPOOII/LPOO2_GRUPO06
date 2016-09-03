SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[FamiliaEliminar]
	
	(
	@id int
	)
	
AS
	/* SET NOCOUNT ON */
	DELETE FROM Familia WHERE fam_id = @id
	RETURN
GO
