Imports System.Runtime.InteropServices


<ComVisible(True)> _
Public Interface IAddInUtilities
    Sub ImportData()
    Sub RemoveBarCode()
End Interface

<ComVisible(True)> _
<ClassInterface(ClassInterfaceType.None)> _
Public Class AddInUtilities
    Implements IAddInUtilities

    Public Sub ImportData() Implements IAddInUtilities.ImportData
        MsgBox("ImportData() called.")
    End Sub

    Public Sub RemoveBarCode() Implements IAddInUtilities.RemoveBarCode
        AddinModule.RemoveBarCode()
    End Sub
End Class

