SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Sp_Venta_TraerPedido](@id int)
AS
/*listamos pedido por si id del pedido para luego mostrar 
	algunos datos del objeto pedido*/
	SELECT * FROM Pedido WHERE ped_id=@id
RETURN
GO
