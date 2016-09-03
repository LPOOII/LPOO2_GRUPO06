SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
--5to metodo insert_Factura(Factura factura) de la clase VentaModel
CREATE PROCEDURE [dbo].[Sp_Venta_InsertFactura](@ped_id int,@cli_id int,@fac_numero int,@fac_fecha datetime,@fp_id int)	
AS
--Guardamos en la tabla Factura  
	INSERT 
    INTO Factura(ped_id,cli_id,fac_numero,fac_fecha,fp_id)
    VALUES(@ped_id,@cli_id,@fac_numero,@fac_fecha,@fp_id)
RETURN
GO
