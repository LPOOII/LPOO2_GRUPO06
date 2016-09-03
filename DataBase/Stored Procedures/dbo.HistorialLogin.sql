SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[HistorialLogin]
	
	(
	@hlog datetime,
	@id int
	)
	
AS
	INSERT INTO Historial_Login(hlog_fecha_hora,usr_id) values(@hlog,@id)
	RETURN
GO
