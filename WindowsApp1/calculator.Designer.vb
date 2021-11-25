<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_divide = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_multiply = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_decimal = New System.Windows.Forms.Button()
        Me.btn_minus = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.displayTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_4
        '
        Me.btn_4.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_4.Location = New System.Drawing.Point(12, 126)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(75, 49)
        Me.btn_4.TabIndex = 9
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = True
        '
        'btn_divide
        '
        Me.btn_divide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_divide.AutoSize = True
        Me.btn_divide.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_divide.Location = New System.Drawing.Point(255, 71)
        Me.btn_divide.Name = "btn_divide"
        Me.btn_divide.Size = New System.Drawing.Size(75, 51)
        Me.btn_divide.TabIndex = 2
        Me.btn_divide.Text = "÷"
        Me.btn_divide.UseVisualStyleBackColor = True
        '
        'btn_5
        '
        Me.btn_5.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_5.Location = New System.Drawing.Point(93, 126)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(75, 49)
        Me.btn_5.TabIndex = 8
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = True
        '
        'btn_9
        '
        Me.btn_9.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_9.Location = New System.Drawing.Point(174, 71)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(75, 49)
        Me.btn_9.TabIndex = 3
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = True
        '
        'btn_6
        '
        Me.btn_6.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_6.Location = New System.Drawing.Point(174, 126)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(75, 49)
        Me.btn_6.TabIndex = 7
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = True
        '
        'btn_8
        '
        Me.btn_8.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_8.Location = New System.Drawing.Point(93, 71)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(75, 49)
        Me.btn_8.TabIndex = 4
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = True
        '
        'btn_multiply
        '
        Me.btn_multiply.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_multiply.AutoSize = True
        Me.btn_multiply.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multiply.Location = New System.Drawing.Point(255, 126)
        Me.btn_multiply.Name = "btn_multiply"
        Me.btn_multiply.Size = New System.Drawing.Size(75, 51)
        Me.btn_multiply.TabIndex = 6
        Me.btn_multiply.Text = "×"
        Me.btn_multiply.UseVisualStyleBackColor = True
        '
        'btn_7
        '
        Me.btn_7.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_7.Location = New System.Drawing.Point(12, 71)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(75, 49)
        Me.btn_7.TabIndex = 5
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = True
        '
        'btn_1
        '
        Me.btn_1.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.Location = New System.Drawing.Point(12, 181)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(75, 49)
        Me.btn_1.TabIndex = 13
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add.AutoSize = True
        Me.btn_add.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(255, 234)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 51)
        Me.btn_add.TabIndex = 1
        Me.btn_add.Text = "+"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_2
        '
        Me.btn_2.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2.Location = New System.Drawing.Point(93, 181)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(75, 49)
        Me.btn_2.TabIndex = 12
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.AutoEllipsis = True
        Me.btn_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_clear.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(174, 236)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 49)
        Me.btn_clear.TabIndex = 1
        Me.btn_clear.Text = "C"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.Location = New System.Drawing.Point(174, 181)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(75, 49)
        Me.btn_3.TabIndex = 11
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_decimal
        '
        Me.btn_decimal.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_decimal.Location = New System.Drawing.Point(93, 236)
        Me.btn_decimal.Name = "btn_decimal"
        Me.btn_decimal.Size = New System.Drawing.Size(75, 49)
        Me.btn_decimal.TabIndex = 1
        Me.btn_decimal.Text = "."
        Me.btn_decimal.UseVisualStyleBackColor = True
        '
        'btn_minus
        '
        Me.btn_minus.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_minus.AutoSize = True
        Me.btn_minus.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minus.Location = New System.Drawing.Point(255, 181)
        Me.btn_minus.Name = "btn_minus"
        Me.btn_minus.Size = New System.Drawing.Size(75, 51)
        Me.btn_minus.TabIndex = 10
        Me.btn_minus.Text = "-"
        Me.btn_minus.UseVisualStyleBackColor = True
        '
        'btn_0
        '
        Me.btn_0.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_0.Location = New System.Drawing.Point(12, 236)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(75, 49)
        Me.btn_0.TabIndex = 1
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEqual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEqual.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnEqual.FlatAppearance.BorderSize = 0
        Me.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEqual.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEqual.Location = New System.Drawing.Point(12, 291)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(318, 49)
        Me.btnEqual.TabIndex = 14
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = False
        '
        'displayTextBox
        '
        Me.displayTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.displayTextBox.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.displayTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayTextBox.Location = New System.Drawing.Point(12, 12)
        Me.displayTextBox.Name = "displayTextBox"
        Me.displayTextBox.Size = New System.Drawing.Size(319, 53)
        Me.displayTextBox.TabIndex = 0
        Me.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(340, 353)
        Me.Controls.Add(Me.displayTextBox)
        Me.Controls.Add(Me.btn_7)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btn_9)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_0)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_multiply)
        Me.Controls.Add(Me.btn_5)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_6)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_decimal)
        Me.Controls.Add(Me.btn_minus)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_8)
        Me.Controls.Add(Me.btn_divide)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_divide As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_multiply As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_decimal As Button
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_0 As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents displayTextBox As TextBox
End Class
