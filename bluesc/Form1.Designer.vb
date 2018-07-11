<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Errorprint = New System.Windows.Forms.Label()
        Me.Qr = New System.Windows.Forms.PictureBox()
        Me.InfoNavi = New System.Windows.Forms.Label()
        Me.Prog = New System.Windows.Forms.Label()
        CType(Me.Qr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Errorprint
        '
        Me.Errorprint.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Errorprint.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errorprint.ForeColor = System.Drawing.SystemColors.Control
        Me.Errorprint.Location = New System.Drawing.Point(-45, 273)
        Me.Errorprint.Name = "Errorprint"
        Me.Errorprint.Size = New System.Drawing.Size(776, 377)
        Me.Errorprint.TabIndex = 4
        '
        'Qr
        '
        Me.Qr.BackColor = System.Drawing.Color.Blue
        Me.Qr.Image = CType(resources.GetObject("Qr.Image"), System.Drawing.Image)
        Me.Qr.Location = New System.Drawing.Point(102, 258)
        Me.Qr.Name = "Qr"
        Me.Qr.Size = New System.Drawing.Size(115, 117)
        Me.Qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Qr.TabIndex = 5
        Me.Qr.TabStop = False
        '
        'InfoNavi
        '
        Me.InfoNavi.BackColor = System.Drawing.Color.Red
        Me.InfoNavi.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoNavi.ForeColor = System.Drawing.SystemColors.Control
        Me.InfoNavi.Location = New System.Drawing.Point(97, 130)
        Me.InfoNavi.Name = "InfoNavi"
        Me.InfoNavi.Size = New System.Drawing.Size(850, 179)
        Me.InfoNavi.TabIndex = 6
        Me.InfoNavi.Text = "システム"
        '
        'Prog
        '
        Me.Prog.AutoSize = True
        Me.Prog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Prog.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prog.ForeColor = System.Drawing.SystemColors.Control
        Me.Prog.Location = New System.Drawing.Point(200, 138)
        Me.Prog.Name = "Prog"
        Me.Prog.Size = New System.Drawing.Size(121, 30)
        Me.Prog.TabIndex = 7
        Me.Prog.Text = "100% 完了"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Prog)
        Me.Controls.Add(Me.InfoNavi)
        Me.Controls.Add(Me.Qr)
        Me.Controls.Add(Me.Errorprint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Qr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Errorprint As Label
    Friend WithEvents Qr As PictureBox
    Friend WithEvents InfoNavi As Label
    Friend WithEvents Prog As Label
End Class
