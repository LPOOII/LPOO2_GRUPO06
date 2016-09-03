SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
--9vo metodo update_Pedido de la clase VentaModel
CREATE PROCEDURE [dbo].[Sp_Venta_UpdatePedido](@id int, @fac bit)
AS
--Actualizamos el pedido facturado a true
	update Pedido
    set ped_facturado=@fac
    where ped_id=@id
RETURN
GO
