SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Sp_Venta_TraerCliente](@id int)
AS
/*listamos pedido por si id del pedido para luego mostrar 
	algunos datos del objeto cliente*/
-- cuando seleccione del comboBox pedido, tambien muestren los datos del cliente 
	SELECT *
	FROM Pedido AS A 
	LEFT OUTER JOIN Cliente AS B ON B.cli_id = A.cli_id
	WHERE (A.ped_id = @id)
RETURN
GO
