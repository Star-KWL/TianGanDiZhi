Option Explicit Off

Public Class MainForm
    Dim T As Int32
    Dim D As Int32
    Dim TYear As String
    Dim DYear As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton2.Checked = True Then
            T = (-Year1.Text + 100000) Mod 10
            D = (-Year1.Text + 120000) Mod 12
        Else
            T = (Year1.Text + 10) Mod 10
            D = (Year1.Text + 12) Mod 12
        End If
        SetColor(T, D)
        Select Case T
            Case Is = 0
                TYear = "庚"
            Case Is = 1
                TYear = "辛"
            Case Is = 2
                TYear = "壬"
            Case Is = 3
                TYear = "癸"
            Case Is = 4
                TYear = "甲"
            Case Is = 5
                TYear = "乙"
            Case Is = 6
                TYear = "丙"
            Case Is = 7
                TYear = "丁"
            Case Is = 8
                TYear = "戊"
            Case Is = 9
                TYear = "己"
        End Select
        Select Case D
            Case Is = 0
                DYear = "申"
            Case Is = 1
                DYear = "酉"
            Case Is = 2
                DYear = "戌"
            Case Is = 3
                DYear = "亥"
            Case Is = 4
                DYear = "子"
            Case Is = 5
                DYear = "丑"
            Case Is = 6
                DYear = "寅"
            Case Is = 7
                DYear = "卯"
            Case Is = 8
                DYear = "辰"
            Case Is = 9
                DYear = "巳"
            Case Is = 10
                DYear = "午"
            Case Is = 11
                DYear = "未"
        End Select
        Year2.Text = TYear & DYear
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Year1.Text = ""
        Year2.Text = ""
        T1.ForeColor = Color.White
        T2.ForeColor = Color.White
        T3.ForeColor = Color.White
        T4.ForeColor = Color.White
        T5.ForeColor = Color.White
        T6.ForeColor = Color.White
        T7.ForeColor = Color.White
        T8.ForeColor = Color.White
        T9.ForeColor = Color.White
        T10.ForeColor = Color.White
        D1.ForeColor = Color.White
        D2.ForeColor = Color.White
        D3.ForeColor = Color.White
        D4.ForeColor = Color.White
        D5.ForeColor = Color.White
        D6.ForeColor = Color.White
        D7.ForeColor = Color.White
        D8.ForeColor = Color.White
        D9.ForeColor = Color.White
        D10.ForeColor = Color.White
        D11.ForeColor = Color.White
        D12.ForeColor = Color.White

    End Sub

    Private Sub SetColor(T, D)
        If T = 4 Then T1.ForeColor = Color.FromArgb(39, 206, 215)
        If T = 5 Then T2.ForeColor = Color.FromArgb(39, 206, 216)
        If T = 6 Then T3.ForeColor = Color.FromArgb(39, 206, 217)
        If T = 7 Then T4.ForeColor = Color.FromArgb(39, 206, 218)
        If T = 8 Then T5.ForeColor = Color.FromArgb(39, 206, 219)
        If T = 9 Then T6.ForeColor = Color.FromArgb(39, 206, 220)
        If T = 0 Then T7.ForeColor = Color.FromArgb(39, 206, 221)
        If T = 1 Then T8.ForeColor = Color.FromArgb(39, 206, 222)
        If T = 2 Then T9.ForeColor = Color.FromArgb(39, 206, 223)
        If T = 3 Then T10.ForeColor = Color.FromArgb(39, 206, 224)
        If D = 4 Then D1.ForeColor = Color.FromArgb(39, 206, 225)
        If D = 5 Then D2.ForeColor = Color.FromArgb(39, 206, 226)
        If D = 6 Then D3.ForeColor = Color.FromArgb(39, 206, 227)
        If D = 7 Then D4.ForeColor = Color.FromArgb(39, 206, 228)
        If D = 8 Then D5.ForeColor = Color.FromArgb(39, 206, 229)
        If D = 9 Then D6.ForeColor = Color.FromArgb(39, 206, 230)
        If D = 10 Then D7.ForeColor = Color.FromArgb(39, 206, 231)
        If D = 11 Then D8.ForeColor = Color.FromArgb(39, 206, 232)
        If D = 0 Then D9.ForeColor = Color.FromArgb(39, 206, 233)
        If D = 1 Then D10.ForeColor = Color.FromArgb(39, 206, 234)
        If D = 2 Then D11.ForeColor = Color.FromArgb(39, 206, 235)
        If D = 3 Then D12.ForeColor = Color.FromArgb(39, 206, 236)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then MsgBox("请勿加负号！")
    End Sub
End Class
