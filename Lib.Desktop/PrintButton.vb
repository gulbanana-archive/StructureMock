Imports System.Windows.Controls
Imports [Lib].Common

Public Class PrintButton
    Inherits Button

    Public Property Formatter As IFormatter
    Public Property Output As TextBlock

    Protected Overrides Sub OnClick()
        Output.Visibility = Windows.Visibility.Visible
        Output.Text = Printer.Print(Formatter)
    End Sub
End Class
