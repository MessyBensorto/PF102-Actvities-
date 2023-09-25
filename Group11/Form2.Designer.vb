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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.btnMS = New System.Windows.Forms.Button()
        Me.btnMY = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID NO.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FIRST NAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MIDDLE NAME:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "LAST NAME:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(166, 59)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(162, 20)
        Me.txtID.TabIndex = 4
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(166, 96)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(162, 20)
        Me.txtfname.TabIndex = 5
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(166, 137)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(162, 20)
        Me.txtmname.TabIndex = 6
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(166, 179)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(162, 20)
        Me.txtlname.TabIndex = 7
        '
        'btnMS
        '
        Me.btnMS.Location = New System.Drawing.Point(56, 261)
        Me.btnMS.Name = "btnMS"
        Me.btnMS.Size = New System.Drawing.Size(131, 40)
        Me.btnMS.TabIndex = 8
        Me.btnMS.Text = "REGISTER (MSSQL)"
        Me.btnMS.UseVisualStyleBackColor = True
        '
        'btnMY
        '
        Me.btnMY.Location = New System.Drawing.Point(256, 261)
        Me.btnMY.Name = "btnMY"
        Me.btnMY.Size = New System.Drawing.Size(131, 40)
        Me.btnMY.TabIndex = 9
        Me.btnMY.Text = "REGISTER (MYSQL)"
        Me.btnMY.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 335)
        Me.Controls.Add(Me.btnMY)
        Me.Controls.Add(Me.btnMS)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtmname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents btnMS As Button
    Friend WithEvents btnMY As Button
End Class
