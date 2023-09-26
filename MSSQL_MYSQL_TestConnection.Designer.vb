<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MSSQL_MYSQL_TestConnection
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
        Me.btnMysql = New System.Windows.Forms.Button()
        Me.btnMSSQL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMysql
        '
        Me.btnMysql.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMysql.Location = New System.Drawing.Point(258, 83)
        Me.btnMysql.Name = "btnMysql"
        Me.btnMysql.Size = New System.Drawing.Size(185, 83)
        Me.btnMysql.TabIndex = 0
        Me.btnMysql.Text = "TEST CONNECTION (MYSQL)"
        Me.btnMysql.UseVisualStyleBackColor = True
        '
        'btnMSSQL
        '
        Me.btnMSSQL.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMSSQL.Location = New System.Drawing.Point(39, 83)
        Me.btnMSSQL.Name = "btnMSSQL"
        Me.btnMSSQL.Size = New System.Drawing.Size(185, 83)
        Me.btnMSSQL.TabIndex = 1
        Me.btnMSSQL.Text = "TEST CONNECTION (MSSQL)"
        Me.btnMSSQL.UseVisualStyleBackColor = True
        '
        'MSSQL_MYSQL_TestConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 288)
        Me.Controls.Add(Me.btnMSSQL)
        Me.Controls.Add(Me.btnMysql)
        Me.Name = "MSSQL_MYSQL_TestConnection"
        Me.Text = "MSSQL_MYSQL_TestConnection.vb"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMysql As Button
    Friend WithEvents btnMSSQL As Button
End Class
