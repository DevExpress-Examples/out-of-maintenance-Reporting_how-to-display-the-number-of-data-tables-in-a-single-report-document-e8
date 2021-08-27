<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E835)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

<!-- default file list end -->
# How to display the number of data tables in a single report document


<p>This example illustrates the capability to display two (or more) non-linked data tables in one report separated with a page break.<br />
There are two <strong>Detail Report</strong> bands used, and their <strong>DataSource</strong> and <strong>DataMember</strong> properties are set using the corresponding data source objects.<br />
To force a page break between DetailReportBand items, it's necessary to set the <strong>DetailReportBand.PageBreak</strong> property of the second Detail Report band to <strong>BeforeBand</strong>.</p><p>Note: it's necessary to reset the XtraReport.DataSource property (i.e. set it to nothing). Otherwise, all DetailReportBands contained within your report, will be duplicated according to the primary data source content.</p><p>This sample report document includes two Northwind database tables: they are <strong>"Employees"</strong> and <strong>"Products"</strong>.</p>

<br/>


