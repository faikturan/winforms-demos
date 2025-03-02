#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using System.Reflection;
using Syncfusion.Windows.Forms.PivotChart;

namespace GroupBarDemo
{
    public partial class Form1 : MetroForm
    {
        #region "Constructor"

        public Form1()
        {
            InitializeComponent();
            this.InitializePivotChart();
        }

        #endregion

        #region "PivotChart Settings"

        private void InitializePivotChart()
        {
            // Adding ItemSource to the Control
            this.pivotChart1.ItemSource = new DataCollection();

            // Adding PivotAxis to the Control
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Gender" });
            this.pivotChart1.PivotAxis.Add(new PivotItem { FieldMappingName = "Profession" });

            // Adding PivotLegend to the Control
            this.pivotChart1.PivotLegend.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            // Adding PivotCalculations to the Control
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Salary", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });
            this.pivotChart1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Age", Format = "#,##0", SummaryType = SummaryType.DoubleTotalSum });

            this.pivotChart1.PivotFilters.Add(new FilterExpression { DimensionHeader = "City", DimensionName = "City" });

            this.pivotChart1.AllowDrillDown = true;
            this.pivotChart1.AxisFieldSection.Visible = this.pivotChart1.LegendFieldSection.Visible = this.pivotChart1.ValueFieldSection.Visible =
            this.pivotChart1.FilterFieldSection.Visible = true;
            this.pivotChart1.ChartArea.BorderWidth = 1;
        }

        #endregion
    }
}