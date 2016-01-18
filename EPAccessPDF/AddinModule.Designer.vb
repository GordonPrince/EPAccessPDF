Imports System.Windows.Forms

Partial Public Class AddinModule

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        Application.EnableVisualStyles()

        'This call is required by the Component Designer
        InitializeComponent()

        'Please add any initialization code to the AddinInitialize event handler

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.AdxRibbonTabPDF = New AddinExpress.MSO.ADXRibbonTab(Me.components)
        Me.AdxRibbonGroupAppeals = New AddinExpress.MSO.ADXRibbonGroup(Me.components)
        Me.AdxRibbonRemoveBarCode = New AddinExpress.MSO.ADXRibbonButton(Me.components)
        Me.AdxRibbonButtonAbout = New AddinExpress.MSO.ADXRibbonButton(Me.components)
        Me.AdxRibbonSeparator1 = New AddinExpress.MSO.ADXRibbonSeparator(Me.components)
        '
        'AdxRibbonTabPDF
        '
        Me.AdxRibbonTabPDF.Caption = "PDF"
        Me.AdxRibbonTabPDF.Controls.Add(Me.AdxRibbonGroupAppeals)
        Me.AdxRibbonTabPDF.Id = "adxRibbonTab_ec0f399ef6914042b596ea677927ed96"
        Me.AdxRibbonTabPDF.Ribbons = AddinExpress.MSO.ADXRibbons.msrAccessDatabase
        '
        'AdxRibbonGroupAppeals
        '
        Me.AdxRibbonGroupAppeals.Caption = "Appeals"
        Me.AdxRibbonGroupAppeals.Controls.Add(Me.AdxRibbonRemoveBarCode)
        Me.AdxRibbonGroupAppeals.Controls.Add(Me.AdxRibbonSeparator1)
        Me.AdxRibbonGroupAppeals.Controls.Add(Me.AdxRibbonButtonAbout)
        Me.AdxRibbonGroupAppeals.Id = "adxRibbonGroup_275c5e96d9cf451481085e0fdd919bae"
        Me.AdxRibbonGroupAppeals.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.AdxRibbonGroupAppeals.Ribbons = AddinExpress.MSO.ADXRibbons.msrAccessDatabase
        '
        'AdxRibbonRemoveBarCode
        '
        Me.AdxRibbonRemoveBarCode.Caption = "Remove Bar Code"
        Me.AdxRibbonRemoveBarCode.Id = "adxRibbonButton_7f49369b8edf46379a59c5bbd175bb82"
        Me.AdxRibbonRemoveBarCode.ImageMso = "ViewMasterDocumentViewClassic"
        Me.AdxRibbonRemoveBarCode.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.AdxRibbonRemoveBarCode.Ribbons = AddinExpress.MSO.ADXRibbons.msrAccessDatabase
        Me.AdxRibbonRemoveBarCode.ScreenTip = "Remove bar code from bottom right corner of C:\Scans\CBdec1.pdf."
        Me.AdxRibbonRemoveBarCode.Size = AddinExpress.MSO.ADXRibbonXControlSize.Large
        '
        'AdxRibbonButtonAbout
        '
        Me.AdxRibbonButtonAbout.Caption = "About"
        Me.AdxRibbonButtonAbout.Id = "adxRibbonButton_0637dd262848403199e87fc7f2f594a5"
        Me.AdxRibbonButtonAbout.ImageMso = "Help"
        Me.AdxRibbonButtonAbout.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.AdxRibbonButtonAbout.Ribbons = AddinExpress.MSO.ADXRibbons.msrAccessDatabase
        Me.AdxRibbonButtonAbout.ScreenTip = "Display information about this Add-in."
        Me.AdxRibbonButtonAbout.Size = AddinExpress.MSO.ADXRibbonXControlSize.Large
        '
        'AdxRibbonSeparator1
        '
        Me.AdxRibbonSeparator1.Id = "adxRibbonSeparator_4ff5aa60d34d4f72963c688e5ebd1fb1"
        Me.AdxRibbonSeparator1.Ribbons = AddinExpress.MSO.ADXRibbons.msrAccessDatabase
        '
        'AddinModule
        '
        Me.AddinName = "EPAccessPDF"
        Me.SupportedApps = AddinExpress.MSO.ADXOfficeHostApp.ohaAccess

    End Sub
    Private WithEvents AdxRibbonTabPDF As AddinExpress.MSO.ADXRibbonTab
    Friend WithEvents AdxRibbonGroupAppeals As AddinExpress.MSO.ADXRibbonGroup
    Friend WithEvents AdxRibbonRemoveBarCode As AddinExpress.MSO.ADXRibbonButton
    Friend WithEvents AdxRibbonButtonAbout As AddinExpress.MSO.ADXRibbonButton
    Friend WithEvents AdxRibbonSeparator1 As AddinExpress.MSO.ADXRibbonSeparator

End Class

