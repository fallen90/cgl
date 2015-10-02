<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ContentContainer = New System.Windows.Forms.Panel()
        Me.Home2 = New CGL.Home()
        Me.ContentContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContentContainer
        '
        Me.ContentContainer.Controls.Add(Me.Home2)
        Me.ContentContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentContainer.Location = New System.Drawing.Point(0, 0)
        Me.ContentContainer.Name = "ContentContainer"
        Me.ContentContainer.Size = New System.Drawing.Size(934, 556)
        Me.ContentContainer.TabIndex = 0
        '
        'Home2
        '
        Me.Home2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home2.Location = New System.Drawing.Point(0, 0)
        Me.Home2.Name = "Home2"
        Me.Home2.Size = New System.Drawing.Size(934, 556)
        Me.Home2.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 556)
        Me.Controls.Add(Me.ContentContainer)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ContentContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContentContainer As System.Windows.Forms.Panel
    Friend WithEvents Home1 As Home
    Friend WithEvents Home2 As CGL.Home
End Class
