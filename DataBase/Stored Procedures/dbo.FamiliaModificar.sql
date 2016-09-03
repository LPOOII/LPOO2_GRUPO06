SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[FamiliaModificar]
	
	(
	@id int ,
	@des varchar(80)
	)
	
AS
	UPDATE Familia SET fam_descrip = @des WHERE fam_id = @id
	RETURN
GO
