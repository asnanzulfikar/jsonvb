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
        Me.components = New System.ComponentModel.Container()
        Me.btrefresh = New System.Windows.Forms.Button()
        Me.btdisconnect = New System.Windows.Forms.Button()
        Me.btconnect = New System.Windows.Forms.Button()
        Me.cbbaudrate = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbport = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btrefresh
        '
        Me.btrefresh.Location = New System.Drawing.Point(268, 17)
        Me.btrefresh.Name = "btrefresh"
        Me.btrefresh.Size = New System.Drawing.Size(121, 23)
        Me.btrefresh.TabIndex = 10
        Me.btrefresh.Text = "Refresh Port"
        Me.btrefresh.UseVisualStyleBackColor = True
        '
        'btdisconnect
        '
        Me.btdisconnect.Location = New System.Drawing.Point(93, 120)
        Me.btdisconnect.Name = "btdisconnect"
        Me.btdisconnect.Size = New System.Drawing.Size(121, 23)
        Me.btdisconnect.TabIndex = 9
        Me.btdisconnect.Text = "Disconnect"
        Me.btdisconnect.UseVisualStyleBackColor = True
        '
        'btconnect
        '
        Me.btconnect.Location = New System.Drawing.Point(93, 87)
        Me.btconnect.Name = "btconnect"
        Me.btconnect.Size = New System.Drawing.Size(121, 23)
        Me.btconnect.TabIndex = 5
        Me.btconnect.Text = "Connect"
        Me.btconnect.UseVisualStyleBackColor = True
        '
        'cbbaudrate
        '
        Me.cbbaudrate.FormattingEnabled = True
        Me.cbbaudrate.Location = New System.Drawing.Point(93, 55)
        Me.cbbaudrate.Name = "cbbaudrate"
        Me.cbbaudrate.Size = New System.Drawing.Size(121, 21)
        Me.cbbaudrate.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btrefresh)
        Me.GroupBox1.Controls.Add(Me.btdisconnect)
        Me.GroupBox1.Controls.Add(Me.btconnect)
        Me.GroupBox1.Controls.Add(Me.cbbaudrate)
        Me.GroupBox1.Controls.Add(Me.cbport)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 148)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COM PORT SELECT"
        '
        'cbport
        '
        Me.cbport.FormattingEnabled = True
        Me.cbport.Location = New System.Drawing.Point(93, 19)
        Me.cbport.Name = "cbport"
        Me.cbport.Size = New System.Drawing.Size(121, 21)
        Me.cbport.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Baud Rate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "COM"
        '
        'Timer1
        '
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RichTextBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(427, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(604, 143)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Json Debug"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(6, 15)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(592, 133)
        Me.RichTextBox2.TabIndex = 1
        Me.RichTextBox2.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(429, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "db status"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 166)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(54, 18)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 190)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1019, 420)
        Me.WebBrowser1.TabIndex = 6
        Me.WebBrowser1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 613)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "Form1"
        Me.Text = "Telegram Notification Service"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btrefresh As System.Windows.Forms.Button
    Friend WithEvents btdisconnect As System.Windows.Forms.Button
    Friend WithEvents btconnect As System.Windows.Forms.Button
    Friend WithEvents cbbaudrate As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbport As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser

End Class
