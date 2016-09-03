SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE VIEW [dbo].[Vista_ProductoTerminado]
AS
SELECT        dbo.Articulo.art_id AS Id_Articulo, dbo.Articulo.art_descrip AS Descripcion, dbo.Articulo.art_costo AS Costo, dbo.Articulo.art_margen_beneficio AS Margen_Beneficio, 
                         dbo.Articulo.art_precio AS Precio, dbo.Articulo.art_stock_min AS Stock_Minimo, dbo.Articulo.art_stock_max AS Stock_Maximo, 
                         dbo.Articulo.art_stock_reposicion AS Stock_Reposicion, dbo.Articulo.art_stock_actual AS Stock_Actual, dbo.Articulo.art_maneja_stock AS Maneja_Stock, 
                         dbo.Articulo.fam_id AS Id_Familia, dbo.Familia.fam_descrip AS Familia, dbo.Unidad_Medida.um_descrip AS Unidad_Medida
FROM            dbo.Articulo INNER JOIN
                         dbo.Familia ON dbo.Articulo.fam_id = dbo.Familia.fam_id INNER JOIN
                         dbo.Unidad_Medida ON dbo.Articulo.um_id = dbo.Unidad_Medida.um_id
GO
EXEC sp_addextendedproperty N'MS_DiagramPane1', N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[32] 4[30] 2[20] 3) )"
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
               Bottom = 131
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
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
', 'SCHEMA', N'dbo', 'VIEW', N'Vista_ProductoTerminado', NULL, NULL
GO
DECLARE @xp int
SELECT @xp=1
EXEC sp_addextendedproperty N'MS_DiagramPaneCount', @xp, 'SCHEMA', N'dbo', 'VIEW', N'Vista_ProductoTerminado', NULL, NULL
GO
