Namespace DisplayTwoTables
	Partial Public Class EmployeesAndProducts
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.employeesTableAdapter = New DisplayTwoTables.DataSet1TableAdapters.EmployeesTableAdapter()
			Me.dataSet11 = New DisplayTwoTables.DataSet1()
			Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportHeader1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.productsTableAdapter1 = New DisplayTwoTables.DataSet1TableAdapters.ProductsTableAdapter()
			Me.xrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.HeightF = 0F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageHeader
			' 
			Me.PageHeader.HeightF = 30F
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.HeightF = 30F
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.ReportHeader})
			Me.DetailReport.DataAdapter = Me.employeesTableAdapter
			Me.DetailReport.DataMember = "Employees"
			Me.DetailReport.DataSource = Me.dataSet11
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			Me.DetailReport.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.DetailReport.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrLabel7, Me.xrLabel2, Me.xrPictureBox1, Me.xrLabel1})
			Me.Detail1.HeightF = 117F
			Me.Detail1.Name = "Detail1"
			Me.Detail1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLine1
			' 
			Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(17F, 100F)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrLine1.SizeF = New System.Drawing.SizeF(625F, 8F)
			' 
			' xrLabel7
			' 
			Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.Title")})
			Me.xrLabel7.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(17F, 0F)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.SizeF = New System.Drawing.SizeF(158F, 25F)
			Me.xrLabel7.Text = "xrLabel7"
			Me.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.City")})
			Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(350F, 67F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(117F, 25F)
			Me.xrLabel2.Text = "xrLabel2"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Employees.Photo")})
			Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(508F, 0F)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(108F, 92F)
			Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(225F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(242F, 25F)
			Me.xrLabel1.Text = "[LastName], [FirstName]"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel8})
			Me.ReportHeader.HeightF = 60F
			Me.ReportHeader.Name = "ReportHeader"
			Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel8
			' 
			Me.xrLabel8.BackColor = System.Drawing.Color.Khaki
			Me.xrLabel8.Font = New System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel8.SizeF = New System.Drawing.SizeF(650F, 33F)
			Me.xrLabel8.Text = "Employees"
			Me.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' DetailReport1
			' 
			Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail2, Me.ReportHeader1})
			Me.DetailReport1.DataAdapter = Me.productsTableAdapter1
			Me.DetailReport1.DataMember = "Products"
			Me.DetailReport1.DataSource = Me.dataSet11
			Me.DetailReport1.Level = 1
			Me.DetailReport1.Name = "DetailReport1"
			Me.DetailReport1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.DetailReport1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
			Me.DetailReport1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' Detail2
			' 
			Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel6, Me.xrLabel5, Me.xrLabel4, Me.xrLabel3})
			Me.Detail2.EvenStyleName = "xrControlStyle1"
			Me.Detail2.HeightF = 25F
			Me.Detail2.Name = "Detail2"
			Me.Detail2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail2.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.Detail2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel6
			' 
			Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsOnOrder")})
			Me.xrLabel6.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(483F, 0F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(83F, 25F)
			Me.xrLabel6.Text = "xrLabel6"
			Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel5
			' 
			Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsInStock")})
			Me.xrLabel5.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(575F, 0F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(75F, 25F)
			Me.xrLabel5.Text = "xrLabel5"
			Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel4
			' 
			Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.QuantityPerUnit")})
			Me.xrLabel4.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(275F, 0F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(200F, 25F)
			Me.xrLabel4.Text = "xrLabel4"
			Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.xrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(267F, 25F)
			Me.xrLabel3.Text = "xrLabel3"
			Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' ReportHeader1
			' 
			Me.ReportHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel9})
			Me.ReportHeader1.HeightF = 64F
			Me.ReportHeader1.Name = "ReportHeader1"
			Me.ReportHeader1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.ReportHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel9
			' 
			Me.xrLabel9.BackColor = System.Drawing.Color.PaleGoldenrod
			Me.xrLabel9.Font = New System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel9.Name = "xrLabel9"
			Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel9.SizeF = New System.Drawing.SizeF(650F, 33F)
			Me.xrLabel9.Text = "Products"
			Me.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' productsTableAdapter1
			' 
			Me.productsTableAdapter1.ClearBeforeFill = True
			' 
			' xrControlStyle1
			' 
			Me.xrControlStyle1.BackColor = System.Drawing.Color.AntiqueWhite
			Me.xrControlStyle1.BorderColor = System.Drawing.Color.Black
			Me.xrControlStyle1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
			Me.xrControlStyle1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrControlStyle1.BorderWidth = 1
			Me.xrControlStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75F)
			Me.xrControlStyle1.ForeColor = System.Drawing.Color.Black
			Me.xrControlStyle1.Name = "xrControlStyle1"
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' EmployeesAndProducts
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter, Me.DetailReport, Me.DetailReport1, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.xrControlStyle1})
			Me.Version = "13.1"
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private employeesTableAdapter As DisplayTwoTables.DataSet1TableAdapters.EmployeesTableAdapter
		Private dataSet11 As DataSet1
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail2 As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private ReportHeader1 As DevExpress.XtraReports.UI.ReportHeaderBand
		Private productsTableAdapter1 As DisplayTwoTables.DataSet1TableAdapters.ProductsTableAdapter
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private xrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
		Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
	End Class
End Namespace
