Imports System
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq





Public NotInheritable Class CMainForm
    Public Sub New()
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub






    Private Shared Sub ppTrace(tmsg As String)
        Debug.WriteLine(tmsg)
    End Sub










    Protected Overrides Sub OnLoad(tea As EventArgs)
        MyBase.OnLoad(tea)

        Me.Text = Me.GetType().Namespace
        '모니터다 듀얼 이상일때
        Dim tcs As Screen = Screen.FromPoint(Cursor.Position)
        Dim tsb As Rectangle = tcs.Bounds
        Dim tlp As Point = New Point(tsb.Right, tsb.Bottom)
        Dim tws As Size = Me.Size
        tlp.Offset(-(tws.Width + 40), -(tws.Height + 40))
        Me.Location = tlp


        _template_str = My.Resources.XXXA
        _backup_str = _txb1.Text

        ppTrace(String.Format(_template_str, "CRect", "xxx", "yyy"))
        ppTrace(_template_str)
    End Sub




    Private _template_str As String
    Private _backup_str As String

    Private _line_str_arr() As String
    Private _last_str As String


    Private Sub pp_btn2_Click(tsd As Object, tea As EventArgs) Handles _btn2.Click
        Dim ttxt As String = _txb1.Text
        If Not String.IsNullOrEmpty(ttxt) Then
            Try
                ppWorkCore(ttxt)
            Catch
                MsgBox("Error!")
            End Try
        End If
    End Sub


    Private Sub pp_btn1_Click(tsd As Object, tea As EventArgs) Handles _btn1.Click
        _txb1.Text = _backup_str
        _txb2.Clear()
    End Sub







    Private Function ppGetAppendString(tb As Boolean, tpnm As String) As String
        Dim txx As String = String.Empty
        If tb Then
            txx = "		tsb.Append(string.Format(""{0} = {{0}}, "", {0}));"
        Else
            txx = "		tsb.Append(string.Format(""{0} = {{0}}"", {0}));"
        End If
        Return String.Format(txx, tpnm)
    End Function



    Private Function ppAddClassString() As String
        Return _line_str_arr(0)
    End Function

    Private Function ppAddPropertyString() As String
        If _line_str_arr.Length < 2 Then
            Return String.Empty
        End If

        Dim tsb As New StringBuilder()
        Dim tffx As String = vbTab & "{0} {1} {2} {{ get; set; }}"

        Dim te As Integer = _line_str_arr.Length - 1
        For i As Integer = 1 To te
            Dim txxa As String = _line_str_arr(i)
            Dim tva() As String = Regex.Split(txxa, "\s+", RegexOptions.Singleline)
            tva = Enumerable.Select(tva, Function(ta As String) ta.Trim()).ToArray()

            Dim tv As String = String.Empty
            If tva.Length = 1 Then
                tv = String.Format(tffx, "public", "string", txxa)
                tsb.AppendLine(tv)
            ElseIf tva.Length = 2 Then
                tv = String.Format(tffx, "public", tva(0), tva(1))
                tsb.AppendLine(tv)
            ElseIf tva.Length = 3 Then
                tv = String.Format(tffx, tva(0), tva(1), tva(2))
                tsb.AppendLine(tv)
            End If
        Next

        Return tsb.ToString()
    End Function

    Private Function ppAddToString() As String
        If _ccb1.Checked = False Then
            Return String.Empty
        End If

        If _line_str_arr.Length < 2 Then
            Return String.Empty
        End If

        Dim tsb As New StringBuilder()
        tsb.AppendLine("	public override string ToString()")
        tsb.AppendLine("	{")
        tsb.AppendLine("		StringBuilder tsb = new StringBuilder();")

        Dim te As Integer = _line_str_arr.Length - 1
        For i As Integer = 1 To te
            Dim txxa As String = _line_str_arr(i)
            Dim tva() As String = Regex.Split(txxa, "\s+", RegexOptions.Singleline)
            tva = Enumerable.Select(tva, Function(ta As String) ta.Trim()).ToArray()

            Dim tb As Boolean = i < te
            Dim tv As String = String.Empty
            If tva.Length = 1 Then
                tv = tva(0)
                tsb.AppendLine(ppGetAppendString(tb, tv))
            ElseIf tva.Length = 2 Then
                tv = tva(1)
                tsb.AppendLine(ppGetAppendString(tb, tv))
            ElseIf tva.Length = 3 Then
                tv = tva(2)
                tsb.AppendLine(ppGetAppendString(tb, tv))
            End If
        Next
        tsb.AppendLine("		if (tsb.Length > 0)")
        tsb.AppendLine("			return tsb.ToString();")
        tsb.AppendLine("		else")
        tsb.AppendLine("			return base.ToString();")
        tsb.AppendLine("	}")

        Return tsb.ToString()
    End Function


    Private Sub ppWorkCore(ttxt As String)
        _line_str_arr = ttxt.Split({vbNewLine}, StringSplitOptions.RemoveEmptyEntries)
        If (Not _line_str_arr Is Nothing) AndAlso (_line_str_arr.Length > 1) Then
            Dim tgs1 As String = ppAddClassString()
            Dim tgs2 As String = ppAddPropertyString()
            Dim tgs3 As String = ppAddToString()

            _last_str = String.Format(_template_str, tgs1, tgs2, tgs3)
            _txb2.Text = _last_str
            Clipboard.SetText(_last_str)

            _line_str_arr = Nothing
            _last_str = Nothing
        End If
    End Sub



    Protected Overrides Function ProcessCmdKey(ByRef tmsg As Message, tkd As Keys) As Boolean
        If tkd = (Keys.Control Or Keys.Delete) Then
            pp_btn1_Click(Nothing, Nothing)
            Return True
        ElseIf tkd = (Keys.Control Or Keys.Enter) Then
            pp_btn2_Click(Nothing, Nothing)
            Return True
        End If
        Return MyBase.ProcessCmdKey(tmsg, tkd)
    End Function

End Class
