SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Sp_login]
		(
	@username varchar(45),
	@password varchar(45)
	)	
AS
	/* SET NOCOUNT ON */
	SELECT * FROM Usuario AS U WHERE U.usr_username = @username AND U.usr_password = @password
	RETURN
GO
