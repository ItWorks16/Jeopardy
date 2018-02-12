<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.tbxInformation = New System.Windows.Forms.TextBox()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbxInformation
        '
        Me.tbxInformation.Location = New System.Drawing.Point(13, 13)
        Me.tbxInformation.Multiline = True
        Me.tbxInformation.Name = "tbxInformation"
        Me.tbxInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbxInformation.Size = New System.Drawing.Size(175, 425)
        Me.tbxInformation.TabIndex = 0
        Me.tbxInformation.Text = resources.GetString("tbxInformation.Text")
        '
        'lblHelp
        '
        Me.lblHelp.Location = New System.Drawing.Point(195, 13)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(145, 404)
        Me.lblHelp.TabIndex = 1
        Me.lblHelp.Text = resources.GetString("lblHelp.Text")
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 450)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.tbxInformation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxInformation As System.Windows.Forms.TextBox
    Friend WithEvents lblHelp As System.Windows.Forms.Label
End Class
