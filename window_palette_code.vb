Public Class window_palette_code
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(window_palette_code))
        Me.AxWebBrowser1 = New AxSHDocVw.AxWebBrowser
        CType(Me.AxWebBrowser1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWebBrowser1
        '
        Me.AxWebBrowser1.Enabled = True
        Me.AxWebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.AxWebBrowser1.OcxState = CType(resources.GetObject("AxWebBrowser1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWebBrowser1.Size = New System.Drawing.Size(300, 150)
        Me.AxWebBrowser1.TabIndex = 0
        '
        'window_palette_code
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1320, 698)
        Me.Controls.Add(Me.AxWebBrowser1)
        Me.Name = "window_palette_code"
        Me.Text = "Code"
        CType(Me.AxWebBrowser1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub window_palette_code_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = 135
        Me.Top = Screen.PrimaryScreen.Bounds.Height / 2 - 100
        Me.Height = Screen.PrimaryScreen.Bounds.Height / 2 - 100
        Me.Width = Screen.PrimaryScreen.Bounds.Width - 300 - 135
        'AxWebBrowser1.Navigate(Application.StartupPath & "/Templates/application/window_palette_code.htm")
        AxWebBrowser1.Navigate(Application.StartupPath & "/Templates/assets/CodeMirror/2.0/demo/index.html")

    End Sub

    Private Sub window_palette_code_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        AxWebBrowser1.Top = 0
        AxWebBrowser1.Left = 0
        AxWebBrowser1.Height = Me.Height
        AxWebBrowser1.Width = Me.Width
    End Sub
End Class
