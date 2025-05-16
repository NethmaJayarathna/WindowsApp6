<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Lable2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.OrderDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OrderComboBox = New System.Windows.Forms.ComboBox()
        Me.txtclientname = New System.Windows.Forms.TextBox()
        Me.btnselect = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Date And Time"
        Me.Label1.UseMnemonic = False
        '
        'Lable2
        '
        Me.Lable2.AutoSize = True
        Me.Lable2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lable2.Location = New System.Drawing.Point(93, 101)
        Me.Lable2.Name = "Lable2"
        Me.Lable2.Size = New System.Drawing.Size(49, 17)
        Me.Lable2.TabIndex = 1
        Me.Lable2.Text = "Client"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Paid"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Amount"
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(290, 208)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(212, 20)
        Me.txtamount.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(155, 415)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(314, 190)
        Me.DataGridView1.TabIndex = 6
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(93, 265)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(142, 58)
        Me.btnadd.TabIndex = 9
        Me.btnadd.Text = "Add order"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'OrderDateTimePicker
        '
        Me.OrderDateTimePicker.Location = New System.Drawing.Point(290, 46)
        Me.OrderDateTimePicker.Name = "OrderDateTimePicker"
        Me.OrderDateTimePicker.Size = New System.Drawing.Size(212, 20)
        Me.OrderDateTimePicker.TabIndex = 10
        '
        'OrderComboBox
        '
        Me.OrderComboBox.FormattingEnabled = True
        Me.OrderComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.OrderComboBox.Location = New System.Drawing.Point(290, 149)
        Me.OrderComboBox.Name = "OrderComboBox"
        Me.OrderComboBox.Size = New System.Drawing.Size(212, 21)
        Me.OrderComboBox.TabIndex = 11
        '
        'txtclientname
        '
        Me.txtclientname.Location = New System.Drawing.Point(290, 98)
        Me.txtclientname.Name = "txtclientname"
        Me.txtclientname.Size = New System.Drawing.Size(212, 20)
        Me.txtclientname.TabIndex = 12
        '
        'btnselect
        '
        Me.btnselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.Location = New System.Drawing.Point(548, 106)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(202, 43)
        Me.btnselect.TabIndex = 14
        Me.btnselect.Text = "Select Client"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 637)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.txtclientname)
        Me.Controls.Add(Me.OrderComboBox)
        Me.Controls.Add(Me.OrderDateTimePicker)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lable2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Lable2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtamount As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnadd As Button
    Friend WithEvents OrderDateTimePicker As DateTimePicker
    Friend WithEvents OrderComboBox As ComboBox
    Friend WithEvents txtclientname As TextBox
    Friend WithEvents btnselect As Button
End Class
