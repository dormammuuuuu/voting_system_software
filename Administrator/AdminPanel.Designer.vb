﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPanel))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button10 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(278, 67)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "User Accounts"
        Me.ToolTip1.SetToolTip(Me.Button1, "Add User/Admin")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(278, 67)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Score"
        Me.ToolTip1.SetToolTip(Me.Button2, "View Scores")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(16, 366)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(278, 67)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Logs"
        Me.ToolTip1.SetToolTip(Me.Button3, "Monitor people who logs in/out")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(15, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(278, 67)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Candidate"
        Me.ToolTip1.SetToolTip(Me.Button4, "Add, Update or Delete Candidates")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(16, 82)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(278, 67)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Voters"
        Me.ToolTip1.SetToolTip(Me.Button5, "Add, Update or Delete Voters")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(16, 294)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(278, 67)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Reset"
        Me.ToolTip1.SetToolTip(Me.Button6, "Reset vote monitor and scores")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(16, 437)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(278, 67)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Start Voting"
        Me.ToolTip1.SetToolTip(Me.Button7, "Start Voting")
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(772, 353)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(278, 67)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Log In"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(772, 424)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(278, 67)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.Button9, "Exit Program")
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(484, 455)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 47)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "About")
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(16, 437)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(278, 67)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = "Backup and Restore"
        Me.ToolTip1.SetToolTip(Me.Button10, "Backup or Restore Database")
        Me.Button10.UseVisualStyleBackColor = True
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1062, 514)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
End Class
