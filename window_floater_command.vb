Public Class window_floater_command
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents AxWebBrowser1 As AxSHDocVw.AxWebBrowser
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(window_floater_command))
        Me.AxWebBrowser1 = New AxSHDocVw.AxWebBrowser
        CType(Me.AxWebBrowser1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWebBrowser1
        '
        Me.AxWebBrowser1.Enabled = True
        Me.AxWebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.AxWebBrowser1.OcxState = CType(resources.GetObject("AxWebBrowser1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWebBrowser1.Size = New System.Drawing.Size(320, 168)
        Me.AxWebBrowser1.TabIndex = 0
        '
        'window_floater_command
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1352, 658)
        Me.Controls.Add(Me.AxWebBrowser1)
        Me.Name = "window_floater_command"
        Me.Text = "window_floater_command"
        CType(Me.AxWebBrowser1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub window_floater_command_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.AxWebBrowser1.Height = Me.Height
        Me.AxWebBrowser1.Width = Me.Width
    End Sub
End Class
