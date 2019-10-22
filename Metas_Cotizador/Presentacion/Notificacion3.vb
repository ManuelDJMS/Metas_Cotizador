Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Imports System.Reflection
Public Class Notificacion3
    Dim OV, cant As Integer
    Dim filas As Boolean = False
    Dim OT, MetasId, Marca, Modelo, Serie, compañia, cuenta, servicio, equipo, creacion, status, Email, notas, cliente, instrucciones As String
    Dim nfilas(14) As String
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        OV = Val(txtOT.Text)
        MetodoLIMS()
        comandoLIMS = conexionLIMS.CreateCommand
        R = "SELECT [SalesOrderDetails].[SOId],[SalesOrderDetails].[CustomerId], [CompanyName],[FirstName] + ' ' + [MiddleName]+' '+[LastName] AS Cliente, [Phone], [Email], 
                            [SetupCustomerDetails].[PaymentTerms],ROW_NUMBER() OVER(ORDER BY [SalesOrderDetails].SOId ASC) AS Partidad, WOId, [WorkOrderDetails].[CustEquipMapId],
                            [SetupCustomerEquipmentMapping].[InstrumentId],[EquipmentName],[Model],[Mfr],[SetupCustomerEquipmentMapping].[SrlNo],[WorkOrderDetails].CreatedOn,
                            [WorkOrderDetails].WOStatus,[SetupCustomerDetails].CustAccountNo, SetupServices.ServiceName, isnull(WorkOrderDetails.LabInst,''), SetupCustomerDetails.Email,isnull([SpcInst],'') 
                            FROM [MetAs_Live-pruebas].[dbo].[SalesOrderDetails]
                            INNER JOIN [SetupCustomerDetails] ON [SalesOrderDetails].[CustomerId] = [SetupCustomerDetails].[CustomerId]
                            INNER JOIN [WorkOrderDetails] ON [SalesOrderDetails].[SOId] = [WorkOrderDetails].[SOId]
							INNER JOIN [SetupServices] ON [WorkOrderDetails].ServiceId = [SetupServices].ServicesId
                            INNER JOIN [SetupCustomerEquipmentMapping] ON [WorkOrderDetails].[CustEquipMapId] = [SetupCustomerEquipmentMapping].[CustEquipMapId]
                            INNER JOIN [SetUpEquipment] ON [SetupCustomerEquipmentMapping].[EquipId] =  [SetUpEquipment].[EquipId]  WHERE  [SalesOrderDetails].[SOId]='" & OV & "'"
        comandoLIMS.CommandText = R
        lectorLIMS = comandoLIMS.ExecuteReader
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
                                                    
                                                }
                                                th 
                                                {
                                                    border: 1px solid #010d03;
                                                    text-align: center;
                                                    padding: 10px;
                                                    background-color: #3ABD59;
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
                                            "
        While lectorLIMS.Read()
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
            instrucciones = lectorLIMS(21)
            Dim nfila = New String() {"Colombia", "Perú", "Ecuador", "USA", "Brasil"}
            Dim objOutlook As Object
            Dim objOutlookMsg As Object
            If cant = 0 Then
                R = R & "<TABLE BORDER>
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
                                                    <TH><b>Instrucciones de Lab</b></TH>
                                                    <TH><b>Observaciones</b></TH>
                                             </TR>"
                agregarfilas()
            Else
                If cant = 1 Then
                    agregarfilas()
                Else
                    Select Case cant
                        Case 2
                            agregarfilas()
                        Case 3
                            agregarfilas()
                        Case 4
                            agregarfilas()
                        Case 5
                            agregarfilas()
                        Case 6
                            agregarfilas()
                        Case 7
                            agregarfilas()
                        Case 8
                            agregarfilas()
                        Case 9
                            agregarfilas()
                        Case 10
                            agregarfilas()
                        Case 11
                            agregarfilas()
                        Case 12
                            agregarfilas()
                        Case 13
                            agregarfilas()
                        Case 14
                            agregarfilas()
                        Case 15
                            agregarfilas()
                        Case 16
                            agregarfilas()
                        Case 17
                            agregarfilas()
                        Case 18
                            agregarfilas()
                        Case 19
                            agregarfilas()
                        Case 20
                            agregarfilas()
                        Case 21
                            agregarfilas()
                        Case 22
                            agregarfilas()
                        Case 23
                            agregarfilas()
                        Case 24
                            agregarfilas()
                        Case 27
                            agregarfilas()
                        Case 26
                            agregarfilas()
                        Case 27
                            agregarfilas()
                        Case 28
                            agregarfilas()
                        Case 29
                            agregarfilas()
                        Case 30
                            agregarfilas()
                    End Select
                End If
            End If
                cant = cant + 1
        End While
        R = R & "           </TABLE>
                                           <p><span style=font-size:11.0pt;font-family:Helvetica><b>Saludos Cordiales</b></span></p>
                                            <p><span style=font-size:11.0pt;font-family:Helvetica><b>Atentamente</b></span></p>
                                            <div Class=WordSection1
>
                                            <p class=MsoNormal><span style='font-size:12.0pt;font-family:' Bahnschrift Light',sans-serif'><o:p>&nbsp;</o:p></span></p>
                                            <p class=MsoNormal><span style='font-size:12.0pt;font-family:' Bahnschrift Light',sans-serif'>
                                            Almacén y Envíos.<br>
                                            Equipo de Almacén y Envíos<br>
                                            </span><span style='font-family:' Bahnschrift Light',sans-serif'><a href='mailto:logistica@metas.mx'>logistica<span style='font-size:12.0pt'>@metas.mx</span></a></span><span style='font-size:12.0pt;font-family:' Bahnschrift Light',sans-serif'><br>
                                            Teléfono: 01 (341) 413 61 23<o:p></o:p></span></p>
                                            <p class=MsoNormal>
                                            <span style='mso-ignore:vglayou/t;position:
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
    End Sub
    Public Sub agregarfilas()
        R = R & " <TR>
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
                                                    <TD>" & instrucciones & "</TD>
                                                     <TD></TD>
                    </TR>
                                   "
    End Sub
End Class