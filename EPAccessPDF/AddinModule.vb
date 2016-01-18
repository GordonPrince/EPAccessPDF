Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Diagnostics
Imports AddinExpress.MSO
Imports Access = Microsoft.Office.Interop.Access
Imports System.Drawing
Imports Spire.Pdf
Imports Spire.Pdf.Graphics

'Add-in Express Add-in Module
<GuidAttribute("CAF3AE0E-6315-4EDF-A67F-87CFA367A587"), ProgIdAttribute("EPAccessPDF.AddinModule")> _
Public Class AddinModule
    Inherits AddinExpress.MSO.ADXAddinModule

#Region " Add-in Express automatic code "
 
    'Required by Add-in Express - do not modify
    'the methods within this region
 
    Public Overrides Function GetContainer() As System.ComponentModel.IContainer
        If components Is Nothing Then
            components = New System.ComponentModel.Container
        End If
        GetContainer = components
    End Function
 
    <ComRegisterFunctionAttribute()> _
    Public Shared Sub AddinRegister(ByVal t As Type)
        AddinExpress.MSO.ADXAddinModule.ADXRegister(t)
    End Sub
 
    <ComUnregisterFunctionAttribute()> _
    Public Shared Sub AddinUnregister(ByVal t As Type)
        AddinExpress.MSO.ADXAddinModule.ADXUnregister(t)
    End Sub
 
    Public Overrides Sub UninstallControls()
        MyBase.UninstallControls()
    End Sub
 
#End Region
 
    Public Shared Shadows ReadOnly Property CurrentInstance() As AddinModule
        Get
            Return CType(AddinExpress.MSO.ADXAddinModule.CurrentInstance, AddinModule)
        End Get
    End Property

    Public ReadOnly Property AccessApp() As Access._Application
        Get
            Return CType(HostApplication, Access._Application)
        End Get
    End Property

    Private Sub AdxRibbonRemoveBarCode_OnClick(sender As Object, control As IRibbonControl, pressed As Boolean) Handles AdxRibbonRemoveBarCode.OnClick
        If RemoveBarCode() Then
            MsgBox("Removed bar code from C:\Scans\CBdec1.pdf and" & vbNewLine & "saved the result in C:\Scans\CBdec2.pdf.")
        Else
            MsgBox("Did not remove the bar code properly.")
        End If
    End Sub

    Public Shared Function RemoveBarCode() As Boolean
        'draw a rectangle on top of the bar code
        Dim pdf = New PdfDocument()
        Try
            pdf.LoadFromFile("C:\Scans\CBdec1.pdf")
            Dim page As PdfPageBase
            page = pdf.Pages(0)
            Dim br As New PdfSolidBrush(Color.White)  ' use .Yellow for development
            ' page.Canvas.DrawRectangle(br, New Rectangle(260, 712, 240, 30))
            page.Canvas.DrawRectangle(br, New Rectangle(260, 680, 280, 90))
            Dim strFile As String = "C:\Scans\CBdec2"
            pdf.SaveToFile(strFile & ".xps", FileFormat.XPS)
            pdf.LoadFromXPS(strFile & ".xps")
            pdf.SaveToFile(strFile & ".pdf", FileFormat.PDF)
            Return True
        Catch
            MsgBox(Err.Description, vbExclamation, "RemoveBarCode")
            Return False
        End Try
    End Function

    Private Sub AdxRibbonButtonAbout_OnClick(sender As Object, control As IRibbonControl, pressed As Boolean) Handles AdxRibbonButtonAbout.OnClick
        MsgBox("Access Add-in for Evans | Petree PC" & vbNewLine & _
                "Copyright (c) 2015-2016 by Tekhelps, Inc." & vbNewLine & vbNewLine & _
                "This version built 2016-Jan-4  9:15.", vbInformation)
    End Sub
End Class

