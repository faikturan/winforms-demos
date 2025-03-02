#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace MultiplyLegendsSample
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region Skin 
            chart.Skins = Skins.Metro;
            #endregion
            
            #region Chart Appearance Customization

            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            chart.ChartAreaMargins = new ChartMargins(1, 5, 1, 1);
            chart.ElementsSpacing = 5;
            #endregion

            #region Legend Customization
             chart.LegendsPlacement = ChartPlacement.Outside;
             chart.LegendPosition = ChartDock.Top;
            chart.LegendAlignment = ChartAlignment.Center;

            #endregion
        }
    }
}
