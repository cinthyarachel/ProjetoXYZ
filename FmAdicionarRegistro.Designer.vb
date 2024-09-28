<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmAdicionarRegistro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroCartao = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusAdicionarRegistro = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtValor_Transacao = New System.Windows.Forms.TextBox()
        Me.txtData_Transacao = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.lbNumero_Cartao = New System.Windows.Forms.Label()
        Me.lbValor_Transacao = New System.Windows.Forms.Label()
        Me.lbDataTransacao = New System.Windows.Forms.Label()
        Me.lbDescricao = New System.Windows.Forms.Label()
        Me.btSalvarRegistro = New System.Windows.Forms.Button()
        Me.StripStatus1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(503, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insira as informações:"
        '
        'txtNumeroCartao
        '
        Me.txtNumeroCartao.Location = New System.Drawing.Point(310, 157)
        Me.txtNumeroCartao.Name = "txtNumeroCartao"
        Me.txtNumeroCartao.Size = New System.Drawing.Size(308, 22)
        Me.txtNumeroCartao.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusAdicionarRegistro, Me.StripStatus1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 26)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusAdicionarRegistro
        '
        Me.statusAdicionarRegistro.Name = "statusAdicionarRegistro"
        Me.statusAdicionarRegistro.Size = New System.Drawing.Size(0, 20)
        '
        'txtValor_Transacao
        '
        Me.txtValor_Transacao.Location = New System.Drawing.Point(310, 196)
        Me.txtValor_Transacao.Name = "txtValor_Transacao"
        Me.txtValor_Transacao.Size = New System.Drawing.Size(308, 22)
        Me.txtValor_Transacao.TabIndex = 3
        '
        'txtData_Transacao
        '
        Me.txtData_Transacao.Location = New System.Drawing.Point(310, 238)
        Me.txtData_Transacao.Name = "txtData_Transacao"
        Me.txtData_Transacao.Size = New System.Drawing.Size(308, 22)
        Me.txtData_Transacao.TabIndex = 4
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(310, 277)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(308, 22)
        Me.txtDescricao.TabIndex = 5
        '
        'lbNumero_Cartao
        '
        Me.lbNumero_Cartao.AutoSize = True
        Me.lbNumero_Cartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumero_Cartao.Location = New System.Drawing.Point(103, 152)
        Me.lbNumero_Cartao.Name = "lbNumero_Cartao"
        Me.lbNumero_Cartao.Size = New System.Drawing.Size(190, 25)
        Me.lbNumero_Cartao.TabIndex = 6
        Me.lbNumero_Cartao.Text = "Número do cartão:"
        '
        'lbValor_Transacao
        '
        Me.lbValor_Transacao.AutoSize = True
        Me.lbValor_Transacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbValor_Transacao.Location = New System.Drawing.Point(103, 192)
        Me.lbValor_Transacao.Name = "lbValor_Transacao"
        Me.lbValor_Transacao.Size = New System.Drawing.Size(201, 25)
        Me.lbValor_Transacao.TabIndex = 7
        Me.lbValor_Transacao.Text = "Valor da transação:"
        '
        'lbDataTransacao
        '
        Me.lbDataTransacao.AutoSize = True
        Me.lbDataTransacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDataTransacao.Location = New System.Drawing.Point(103, 234)
        Me.lbDataTransacao.Name = "lbDataTransacao"
        Me.lbDataTransacao.Size = New System.Drawing.Size(195, 25)
        Me.lbDataTransacao.TabIndex = 8
        Me.lbDataTransacao.Text = "Data da transação:"
        '
        'lbDescricao
        '
        Me.lbDescricao.AutoSize = True
        Me.lbDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescricao.Location = New System.Drawing.Point(102, 273)
        Me.lbDescricao.Name = "lbDescricao"
        Me.lbDescricao.Size = New System.Drawing.Size(115, 25)
        Me.lbDescricao.TabIndex = 9
        Me.lbDescricao.Text = "Descrição:"
        '
        'btSalvarRegistro
        '
        Me.btSalvarRegistro.Location = New System.Drawing.Point(322, 343)
        Me.btSalvarRegistro.Name = "btSalvarRegistro"
        Me.btSalvarRegistro.Size = New System.Drawing.Size(143, 61)
        Me.btSalvarRegistro.TabIndex = 10
        Me.btSalvarRegistro.TabStop = False
        Me.btSalvarRegistro.Text = "Salvar"
        Me.btSalvarRegistro.UseVisualStyleBackColor = True
        '
        'StripStatus1
        '
        Me.StripStatus1.Name = "StripStatus1"
        Me.StripStatus1.Size = New System.Drawing.Size(153, 20)
        Me.StripStatus1.Text = "ToolStripStatusLabel1"
        '
        'FmAdicionarRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btSalvarRegistro)
        Me.Controls.Add(Me.lbDescricao)
        Me.Controls.Add(Me.lbDataTransacao)
        Me.Controls.Add(Me.lbValor_Transacao)
        Me.Controls.Add(Me.lbNumero_Cartao)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtData_Transacao)
        Me.Controls.Add(Me.txtValor_Transacao)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtNumeroCartao)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FmAdicionarRegistro"
        Me.Text = "XYZ - Adicionar Registro"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumeroCartao As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusAdicionarRegistro As ToolStripStatusLabel
    Friend WithEvents txtValor_Transacao As TextBox
    Friend WithEvents txtData_Transacao As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents lbNumero_Cartao As Label
    Friend WithEvents lbValor_Transacao As Label
    Friend WithEvents lbDataTransacao As Label
    Friend WithEvents lbDescricao As Label
    Friend WithEvents btSalvarRegistro As Button
    Friend WithEvents StripStatus1 As ToolStripStatusLabel
End Class
