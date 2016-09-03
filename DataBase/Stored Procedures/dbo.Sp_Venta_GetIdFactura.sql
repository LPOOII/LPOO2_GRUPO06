SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
--10mo metodo update_Pedido de la clase VentaModel
CREATE PROCEDURE [dbo].[Sp_Venta_GetIdFactura]
AS
--Devolvemos el ultimo regitro de factura
	SELECT TOP(1) * 
    FROM Factura
    ORDER BY fac_id DESC
RETURN
GO
