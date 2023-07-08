<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSqlDetail
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CmbDatabase = New DevExpress.XtraEditors.LookUpEdit()
        Me.BtnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnTestConnection = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.TxtSqlServer = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCIBtnTEstConnection = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCIDatabase = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CmbDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSqlServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCIBtnTEstConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCIDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CmbDatabase)
        Me.LayoutControl1.Controls.Add(Me.BtnExit)
        Me.LayoutControl1.Controls.Add(Me.BtnOk)
        Me.LayoutControl1.Controls.Add(Me.BtnTestConnection)
        Me.LayoutControl1.Controls.Add(Me.TxtUserName)
        Me.LayoutControl1.Controls.Add(Me.TxtSqlServer)
        Me.LayoutControl1.Controls.Add(Me.TxtPassword)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(609, 86, 592, 575)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(419, 227)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CmbDatabase
        '
        Me.CmbDatabase.Location = New System.Drawing.Point(88, 117)
        Me.CmbDatabase.Name = "CmbDatabase"
        Me.CmbDatabase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbDatabase.Size = New System.Drawing.Size(307, 20)
        Me.CmbDatabase.StyleController = Me.LayoutControl1
        Me.CmbDatabase.TabIndex = 10
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(210, 179)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(197, 36)
        Me.BtnExit.StyleController = Me.LayoutControl1
        Me.BtnExit.TabIndex = 9
        Me.BtnExit.Text = "Έξοδος"
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(12, 179)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(194, 36)
        Me.BtnOk.StyleController = Me.LayoutControl1
        Me.BtnOk.TabIndex = 8
        Me.BtnOk.Text = "Καταχώρηση"
        Me.BtnOk.Visible = False
        '
        'BtnTestConnection
        '
        Me.BtnTestConnection.Location = New System.Drawing.Point(24, 141)
        Me.BtnTestConnection.Name = "BtnTestConnection"
        Me.BtnTestConnection.Size = New System.Drawing.Size(371, 22)
        Me.BtnTestConnection.StyleController = Me.LayoutControl1
        Me.BtnTestConnection.TabIndex = 7
        Me.BtnTestConnection.Text = "Test Connection"
        '
        'TxtUserName
        '
        Me.TxtUserName.EditValue = ""
        Me.TxtUserName.Location = New System.Drawing.Point(88, 69)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(307, 20)
        Me.TxtUserName.StyleController = Me.LayoutControl1
        Me.TxtUserName.TabIndex = 6
        '
        'TxtSqlServer
        '
        Me.TxtSqlServer.EditValue = ""
        Me.TxtSqlServer.Location = New System.Drawing.Point(88, 45)
        Me.TxtSqlServer.Name = "TxtSqlServer"
        Me.TxtSqlServer.Size = New System.Drawing.Size(307, 20)
        Me.TxtSqlServer.StyleController = Me.LayoutControl1
        Me.TxtSqlServer.TabIndex = 5
        '
        'TxtPassword
        '
        Me.TxtPassword.EditValue = ""
        Me.TxtPassword.Location = New System.Drawing.Point(88, 93)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(307, 20)
        Me.TxtPassword.StyleController = Me.LayoutControl1
        Me.TxtPassword.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(419, 227)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.BtnOk
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 167)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(74, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(198, 40)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        Me.LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.BtnExit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(198, 167)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(49, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(201, 40)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem2, Me.LCIBtnTEstConnection, Me.LCIDatabase})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(399, 167)
        Me.LayoutControlGroup2.Text = "Στοιχεία Σύνδεσης SqlServer"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TxtPassword
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(375, 24)
        Me.LayoutControlItem1.Text = "Password"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TxtUserName
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(375, 24)
        Me.LayoutControlItem3.Text = "User Name"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(52, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TxtSqlServer
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(375, 24)
        Me.LayoutControlItem2.Text = "Sql Server"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(52, 13)
        '
        'LCIBtnTEstConnection
        '
        Me.LCIBtnTEstConnection.Control = Me.BtnTestConnection
        Me.LCIBtnTEstConnection.Location = New System.Drawing.Point(0, 96)
        Me.LCIBtnTEstConnection.Name = "LCIBtnTEstConnection"
        Me.LCIBtnTEstConnection.Size = New System.Drawing.Size(375, 26)
        Me.LCIBtnTEstConnection.TextSize = New System.Drawing.Size(0, 0)
        Me.LCIBtnTEstConnection.TextVisible = False
        '
        'LCIDatabase
        '
        Me.LCIDatabase.Control = Me.CmbDatabase
        Me.LCIDatabase.Location = New System.Drawing.Point(0, 72)
        Me.LCIDatabase.Name = "LCIDatabase"
        Me.LCIDatabase.Size = New System.Drawing.Size(375, 24)
        Me.LCIDatabase.Text = "DataBase"
        Me.LCIDatabase.TextSize = New System.Drawing.Size(52, 13)
        Me.LCIDatabase.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'FrmSqlDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 227)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmSqlDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Παράμετροι Σύνδεσης με Sql Server"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CmbDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSqlServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCIBtnTEstConnection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCIDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BtnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnTestConnection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtSqlServer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LCIBtnTEstConnection As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CmbDatabase As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LCIDatabase As DevExpress.XtraLayout.LayoutControlItem
End Class
