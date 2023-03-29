<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatering))
        Me.picPlatter = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblSubHead = New System.Windows.Forms.Label()
        Me.boxCheese = New System.Windows.Forms.GroupBox()
        Me.radFruit = New System.Windows.Forms.RadioButton()
        Me.radSausage = New System.Windows.Forms.RadioButton()
        Me.radVeggie = New System.Windows.Forms.RadioButton()
        Me.radPinwheel = New System.Windows.Forms.RadioButton()
        Me.radGourmetCheese = New System.Windows.Forms.RadioButton()
        Me.boxPayment = New System.Windows.Forms.GroupBox()
        Me.radPickUp = New System.Windows.Forms.RadioButton()
        Me.radPrePay = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblLoyalty = New System.Windows.Forms.Label()
        Me.tboxPoints = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblReturn = New System.Windows.Forms.Label()
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxCheese.SuspendLayout()
        Me.boxPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPlatter
        '
        Me.picPlatter.Image = CType(resources.GetObject("picPlatter.Image"), System.Drawing.Image)
        Me.picPlatter.Location = New System.Drawing.Point(631, 61)
        Me.picPlatter.Name = "picPlatter"
        Me.picPlatter.Size = New System.Drawing.Size(609, 415)
        Me.picPlatter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlatter.TabIndex = 0
        Me.picPlatter.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Gabriola", 25.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(187, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(244, 127)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Catering"
        '
        'lblSubHead
        '
        Me.lblSubHead.AutoSize = True
        Me.lblSubHead.Font = New System.Drawing.Font("Ebrima", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHead.Location = New System.Drawing.Point(167, 114)
        Me.lblSubHead.Name = "lblSubHead"
        Me.lblSubHead.Size = New System.Drawing.Size(179, 40)
        Me.lblSubHead.TabIndex = 2
        Me.lblSubHead.Text = "Star Market"
        '
        'boxCheese
        '
        Me.boxCheese.BackColor = System.Drawing.Color.Linen
        Me.boxCheese.Controls.Add(Me.radFruit)
        Me.boxCheese.Controls.Add(Me.radSausage)
        Me.boxCheese.Controls.Add(Me.radVeggie)
        Me.boxCheese.Controls.Add(Me.radPinwheel)
        Me.boxCheese.Controls.Add(Me.radGourmetCheese)
        Me.boxCheese.ForeColor = System.Drawing.Color.Black
        Me.boxCheese.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.boxCheese.Location = New System.Drawing.Point(78, 177)
        Me.boxCheese.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.boxCheese.Name = "boxCheese"
        Me.boxCheese.Size = New System.Drawing.Size(517, 355)
        Me.boxCheese.TabIndex = 3
        Me.boxCheese.TabStop = False
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.Font = New System.Drawing.Font("Courier New", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFruit.Location = New System.Drawing.Point(19, 300)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(250, 36)
        Me.radFruit.TabIndex = 4
        Me.radFruit.Text = "Fruit $29.99"
        Me.radFruit.UseVisualStyleBackColor = True
        '
        'radSausage
        '
        Me.radSausage.AutoSize = True
        Me.radSausage.Font = New System.Drawing.Font("Courier New", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSausage.Location = New System.Drawing.Point(19, 242)
        Me.radSausage.Name = "radSausage"
        Me.radSausage.Size = New System.Drawing.Size(471, 36)
        Me.radSausage.TabIndex = 3
        Me.radSausage.Text = "Sausage and Cheese $49.99"
        Me.radSausage.UseVisualStyleBackColor = True
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.Font = New System.Drawing.Font("Courier New", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVeggie.Location = New System.Drawing.Point(19, 181)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(267, 36)
        Me.radVeggie.TabIndex = 2
        Me.radVeggie.Text = "Veggie $29.99"
        Me.radVeggie.UseVisualStyleBackColor = True
        '
        'radPinwheel
        '
        Me.radPinwheel.AutoSize = True
        Me.radPinwheel.Font = New System.Drawing.Font("Courier New", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPinwheel.Location = New System.Drawing.Point(19, 120)
        Me.radPinwheel.Name = "radPinwheel"
        Me.radPinwheel.Size = New System.Drawing.Size(403, 36)
        Me.radPinwheel.TabIndex = 1
        Me.radPinwheel.Text = "Pinwheel Wraps $59.99"
        Me.radPinwheel.UseVisualStyleBackColor = True
        '
        'radGourmetCheese
        '
        Me.radGourmetCheese.AutoSize = True
        Me.radGourmetCheese.Checked = True
        Me.radGourmetCheese.Font = New System.Drawing.Font("Courier New", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGourmetCheese.Location = New System.Drawing.Point(19, 57)
        Me.radGourmetCheese.Name = "radGourmetCheese"
        Me.radGourmetCheese.Size = New System.Drawing.Size(403, 36)
        Me.radGourmetCheese.TabIndex = 0
        Me.radGourmetCheese.TabStop = True
        Me.radGourmetCheese.Text = "Gourmet Cheese $49.99"
        Me.radGourmetCheese.UseVisualStyleBackColor = True
        '
        'boxPayment
        '
        Me.boxPayment.BackColor = System.Drawing.Color.Linen
        Me.boxPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.boxPayment.Controls.Add(Me.radPickUp)
        Me.boxPayment.Controls.Add(Me.radPrePay)
        Me.boxPayment.Location = New System.Drawing.Point(162, 572)
        Me.boxPayment.Name = "boxPayment"
        Me.boxPayment.Size = New System.Drawing.Size(338, 149)
        Me.boxPayment.TabIndex = 4
        Me.boxPayment.TabStop = False
        '
        'radPickUp
        '
        Me.radPickUp.AutoSize = True
        Me.radPickUp.Font = New System.Drawing.Font("Courier New", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPickUp.Location = New System.Drawing.Point(15, 89)
        Me.radPickUp.Name = "radPickUp"
        Me.radPickUp.Size = New System.Drawing.Size(301, 36)
        Me.radPickUp.TabIndex = 5
        Me.radPickUp.Text = "Pay Upon Pickup"
        Me.radPickUp.UseVisualStyleBackColor = True
        '
        'radPrePay
        '
        Me.radPrePay.AutoSize = True
        Me.radPrePay.Checked = True
        Me.radPrePay.Font = New System.Drawing.Font("Courier New", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPrePay.Location = New System.Drawing.Point(15, 30)
        Me.radPrePay.Name = "radPrePay"
        Me.radPrePay.Size = New System.Drawing.Size(165, 36)
        Me.radPrePay.TabIndex = 4
        Me.radPrePay.TabStop = True
        Me.radPrePay.Text = "Pre-pay"
        Me.radPrePay.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.Location = New System.Drawing.Point(667, 649)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(233, 60)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PeachPuff
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(974, 649)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(233, 60)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblLoyalty
        '
        Me.lblLoyalty.AutoSize = True
        Me.lblLoyalty.Font = New System.Drawing.Font("Ebrima", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoyalty.Location = New System.Drawing.Point(721, 548)
        Me.lblLoyalty.Name = "lblLoyalty"
        Me.lblLoyalty.Size = New System.Drawing.Size(200, 37)
        Me.lblLoyalty.TabIndex = 7
        Me.lblLoyalty.Text = "Loyalty Points"
        '
        'tboxPoints
        '
        Me.tboxPoints.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxPoints.Location = New System.Drawing.Point(963, 539)
        Me.tboxPoints.Name = "tboxPoints"
        Me.tboxPoints.Size = New System.Drawing.Size(87, 51)
        Me.tboxPoints.TabIndex = 8
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Ebrima", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(167, 763)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(170, 40)
        Me.lblInstructions.TabIndex = 9
        Me.lblInstructions.Text = "Please Pay:"
        Me.lblInstructions.Visible = False
        '
        'lblReturn
        '
        Me.lblReturn.AutoEllipsis = True
        Me.lblReturn.Font = New System.Drawing.Font("Ebrima", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturn.Location = New System.Drawing.Point(343, 763)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(761, 108)
        Me.lblReturn.TabIndex = 10
        Me.lblReturn.Visible = False
        '
        'FrmCatering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1274, 929)
        Me.Controls.Add(Me.lblReturn)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.tboxPoints)
        Me.Controls.Add(Me.lblLoyalty)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.boxPayment)
        Me.Controls.Add(Me.boxCheese)
        Me.Controls.Add(Me.lblSubHead)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picPlatter)
        Me.Name = "FrmCatering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering"
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxCheese.ResumeLayout(False)
        Me.boxCheese.PerformLayout()
        Me.boxPayment.ResumeLayout(False)
        Me.boxPayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlatter As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblSubHead As Label
    Friend WithEvents boxCheese As GroupBox
    Friend WithEvents radGourmetCheese As RadioButton
    Friend WithEvents radFruit As RadioButton
    Friend WithEvents radSausage As RadioButton
    Friend WithEvents radVeggie As RadioButton
    Friend WithEvents radPinwheel As RadioButton
    Friend WithEvents boxPayment As GroupBox
    Friend WithEvents radPickUp As RadioButton
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblLoyalty As Label
    Friend WithEvents tboxPoints As TextBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblReturn As Label
End Class
