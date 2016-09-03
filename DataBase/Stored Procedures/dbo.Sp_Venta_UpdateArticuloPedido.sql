SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
--8vo metodo update_Articulo_Pedido(Articulo article, int id) de la clase VentaModel
CREATE PROCEDURE [dbo].[Sp_Venta_UpdateArticuloPedido](@id int, @stkactual decimal)	
AS
--Acualizamos el stockActual de Articulos
	update Articulo
    set art_stock_actual=@stkactual
    where art_id=@id
RETURN
GO
