Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Imports System.Reflection
Public Class Notificacion3
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim OV As Integer
        OV = Val(txtOT.Text)
        MetodoLIMS()
        comandoLIMS = conexionLIMS.CreateCommand
        Dim OT, MetasId, Marca, Modelo, Serie, compañia, cuenta, servicio, equipo, creacion, status, Email, notas, cliente As String
        R = "SELECT [SalesOrderDetails].[SOId],[SalesOrderDetails].[CustomerId], [CompanyName],[FirstName] + ' ' + [MiddleName]+' '+[LastName] AS Cliente, [Phone], [Email], 
                            [SetupCustomerDetails].[PaymentTerms],ROW_NUMBER() OVER(ORDER BY [SalesOrderDetails].SOId ASC) AS Partidad, WOId, [WorkOrderDetails].[CustEquipMapId],[SetupCustomerEquipmentMapping].[InstrumentId], 
                            [EquipmentName],[Model],[Mfr],[SetupCustomerEquipmentMapping].[SrlNo],[WorkOrderDetails].CreatedOn,[WorkOrderDetails].WOStatus,[SetupCustomerDetails].CustAccountNo, SetupServices.ServiceName, isnull(WorkOrderDetails.LabInst,''), SetupCustomerDetails.Email  FROM [MetAs_Live-pruebas].[dbo].[SalesOrderDetails]
                            INNER JOIN [SetupCustomerDetails] ON [SalesOrderDetails].[CustomerId] = [SetupCustomerDetails].[CustomerId]
                            INNER JOIN [WorkOrderDetails] ON [SalesOrderDetails].[SOId] = [WorkOrderDetails].[SOId]
							INNER JOIN [SetupServices] ON [WorkOrderDetails].ServiceId = [SetupServices].ServicesId
                            INNER JOIN [SetupCustomerEquipmentMapping] ON [WorkOrderDetails].[CustEquipMapId] = [SetupCustomerEquipmentMapping].[CustEquipMapId]
                            INNER JOIN [SetUpEquipment] ON [SetupCustomerEquipmentMapping].[EquipId] =  [SetUpEquipment].[EquipId]  WHERE  [SalesOrderDetails].[SOId]='" & OV & "'"
        comandoLIMS.CommandText = R
        lectorLIMS = comandoLIMS.ExecuteReader
        lectorLIMS.Read()
        OT = lectorLIMS(8)
        MetasId = lectorLIMS(10)
        Marca = lectorLIMS(13)
        Modelo = lectorLIMS(12)
        Serie = lectorLIMS(14)
        compañia = lectorLIMS(2)
        cuenta = lectorLIMS(17)
        servicio = lectorLIMS(18)
        equipo = lectorLIMS(11)
        creacion = lectorLIMS(15)
        notas = lectorLIMS(19)
        Email = lectorLIMS(20)
        cliente = lectorLIMS(3)
        Dim objOutlook As Object
        Dim objOutlookMsg As Object

        R = "<html xmlns:v='urn:schemas-microsoft-com:vml'
                                        xmlns:o='urn:schemas-microsoft-com:office:office'
                                        xmlns:w='urn:schemas-microsoft-com:office:word'
                                        xmlns:m='http://schemas.microsoft.com/office/2004/12/omml'
                                        xmlns='http://www.w3.org/TR/REC-html40'>
                                    <head>
                                        <meta http-equiv=Content-Type content='text/html; charset=utf-8'>
                                        <meta name=ProgId content=Word.Document>
                                        <meta name=Generator content='Microsoft Word 15'>
                                        <meta name=Originator content='Microsoft Word 15'>
                                        <link rel=File-List href='Manuel_archivos/filelist.xml'>
                                        <link rel=Edit-Time-Data href='Manuel_archivos/editdata.mso'>
                                        <style>
                                            table 
                                            {
                                                font-family: arial, sans-serif;
                                                border-collapse: collapse;

                                            }
                                            td
                                            {
                                                border: 1px solid #010d03;
                                                text-align: center;
                                                padding: 10px;
                                                background-color:#f5fafa;
                                            }
                                            th 
                                            {
                                                border: 1px solid #9e7795;
                                                text-align: center;
                                                padding: 10px;
                                                background-color: #a8f7af;
                                            }
                                            table.MsoNormalTable
                            	            {
                                                mso-style-name:'Tabla normal';
                            	                mso-tstyle-rowband-size:0;
                            	                mso-tstyle-colband-size:0;
                            	                mso-style-noshow:yes;
                            	                mso-style-priority:99;
                            	                mso-style-parent:'';
                            	                mso-padding-alt:0cm 5.4pt 0cm 5.4pt;
                            	                mso-para-margin:1cm;
                            	                mso-para-margin-bottom:.0001pt;
                            	                mso-pagination:widow-orphan;
                            	                font-size:11.0pt;
                            	                font-family:'Calibri',sans-serif;
                            	                mso-ascii-font-family:Calibri;
                            	                mso-ascii-theme-font:minor-latin;
                            	                mso-hansi-font-family:Calibri;
                            	                mso-hansi-theme-font:minor-latin;
                            	                mso-bidi-font-family:'Times New Roman';
                            	                mso-bidi-theme-font:minor-bidi;
                                            }
                                          </style>
                                    </head>
                                    <body lang=ES-MX link='#0563C1' vlink='#954F72' style='tab-interval:35.4pt'>
                                        <span style=font-size:11.0pt;font-family:Helvetica><b>Estimado Cliente: " & cliente & "</b></span>
                                        <p style='font-size:110%;'>" & compañia & "<p>
                                        <p>Hago de su conocimiento que estaré dando seguimiento a sus servicios de calibración</p>
                                       <TABLE BORDER>
	                                        <TR>
		                                        <TH><b>#OT</b></TH>
		                                        <TH><b>#OV</b></TH>
                                                <TH><b>Equipo</b></TH>
                                                <TH><b>MetAs ID</b></TH>
                                                <TH><b>Marca/Fabricante</b></TH>
                                                <TH><b>Modelo</b></TH>
                                                <TH><b># Serie</b></TH>
                                                <TH><b>Servicio</b></TH>
                                                <TH><b>Status</b></TH>
                                                <TH><b>Notas Técnicas</b></TH>
                                                <TH><b>Fecha de Creación</b></TH>
	                                        </TR>
  		                                        <TD>" & OT & "</TD>
		                                        <TD>" & OV & "</TD>
                                                <TD>" & equipo & "</TD>
                                                <TD>" & MetasId & "</TD>
                                                <TD>" & Marca & "</TD>
                                                <TD>" & Modelo & "</TD>
                                                <TD>" & Serie & "</TD>
                                                <TD>" & servicio & "</TD>
                                                <TD>" & status & "</TD>
                                                <TD>" & notas & "</TD>
                                                <TD>" & creacion & "</TD>
	                                        </TR>
                                            
                                        </TABLE>
                                       <p><span style=font-size:11.0pt;font-family:Helvetica><b>Saludos Cordiales,</b></span></p>
                                        <p><span style=font-size:11.0pt;font-family:Helvetica><b>Atentamente,</b></span></p>
                                        <div Class=WordSection1>
                                        <p class=MsoNormal><span style='font-size:12.0pt;font-family:' Bahnschrift Light',sans-serif'><o:p>&nbsp;</o:p></span></p>
                                        <p class=MsoNormal><span style='font-size:12.0pt;font-family:' Bahnschrift Light',sans-serif'>
                                        Almacén y Envíos.<br>
                                        Equipo de Almacén y Envíos<br>
                                        </span><span style='font-family:' Bahnschrift Light',sans-serif'><a href='mailto:logistica@metas.mx'>logistica<span style='font-size:12.0pt'>@metas.mx</span></a></span><span style='font-size:12.0pt;font-family:' Bahnschrift Light',sans-serif'><br>
                                        Teléfono: 01 (341) 413 61 23<o:p></o:p></span></p>
                                        <p class=MsoNormal>
                                        <span style='mso-ignore:vglayout;position:
                                            absolute;z-index:-1895824384;margin-left:4px;margin-top:12px;width:696px;
                                            height:193px'><img border='0' src='file:///C:\Users\Software TI\Documents\GitHub\image002.png' width='xxxx' height='xxxx'></span>
                                        <p class=MsoNormal style='text-align:justify;text-justify:inter-ideograph;
                                            background:white'><b><span lang=ES style='font-size:8.0pt;color:#002060;
                                            mso-ansi-language:ES'>AVISO DE CONFIDENCIALIDAD -</span></b><span lang=ES
                                            style='font-size:8.0pt;color:#1F497D;mso-ansi-language:ES'>El presente
                                            correo&nbsp; electrónico incluyendo sus anexos, contienen información
                                            confidencial exclusivos de la persona o entidad a quien va dirigido, si usted
                                            no es destinatario del mismo debe proceder a informar mediante correo
                                            electrónico a la persona que lo envió y a borrar de su sistema el correo
                                            original y sus anexos, sin conservar copias. El uso, difusión, distribución o
                                            reproducción del presente mensaje, sin autorización, es prohibido y puede
                                            configurar un delito. MetAs S.A. de C.V. pone a su disposición el aviso de
                                            privacidad en la página web </span><span lang=ES style='mso-ansi-language:ES;
                                            mso-fareast-language:ES'><a href='http://www.metas.com.mx/aviso-privacidad.html'><span lang=ES-MX style='font-size:8.0pt;color:blue;mso-ansi-language:ES-MX;
                                            mso-fareast-language:ES-MX'>http://www.metas.com.mx/aviso-privacidad.html</span></a></span><span
                                            lang=ES style='font-size:8.0pt;color:#9EB0AE;mso-ansi-language:ES'></span><span
                                            lang=ES style='font-size:8.0pt;color:#1F497D;mso-ansi-language:ES'>y que puede
                                            ser de la misma manera suministrada a petición. </span><span lang=ES-TRAD
                                            style='font-size:8.0pt;color:#222222;mso-ansi-language:ES-TRAD'><o:p></o:p></span></p>
                                        <p class=MsoAutoSig><o:p>&nbsp;</o:p></p>"
        R = R & "</body></html>"
            objOutlook = CreateObject("Outlook.Application")
            objOutlookMsg = objOutlook.CreateItem(0)
            With objOutlookMsg
            '.CC = ccalj
            .Subject = "PENDIENTE"
            .HTMLBody = R
                .To = Email
                '.Attachments.Add(pdfPath)
                '.Attachments.Add(pdfPath2)
                .Display
            End With
            'End If
            objOutlookMsg = Nothing
            objOutlook = Nothing

        'Dim Adaptador2 As New SqlDataAdapter
        'Adaptador2.SelectCommand = New SqlCommand
        'Adaptador2.SelectCommand.Connection = conexionLIMS
        'Adaptador2.SelectCommand.CommandText = "FormaDeTransito"
        'Adaptador2.SelectCommand.CommandType = CommandType.StoredProcedure
        'Dim param1a = New SqlParameter("@SOId", SqlDbType.VarChar)
        'Dim param2a = New SqlParameter("@CustomerId", SqlDbType.VarChar)
        'Dim param7a = New SqlParameter("@Cliente", SqlDbType.VarChar)
        'Dim param3a = New SqlParameter("@CompanyName", SqlDbType.VarChar)
        'Dim param4a = New SqlParameter("@telefono", SqlDbType.VarChar)
        'Dim param5a = New SqlParameter("@Email", SqlDbType.VarChar)
        'Dim param6a = New SqlParameter("@terminosPago", SqlDbType.VarChar)
        'param1a.Direction = ParameterDirection.Input
        'param2a.Direction = ParameterDirection.Input
        'param3a.Direction = ParameterDirection.Input
        'param4a.Direction = ParameterDirection.Input
        'param5a.Direction = ParameterDirection.Input
        'param6a.Direction = ParameterDirection.Input
        'param7a.Direction = ParameterDirection.Input
        'param1a.Value = OT
        'param2a.Value = customerID2
        'param3a.Value = companyName2
        'param4a.Value = telefono2
        'param5a.Value = emanil2
        'param6a.Value = terminosPago2
        'param7a.Value = cliente2
        'Adaptador2.SelectCommand.Parameters.Add(param1a)
        'Adaptador2.SelectCommand.Parameters.Add(param2a)
        'Adaptador2.SelectCommand.Parameters.Add(param3a)
        'Adaptador2.SelectCommand.Parameters.Add(param4a)
        'Adaptador2.SelectCommand.Parameters.Add(param5a)
        'Adaptador2.SelectCommand.Parameters.Add(param6a)
        'Adaptador2.SelectCommand.Parameters.Add(param7a)
        'Dim Data2 As New DataSet
        'Adaptador2.Fill(Data2)
        'Data2.DataSetName = "Data1"
        'Dim Datasource2 As New ReportDataSource("DataSet1", Data2.Tables(0))
        'Datasource2.Name = "DataSet1"
        'Datasource2.Value = Data2.Tables(0)
        'Dim p1a As New ReportParameter("SOId", OV)
        'Dim p2a As New ReportParameter("CustomerId", customerID2)
        'Dim p3a As New ReportParameter("CompanyName", companyName2)
        'Dim p4a As New ReportParameter("telefono", telefono2)
        'Dim p5a As New ReportParameter("Email", emanil2)
        'Dim p6a As New ReportParameter("terminosPago", terminosPago2)
        'Dim p7a As New ReportParameter("Cliente", cliente2)
        'Dim Reportes2 As New ReportDataSource("DataSet1", Data2.Tables(0))
        'FrmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        'FrmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource2)
        'FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Software TI\Documents\GitHub\MetasCRM\Reportes\FomaDeTransito.rdlc"
        'FrmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1a, p2a, p3a, p4a, p5a, p6a, p7a})
        'FrmReportes.ReportViewer1.RefreshReport()
        ''FrmReportes.Show()
        'Dim nombreFormaTransito As String = "Forma-de-Transito-OV-"
        'nombreFormaTransito = nombreFormaTransito + OV.ToString
        'MsgBox(nombreFormaTransito)
        'FrmReportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "MyAppNamespace.FomaDeTransito.rdlc"
        'Dim pdfContent2 As Byte() = FrmReportes.ReportViewer1.LocalReport.Render("PDF")
        'Dim pdfPath2 As String = "\\10.10.10.7\Public-2\REPORTES\FORMA_DE_TRANSITO\" & nombreFormaTransito & ".pdf"
        'Dim pdfFile2 As New System.IO.FileStream(pdfPath2, System.IO.FileMode.Create)
        'pdfFile2.Write(pdfContent2, 0, pdfContent2.Length)
        'pdfFile2.Close()
        ''------------------------------------------------------------------------------------
    End Sub
End Class