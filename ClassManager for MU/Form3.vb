Public Class Form3
    ' 時刻を秒に変更した値を格納する変数
    Private intSec As Integer

    ''' <summary>
    ''' フォームがロードされたら(画面起動時)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ラベルの値を0:00に変更(初期設定)
        Me.TextBox1.Text = "0:00"

    End Sub

    ''' <summary>
    ''' STARTボタンが押されたら
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        ' 間隔を設定 1000ミリ秒に設定(1秒)
        Me.Timer1.Interval = 1000
        ' タイマーを起動する
        Me.Timer1.Start()
    End Sub

    ''' <summary>
    ''' STOPボタンが押されたら
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        ' タイマーを停止する
        Me.Timer1.Stop()
    End Sub

    ''' <summary>
    ''' 指定した間隔で発生
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        ' 時刻3:00経過したら終了
        If Me.TextBox1.Text = "0:00" Then

            'プロセスを強制的に終了させる
            Dim ps As System.Diagnostics.Process() = _
        System.Diagnostics.Process.GetProcessesByName("Zoom")

            For Each p As System.Diagnostics.Process In ps
                p.Kill()
            Next

                ' タイマーを停止する
                Me.Timer1.Stop()
                Exit Sub
        End If

        ' 現在の秒数から1000ミリ秒経過したら-1とする
        intSec -= 1

        ' 変数intSecの値を分に換算する
        Dim resultMin As Integer = CInt(Math.Floor(intSec / 60))                     ' 分への換算(割り算)
        Dim resultSec As Integer = CInt(intSec Mod 60)                                  ' 秒への換算(あまり)

        ' ラベルに現在の経過時間を表示
        Me.TextBox1.Text = CStr(resultMin) + ":" + CStr(resultSec).PadLeft(2, "0")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' ラベルの値を3:00に変更
        Me.TextBox1.Text = Me.TextBox2.Text + ":00"

        ' 変数intSecに3:00を秒に換算した値を代入
        ' 1. 分と秒に分ける
        Dim aryTime As String() = Me.TextBox1.Text.Split(":"c)
        ' 2. 秒に換算する 分=60秒
        intSec = CInt(aryTime(0)) * 60
    End Sub
End Class