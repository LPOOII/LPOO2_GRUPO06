using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace ClasesBase
{
    public class ConversorDeEstados : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                string nombreDelEstado = value.ToString();
                if (nombreDelEstado == "Libre")
                {
                    BrushConverter bc = new BrushConverter();
                    SolidColorBrush bcColor = (SolidColorBrush)bc.ConvertFromString("Green");
                    return bcColor;
                }
                else
                {
                    if (nombreDelEstado == "Reservada")
                    {
                        BrushConverter bc = new BrushConverter();
                        SolidColorBrush bcColor = (SolidColorBrush)bc.ConvertFromString("Orange");
                        return bcColor;
                    }
                    else
                    {
                        if (nombreDelEstado == "Ocupada")
                        {
                            BrushConverter bc = new BrushConverter();
                            SolidColorBrush bcColor = (SolidColorBrush)bc.ConvertFromString("Red");
                            return bcColor;
                        }
                        else
                        {
                            if (nombreDelEstado == "Pidiendo")
                            {
                                BrushConverter bc = new BrushConverter();
                                SolidColorBrush bcColor = (SolidColorBrush)bc.ConvertFromString("Violet");
                                return bcColor;
                            }
                            else
                            {
                                if (nombreDelEstado == "En espera")
                                {
                                    BrushConverter bc = new BrushConverter();
                                    SolidColorBrush bcColor = (SolidColorBrush)bc.ConvertFromString("Aquamarine");
                                    return bcColor;
                                }
                                else
                                {
                                    if (nombreDelEstado == "Servidos")
                                    {
                                        BrushConverter bc = new BrushConverter();
                                        SolidColorBrush bcColor = (SolidColorBrush)bc.ConvertFromString("Pink");
                                        return bcColor;
                                    }
                                    else
                                    {
                                        if (nombreDelEstado == "Esperando cuenta")
                                        {
                                            BrushConverter bc = new BrushConverter();
                                            SolidColorBrush bcColor = (SolidColorBrush)bc.ConvertFromString("LightBlue");
                                            return bcColor;
                                        }
                                        else
                                        {
                                            if (nombreDelEstado == "Pagando")
                                            {
                                                BrushConverter bc = new BrushConverter();
                                                SolidColorBrush bcColor = (SolidColorBrush)bc.ConvertFromString("DarkGreen");
                                                return bcColor;
                                            }
                                            else
                                            {
                                                return null;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
