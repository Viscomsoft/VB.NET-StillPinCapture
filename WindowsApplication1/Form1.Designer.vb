<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxVideoCap1 = New AxVIDEOCAPLib.AxVideoCap()
        Me.cbovideodevice = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbostillpinformat = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxVideoCap1
        '
        Me.AxVideoCap1.Enabled = True
        Me.AxVideoCap1.Location = New System.Drawing.Point(11, 11)
        Me.AxVideoCap1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AxVideoCap1.Name = "AxVideoCap1"
        Me.AxVideoCap1.OcxState = CType(resources.GetObject("AxVideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoCap1.Size = New System.Drawing.Size(422, 277)
        Me.AxVideoCap1.TabIndex = 0
        '
        'cbovideodevice
        '
        Me.cbovideodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideodevice.FormattingEnabled = True
        Me.cbovideodevice.Location = New System.Drawing.Point(151, 307)
        Me.cbovideodevice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbovideodevice.Name = "cbovideodevice"
        Me.cbovideodevice.Size = New System.Drawing.Size(215, 20)
        Me.cbovideodevice.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 307)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Video Device"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 344)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Still Pin Format"
        '
        'cbostillpinformat
        '
        Me.cbostillpinformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostillpinformat.FormattingEnabled = True
        Me.cbostillpinformat.Location = New System.Drawing.Point(151, 344)
        Me.cbostillpinformat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbostillpinformat.Name = "cbostillpinformat"
        Me.cbostillpinformat.Size = New System.Drawing.Size(215, 20)
        Me.cbostillpinformat.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(377, 305)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 27)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(377, 344)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 27)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Snapshot"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 391)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbostillpinformat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbovideodevice)
        Me.Controls.Add(Me.AxVideoCap1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxVideoCap1 As AxVIDEOCAPLib.AxVideoCap
    Friend WithEvents cbovideodevice As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbostillpinformat As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
