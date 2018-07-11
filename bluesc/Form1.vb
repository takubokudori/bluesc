Public Class Form1

    Dim strMess As String
    Dim strInfo As String
    Dim len As Integer
    Dim now As Integer
    Dim rnd As New System.Random()
    Dim num As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strMess = "問題が発生したため、PC を再起動する必要があります。" & vbCr _
            & "エラー情報を収集しています。多分自動的に再起動します。"
        len = strMess.Length
        strInfo = "この問題と可能な解決方法の詳細については、https://www.microsoft.com/stopcode を参照してください。" & vbCr & vbCr _
            & "サポート担当者に連絡する場合は、この情報を伝えてください:" & vbCr _
            & "停止コード: "
        Dim stopCodes() As String = {"SCREEN_SAVER", "MEMORY_MANAGEMENT", "SET_OF_INVALID_CONTEXT", "SYSTEM_SERVICE_EXCEPTION", "IRQL_GT_ZERO_AT_SYSTEM_SERVICE", "STREAMS_INTERNAL_ERROR"}

        strInfo = strInfo & stopCodes(rnd.Next(0, stopCodes.Length))
        now = 0
        Me.WindowState = FormWindowState.Maximized

        Dim h As Integer = Me.Height ' ディスプレイ縦幅
        Dim w As Integer = Me.Width ' ディスプレイ横幅
        Dim offsetL As Integer = w * 0.114845 ' 左端のオフセット
        Dim offsetU As Integer = offsetL / 2 ' 上端のオフセット
        Dim offsetR As Integer = offsetL ' 右端のオフセット
        Dim bc As Object = Color.FromArgb(16, 113, 170) ' 背景色
        Dim fontsizept As Integer = h \ 40 ' 案内以外のフォントサイズ(pt)
        Dim navifontsizept As Integer = fontsizept * 0.8125
        Dim pimargine As Integer = w \ 70 ' pictureとinfo間のマージンサイズ

        setAll(Errorprint, New Point(offsetL, offsetU), Me.Size, fontsizept, bc)
        setAll(Prog, New Point(offsetL, offsetU + topx(fontsizept) * 5), Prog.Size, fontsizept, bc)

        Qr.BackColor = bc
        Qr.Size = New Size(h / 4, w / 8)
        Qr.Location = New Point(offsetL, h / 2 - Qr.Size.Height / 2)
        setAll(InfoNavi, New Point(offsetL + Qr.Width + pimargine, Qr.Location.Y), New Size(w - (offsetL + Qr.Width + pimargine + offsetR), InfoNavi.Height * 2), navifontsizept, bc)

        Errorprint.Text = strMess
        InfoNavi.Text = strInfo
        updateProg(0)
    End Sub

    Function topx(pt As Integer) As Integer
        ' pt to px
        topx = (pt * 4) \ 3
    End Function

    Function topt(px As Integer) As Integer
        topt = (px * 3) \ 4
    End Function

    Sub setAll(ByRef obj As Label, loc As Point, size As Size, fontsizept As Integer, bc As Object)
        With obj
            .BackColor = bc
            .Location = New Point(loc)
            .Font = New Font(.Font.FontFamily, fontsizept, .Font.Style)
            .Size = New Size(size)
        End With
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try
            updateProg(num + rnd.Next(1, 5))
        Catch ex As OverflowException
            updateProg(-num + rnd.Next(1, 5))
        End Try
        Timer1.Interval = rnd.Next(634, 2776)
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub updateProg(a As Integer)
        num = a
        'If a < 100 Then
        'num = a
        'Else
        ' num = 100 - rnd.Next(1, 10)
        'End If
        Prog.Text = Str(num) + "% 完了"
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Close()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Me.Close()
    End Sub
End Class
