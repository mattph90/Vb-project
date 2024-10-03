<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientsForm))
        Panel1 = New Panel()
        Panel3 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        DataGridViewCLIENTS = New DataGridView()
        TextBox6 = New TextBox()
        Label7 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridViewCLIENTS, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MistyRose
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(51, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1230, 1021)
        Panel1.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LemonChiffon
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(DataGridViewCLIENTS)
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(TextBox5)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(0, 132)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1214, 577)
        Panel3.TabIndex = 4
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Gold
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(21, 496)
        Button5.Name = "Button5"
        Button5.Size = New Size(438, 50)
        Button5.TabIndex = 16
        Button5.Text = "Clear Fields"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Red
        Button4.ForeColor = Color.White
        Button4.Location = New Point(308, 440)
        Button4.Name = "Button4"
        Button4.Size = New Size(151, 50)
        Button4.TabIndex = 15
        Button4.Text = "REMOVE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DeepSkyBlue
        Button3.ForeColor = Color.White
        Button3.Location = New Point(163, 440)
        Button3.Name = "Button3"
        Button3.Size = New Size(142, 50)
        Button3.TabIndex = 14
        Button3.Text = "EDIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.YellowGreen
        Button2.ForeColor = Color.White
        Button2.Location = New Point(21, 440)
        Button2.Name = "Button2"
        Button2.Size = New Size(136, 50)
        Button2.TabIndex = 13
        Button2.Text = "ADD"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewCLIENTS
        ' 
        DataGridViewCLIENTS.BackgroundColor = SystemColors.ControlLight
        DataGridViewCLIENTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCLIENTS.Location = New Point(507, 23)
        DataGridViewCLIENTS.Name = "DataGridViewCLIENTS"
        DataGridViewCLIENTS.RowHeadersWidth = 62
        DataGridViewCLIENTS.Size = New Size(692, 393)
        DataGridViewCLIENTS.TabIndex = 12
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(179, 289)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(249, 127)
        TextBox6.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(65, 292)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 25)
        Label7.TabIndex = 10
        Label7.Text = "Address:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(179, 237)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(249, 31)
        TextBox5.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(65, 240)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 25)
        Label6.TabIndex = 8
        Label6.Text = "Email:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(179, 185)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(249, 31)
        TextBox4.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(65, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 25)
        Label5.TabIndex = 6
        Label5.Text = "Phone:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(179, 129)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(249, 31)
        TextBox3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 25)
        Label4.TabIndex = 4
        Label4.Text = "Last Name:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(179, 78)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(249, 31)
        TextBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(65, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 25)
        Label3.TabIndex = 2
        Label3.Text = "First Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(105, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(249, 31)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 25)
        Label2.TabIndex = 0
        Label2.Text = "ID:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(12, 106)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1585, 10)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Gill Sans Ultra Bold", 26F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(121, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(293, 76)
        Label1.TabIndex = 1
        Label1.Text = "CLIENTS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(115, 97)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Castellar", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1179, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(48, 44)
        Button1.TabIndex = 6
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ClientsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1293, 979)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ClientsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridViewCLIENTS, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewCLIENTS As DataGridView
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
End Class
