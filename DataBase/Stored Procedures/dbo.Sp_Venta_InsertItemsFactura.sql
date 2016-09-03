SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
--6to metodo insert_Items_Factura(Items_Factura itemFactura) de la clase VentaModel
CREATE PROCEDURE [dbo].[Sp_Venta_InsertItemsFactura](@f_id int, @a_id int, @pre decimal, @cant decimal, @imp decimal)
AS
--Guardamos en la tabla Items_Factura
	INSERT 
    INTO Items_Factura(fac_id, art_id, precio, cantidad, importe)
    VALUES (@f_id, @a_id, @pre, @cant, @imp)
RETURN
GO
