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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ClientDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.clientselect2 = New System.Windows.Forms.Button()
        CType(Me.ClientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cilent Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Client Age"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(198, 53)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(164, 20)
        Me.txtname.TabIndex = 2
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(198, 95)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(180, 20)
        Me.txtage.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 45)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add Client"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ClientDataGridView
        '
        Me.ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientDataGridView.Location = New System.Drawing.Point(157, 256)
        Me.ClientDataGridView.Name = "ClientDataGridView"
        Me.ClientDataGridView.Size = New System.Drawing.Size(321, 163)
        Me.ClientDataGridView.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(341, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(189, 46)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Show Client"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'clientselect2
        '
        Me.clientselect2.Location = New System.Drawing.Point(572, 94)
        Me.clientselect2.Name = "clientselect2"
        Me.clientselect2.Size = New System.Drawing.Size(148, 41)
        Me.clientselect2.TabIndex = 7
        Me.clientselect2.Text = "Select client"
        Me.clientselect2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.clientselect2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ClientDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.ClientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ClientDataGridView As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents clientselect2 As Button
End Class
