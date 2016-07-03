Imports System.Windows.Controls
Imports [Lib].Common

Public Class DebugButton
    Inherits Button

    Public Property Formatter As IFormatter

    Protected Overrides Sub OnClick()
        Printer.Print(Formatter)
    End Sub
End Class
