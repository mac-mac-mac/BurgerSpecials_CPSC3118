<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurgers
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnPrime = New System.Windows.Forms.Button()
        Me.btnSelectMeal = New System.Windows.Forms.Button()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.picPrime = New System.Windows.Forms.PictureBox()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPrime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Red
        Me.lblHeading.Location = New System.Drawing.Point(260, 10)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(305, 33)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Farm Burger Specials"
        '
        'btnPrime
        '
        Me.btnPrime.BackColor = System.Drawing.Color.Wheat
        Me.btnPrime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrime.Location = New System.Drawing.Point(137, 342)
        Me.btnPrime.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrime.Name = "btnPrime"
        Me.btnPrime.Size = New System.Drawing.Size(128, 35)
        Me.btnPrime.TabIndex = 3
        Me.btnPrime.Text = "Prime Beef"
        Me.btnPrime.UseVisualStyleBackColor = False
        '
        'btnSelectMeal
        '
        Me.btnSelectMeal.BackColor = System.Drawing.Color.Wheat
        Me.btnSelectMeal.Enabled = False
        Me.btnSelectMeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectMeal.Location = New System.Drawing.Point(317, 342)
        Me.btnSelectMeal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelectMeal.Name = "btnSelectMeal"
        Me.btnSelectMeal.Size = New System.Drawing.Size(128, 35)
        Me.btnSelectMeal.TabIndex = 4
        Me.btnSelectMeal.Text = "Select Meal"
        Me.btnSelectMeal.UseVisualStyleBackColor = False
        '
        'btnVeggie
        '
        Me.btnVeggie.BackColor = System.Drawing.Color.Wheat
        Me.btnVeggie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeggie.Location = New System.Drawing.Point(494, 342)
        Me.btnVeggie.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Size = New System.Drawing.Size(128, 35)
        Me.btnVeggie.TabIndex = 5
        Me.btnVeggie.Text = "Veggie"
        Me.btnVeggie.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(234, 402)
        Me.lblInstructions.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(360, 18)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Choose a burger and then click the Select Meal button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(314, 441)
        Me.lblConfirmation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(172, 18)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Enjoy your burger special"
        Me.lblConfirmation.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Wheat
        Me.btnExit.Enabled = False
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(317, 489)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picVeggie
        '
        Me.picVeggie.Image = Global.BurgerSpecials_CPSC3118.My.Resources.Resources.veggie
        Me.picVeggie.Location = New System.Drawing.Point(430, 70)
        Me.picVeggie.Margin = New System.Windows.Forms.Padding(2)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(260, 250)
        Me.picVeggie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVeggie.TabIndex = 2
        Me.picVeggie.TabStop = False
        Me.picVeggie.Visible = False
        '
        'picPrime
        '
        Me.picPrime.Image = Global.BurgerSpecials_CPSC3118.My.Resources.Resources.prime
        Me.picPrime.Location = New System.Drawing.Point(70, 70)
        Me.picPrime.Margin = New System.Windows.Forms.Padding(2)
        Me.picPrime.Name = "picPrime"
        Me.picPrime.Size = New System.Drawing.Size(260, 250)
        Me.picPrime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPrime.TabIndex = 1
        Me.picPrime.TabStop = False
        Me.picPrime.Visible = False
        '
        'frmBurgers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(784, 551)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnVeggie)
        Me.Controls.Add(Me.btnSelectMeal)
        Me.Controls.Add(Me.btnPrime)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picPrime)
        Me.Controls.Add(Me.lblHeading)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBurgers"
        Me.Text = "Burger Specials"
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPrime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picPrime As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents btnPrime As Button
    Friend WithEvents btnSelectMeal As Button
    Friend WithEvents btnVeggie As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button
End Class
