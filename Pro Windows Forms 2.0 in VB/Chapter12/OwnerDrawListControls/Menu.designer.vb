<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button4 = New System.Windows.Forms.Button
        Me.button3 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(12, 99)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(167, 23)
        Me.button4.TabIndex = 7
        Me.button4.Text = "OwnerDrawTreeViewControl"
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(12, 70)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(167, 23)
        Me.button3.TabIndex = 6
        Me.button3.Text = "OwnerDrawTreeView"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(12, 41)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(167, 23)
        Me.button2.TabIndex = 5
        Me.button2.Text = "VariableOwnerDrawList"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 12)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(167, 23)
        Me.button1.TabIndex = 4
        Me.button1.Text = "SimpleOwnerDrawList"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 150)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button

End Class
