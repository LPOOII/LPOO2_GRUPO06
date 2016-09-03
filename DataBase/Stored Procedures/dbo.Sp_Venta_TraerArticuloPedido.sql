SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
--4to metodo traer_Articulo_pedido(int id) de la clase VentaModel
CREATE PROCEDURE [dbo].[Sp_Venta_TraerArticuloPedido](@id int)	
AS
--Listamos 2 tablas Articulos y Items_Pedido para mostrar en el gridview
--algunos datos cuando se seleccinone del comboBox pedido
	SELECT C.art_id AS 'Id', C.art_descrip AS 'Descripcion', B.precio AS 'Precio',
           B.cantidad AS 'Cantidad', B.importe AS 'Importe'
    FROM Pedido AS A 
    LEFT OUTER JOIN Items_Pedido AS B ON B.ped_id = A.ped_id 
    LEFT OUTER JOIN Articulo AS C ON C.art_id = B.art_id
    WHERE(A.ped_id = @id)
RETURN
GO
