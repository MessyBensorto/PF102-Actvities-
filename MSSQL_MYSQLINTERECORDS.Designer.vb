<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MSSQL_MYSQLINTERECORDS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.btnMySql = New System.Windows.Forms.Button()
        Me.btnMsSql = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Firstname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middlename"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lastname"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(186, 34)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(134, 28)
        Me.txtID.TabIndex = 4
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(186, 74)
        Me.txtFname.Multiline = True
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(134, 28)
        Me.txtFname.TabIndex = 5
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(186, 119)
        Me.txtMname.Multiline = True
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(134, 28)
        Me.txtMname.TabIndex = 6
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(186, 161)
        Me.txtLname.Multiline = True
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(134, 28)
        Me.txtLname.TabIndex = 7
        '
        'btnMySql
        '
        Me.btnMySql.Location = New System.Drawing.Point(326, 222)
        Me.btnMySql.Name = "btnMySql"
        Me.btnMySql.Size = New System.Drawing.Size(135, 59)
        Me.btnMySql.TabIndex = 8
        Me.btnMySql.Text = "REGSITER (MYSQL)"
        Me.btnMySql.UseVisualStyleBackColor = True
        '
        'btnMsSql
        '
        Me.btnMsSql.Location = New System.Drawing.Point(101, 222)
        Me.btnMsSql.Name = "btnMsSql"
        Me.btnMsSql.Size = New System.Drawing.Size(135, 59)
        Me.btnMsSql.TabIndex = 9
        Me.btnMsSql.Text = "REGSITER (MSSQL)"
        Me.btnMsSql.UseVisualStyleBackColor = True
        '
        'MSSQL_MYSQLINTERECORDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 312)
        Me.Controls.Add(Me.btnMsSql)
        Me.Controls.Add(Me.btnMySql)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MSSQL_MYSQLINTERECORDS"
        Me.Text = "MSSQL_MYSQLINTERECORDS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents btnMySql As Button
    Friend WithEvents btnMsSql As Button
End Class
