<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertyTypeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PropertyTypeForm))
        Panel1 = New Panel()
        Panel3 = New Panel()
        ListBoxTypes = New ListBox()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        TextBox6 = New TextBox()
        Label7 = New Label()
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.YellowGreen
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(50, 29)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1186, 1021)
        Panel1.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LemonChiffon
        Panel3.Controls.Add(ListBoxTypes)
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(12, 134)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1169, 577)
        Panel3.TabIndex = 3
        ' 
        ' ListBoxTypes
        ' 
        ListBoxTypes.FormattingEnabled = True
        ListBoxTypes.ItemHeight = 25
        ListBoxTypes.Location = New Point(672, 41)
        ListBoxTypes.Name = "ListBoxTypes"
        ListBoxTypes.Size = New Size(438, 479)
        ListBoxTypes.TabIndex = 17
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Gold
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(63, 435)
        Button5.Name = "Button5"
        Button5.Size = New Size(527, 63)
        Button5.TabIndex = 16
        Button5.Text = "Clear Fields"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Red
        Button4.ForeColor = Color.White
        Button4.Location = New Point(398, 366)
        Button4.Name = "Button4"
        Button4.Size = New Size(192, 63)
        Button4.TabIndex = 15
        Button4.Text = "REMOVE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DeepSkyBlue
        Button3.ForeColor = Color.White
        Button3.Location = New Point(231, 366)
        Button3.Name = "Button3"
        Button3.Size = New Size(169, 63)
        Button3.TabIndex = 14
        Button3.Text = "EDIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.YellowGreen
        Button2.ForeColor = Color.White
        Button2.Location = New Point(63, 366)
        Button2.Name = "Button2"
        Button2.Size = New Size(169, 63)
        Button2.TabIndex = 13
        Button2.Text = "ADD"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(189, 218)
        TextBox6.Multiline = True
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(368, 128)
        TextBox6.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(56, 218)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 30)
        Label7.TabIndex = 10
        Label7.Text = "Description:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(189, 144)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(249, 43)
        TextBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(56, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 30)
        Label3.TabIndex = 2
        Label3.Text = "First Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(189, 76)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(249, 44)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(139, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 30)
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
        Label1.Font = New Font("Gill Sans Ultra Bold", 26.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(98, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(235, 76)
        Label1.TabIndex = 1
        Label1.Text = "TYPES"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(89, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Castellar", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1233, 29)
        Button1.Name = "Button1"
        Button1.Size = New Size(54, 44)
        Button1.TabIndex = 6
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PropertyTypeForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.YellowGreen
        ClientSize = New Size(1299, 1035)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PropertyTypeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PropertyTypeForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBoxTypes As ListBox
End Class
