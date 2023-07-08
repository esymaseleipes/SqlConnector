Public Class FrmAccessDbWizard
    ' Inherits BaseForm

    Public Property ConnectionParams As AccessConnectionParams


    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(_ConnectionParams As AccessConnectionParams)
        InitializeComponent()
        ConnectionParams = _ConnectionParams
    End Sub

End Class