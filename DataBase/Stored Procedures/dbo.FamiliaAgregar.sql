SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[FamiliaAgregar]
	
	(
	@des varchar(80)
	
	)
	
AS
	
	INSERT INTO Familia (fam_descrip) VALUES (@des)
	RETURN
GO
