<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMainForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._btn1 = New System.Windows.Forms.Button()
        Me._btn2 = New System.Windows.Forms.Button()
        Me._txb1 = New System.Windows.Forms.TextBox()
        Me._txb2 = New System.Windows.Forms.TextBox()
        Me._ccb1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        '_btn1
        '
        Me._btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btn1.Location = New System.Drawing.Point(668, 565)
        Me._btn1.Name = "_btn1"
        Me._btn1.Size = New System.Drawing.Size(120, 23)
        Me._btn1.TabIndex = 0
        Me._btn1.Text = "Reset (Ctrl+Del)"
        Me._btn1.UseVisualStyleBackColor = True
        '
        '_btn2
        '
        Me._btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btn2.Location = New System.Drawing.Point(532, 565)
        Me._btn2.Name = "_btn2"
        Me._btn2.Size = New System.Drawing.Size(130, 23)
        Me._btn2.TabIndex = 1
        Me._btn2.Text = "Create (Ctrl+Enter)"
        Me._btn2.UseVisualStyleBackColor = True
        '
        '_txb1
        '
        Me._txb1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._txb1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txb1.Location = New System.Drawing.Point(12, 12)
        Me._txb1.Multiline = True
        Me._txb1.Name = "_txb1"
        Me._txb1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._txb1.Size = New System.Drawing.Size(776, 329)
        Me._txb1.TabIndex = 2
        Me._txb1.Text = "CUser" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "string Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "int Age" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "double Ratio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "private DateTime _dtx" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "public object" & _
    " LockObj XX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "internal bool IsChecked" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me._txb1.WordWrap = False
        '
        '_txb2
        '
        Me._txb2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._txb2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txb2.Location = New System.Drawing.Point(12, 347)
        Me._txb2.Multiline = True
        Me._txb2.Name = "_txb2"
        Me._txb2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._txb2.Size = New System.Drawing.Size(776, 212)
        Me._txb2.TabIndex = 3
        Me._txb2.WordWrap = False
        '
        '_ccb1
        '
        Me._ccb1.AutoSize = True
        Me._ccb1.Checked = True
        Me._ccb1.CheckState = System.Windows.Forms.CheckState.Checked
        Me._ccb1.Location = New System.Drawing.Point(12, 568)
        Me._ccb1.Name = "_ccb1"
        Me._ccb1.Size = New System.Drawing.Size(115, 19)
        Me._ccb1.TabIndex = 4
        Me._ccb1.Text = "Make ToString();"
        Me._ccb1.UseVisualStyleBackColor = True
        '
        'CMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me._ccb1)
        Me.Controls.Add(Me._txb1)
        Me.Controls.Add(Me._txb2)
        Me.Controls.Add(Me._btn2)
        Me.Controls.Add(Me._btn1)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "CMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _btn1 As System.Windows.Forms.Button
    Friend WithEvents _btn2 As System.Windows.Forms.Button
    Friend WithEvents _txb1 As System.Windows.Forms.TextBox
    Friend WithEvents _txb2 As System.Windows.Forms.TextBox
    Friend WithEvents _ccb1 As System.Windows.Forms.CheckBox

End Class
