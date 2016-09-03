SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Sp_Venta_ListarPedido]
AS
--listamos todos los pedido dode pedido facturado sea 'False'
	SELECT * FROM Pedido
    WHERE ped_facturado='False'
RETURN
GO
