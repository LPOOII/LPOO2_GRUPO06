SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
--7mo metodo get_ImporteTotal(int id) de la clase VentaModel
CREATE PROCEDURE [dbo].[Sp_Venta_ImporteTotal](@id int, @total decimal=0 output)	
AS
	--devolvemos el total para mostrar en el gridview de dgvArticuloPedido
	SELECT @total=SUM(importe)
    FROM Items_Pedido AS A
    INNER JOIN Pedido AS B on A.ped_id=B.ped_id
    WHERE (A.ped_id = @id)
RETURN
GO
