Public Class Form1


    Private Sub 時間割を編集ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 時間割を編集ToolStripMenuItem.Click
        Dim newform As New Form2
        newform.ShowDialog()
        Button6.Text = newform.TextBox18.Text
        Button1.Text = newform.TextBox15.Text
        Button2.Text = newform.TextBox12.Text
        Button3.Text = newform.TextBox9.Text
        Button4.Text = newform.TextBox6.Text
        Button5.Text = newform.TextBox3.Text
        Button7.Text = newform.TextBox36.Text
        Button8.Text = newform.TextBox33.Text
        Button9.Text = newform.TextBox30.Text
        Button10.Text = newform.TextBox27.Text
        Button11.Text = newform.TextBox24.Text
        Button12.Text = newform.TextBox21.Text
        Button13.Text = newform.TextBox54.Text
        Button14.Text = newform.TextBox51.Text
        Button15.Text = newform.TextBox48.Text
        Button16.Text = newform.TextBox45.Text
        Button17.Text = newform.TextBox42.Text
        Button18.Text = newform.TextBox39.Text
        Button19.Text = newform.TextBox72.Text
        Button20.Text = newform.TextBox69.Text
        Button21.Text = newform.TextBox66.Text
        Button22.Text = newform.TextBox63.Text
        Button23.Text = newform.TextBox60.Text
        Button24.Text = newform.TextBox57.Text
        Button25.Text = newform.TextBox90.Text
        Button26.Text = newform.TextBox87.Text
        Button27.Text = newform.TextBox84.Text
        Button28.Text = newform.TextBox81.Text
        Button29.Text = newform.TextBox78.Text
        Button30.Text = newform.TextBox75.Text
        Button31.Text = newform.TextBox108.Text
        Button32.Text = newform.TextBox105.Text
        Button33.Text = newform.TextBox102.Text
        Button34.Text = newform.TextBox99.Text
        Button35.Text = newform.TextBox96.Text
        Button36.Text = newform.TextBox93.Text

    End Sub

    Private Sub ClaManaForMUについてToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClaManaForMUについてToolStripMenuItem.Click
        Dim newaboutbox As New AboutBox1
        newaboutbox.ShowDialog()

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox17.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox16.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox2.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox1.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox5.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox4.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox8.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox7.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox11.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox10.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox14.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox13.Text)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox35.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox34.Text)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox32.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox31.Text)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox30.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox29.Text)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox26.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox25.Text)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox23.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox22.Text)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox20.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox19.Text)
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox50.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox49.Text)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox47.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox46.Text)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox44.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox43.Text)
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox41.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox40.Text)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox38.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox37.Text)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox71.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox70.Text)
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox68.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox67.Text)
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox65.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox64.Text)
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox62.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox61.Text)
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox59.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox58.Text)
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox56.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox55.Text)
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox89.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox88.Text)
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox86.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox85.Text)
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox83.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox82.Text)
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox80.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox79.Text)
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox77.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox76.Text)
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox74.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox73.Text)
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox107.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox106.Text)
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox104.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox103.Text)
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox101.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox100.Text)
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox98.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox97.Text)
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox95.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox94.Text)
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        WebView21.CoreWebView2.Navigate("https://zoom.us/j/" + Form2.TextBox92.Text + "?")
        Clipboard.Clear()
        Clipboard.SetText(Form2.TextBox91.Text)
    End Sub

    Private Sub 作者へのメッセージはこちらへToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 作者へのメッセージはこちらへToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://twitter.com/messages/compose?recipient_id=1369850897115668480")
    End Sub

    Private Sub バグの報告等はこちらへToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles バグの報告等はこちらへToolStripMenuItem.Click
        System.Diagnostics.Process.Start("mailto:serendipity711min@gmail.com?subject=ClaMana 2 バグ報告（件名は変更しないでください）")
    End Sub

    Private Sub ZoomキルタイマーToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomキルタイマーToolStripMenuItem.Click
        Dim newform As New Form3
        newform.ShowDialog()
    End Sub

    Private Sub 新機能の使い方ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新機能の使い方ToolStripMenuItem.Click
        MsgBox("☆使い方☆" & vbCrLf & vbCrLf & "○クラマナ基本機能の使い方" & vbCrLf & "　①編集→時間割を編集" & vbCrLf & "　②各自時間割情報を入力" & vbCrLf & "　※IDは空白を開けず詰めて入力してください" & vbCrLf & "　③右上の×を押してとじる" & vbCrLf & "　④ボタンを押せば自動でzoomが開きます" & vbCrLf & "　⑤Ctrl+Vを押して、Enterキーを押す" & vbCrLf & "　あら不思議、授業に入れた～！" & vbCrLf & vbCrLf & "○多機能オートセーブメモの使い方" + vbCrLf + "　書くだけ！" + vbCrLf + "　書いてソフトを閉じるだけで保存されます！" + vbCrLf + "　保存ボタンの押し忘れを気にする必要なし！！" + vbCrLf + vbCrLf + "○Zoomキルタイマーの使い方" + vbCrLf + "　設定したn分後に自動でZoomを切る(=Kill)するタイマー！" + vbCrLf + "　使い方は見ての通り、百聞は一見に如かず！")
    End Sub
End Class
