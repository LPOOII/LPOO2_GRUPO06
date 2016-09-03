SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE VIEW [dbo].[Vista_MateriaPrima_StockPedido]
AS
SELECT        dbo.Articulo.art_id, dbo.Articulo.art_descrip, dbo.Articulo.art_costo, dbo.Articulo.art_margen_beneficio, dbo.Articulo.art_precio, dbo.Articulo.art_stock_min, 
                         dbo.Articulo.art_stock_max, dbo.Articulo.art_stock_reposicion, dbo.Articulo.art_stock_actual, dbo.Articulo.art_maneja_stock, dbo.Articulo.fam_id, 
                         dbo.Familia.fam_descrip, dbo.Unidad_Medida.um_descrip, dbo.Items_Pedido.cantidad
FROM            dbo.Articulo INNER JOIN
                         dbo.Familia ON dbo.Articulo.fam_id = dbo.Familia.fam_id INNER JOIN
                         dbo.Unidad_Medida ON dbo.Articulo.um_id = dbo.Unidad_Medida.um_id INNER JOIN
                         dbo.Items_Pedido ON dbo.Articulo.art_id = dbo.Items_Pedido.art_id
GO
EXEC sp_addextendedproperty N'MS_DiagramPane1', N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Articulo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "Familia"
            Begin Extent = 
               Top = 6
               Left = 285
               Bottom = 101
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Unidad_Medida"
            Begin Extent = 
               Top = 6
               Left = 532
               Bottom = 118
               Right = 741
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Items_Pedido"
            Begin Extent = 
               Top = 102
               Left = 285
               Bottom = 231
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', 'SCHEMA', N'dbo', 'VIEW', N'Vista_MateriaPrima_StockPedido', NULL, NULL
GO
DECLARE @xp int
SELECT @xp=1
EXEC sp_addextendedproperty N'MS_DiagramPaneCount', @xp, 'SCHEMA', N'dbo', 'VIEW', N'Vista_MateriaPrima_StockPedido', NULL, NULL
GO
