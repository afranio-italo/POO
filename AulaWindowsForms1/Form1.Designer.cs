namespace AulaWindowsForms1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.btnEntrar = new System.Windows.Forms.Button();
        this.btnCadastrar = new System.Windows.Forms.Button();
        this.txtSenha = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(37, 38);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(38, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "Usuário:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(45, 72);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(38, 15);
        this.label2.TabIndex = 1;
        this.label2.Text = "Senha:";
        // 
        // button1
        // 
        this.btnEntrar.Location = new System.Drawing.Point(100, 106);
        this.btnEntrar.Name = "btnEntrar";
        this.btnEntrar.Size = new System.Drawing.Size(75, 23);
        this.btnEntrar.TabIndex = 4;
        this.btnEntrar.Text = "Entrar";
        this.btnEntrar.UseVisualStyleBackColor = true;
        this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
        // 
        // button2
        // 
        this.btnCadastrar.Location = new System.Drawing.Point(188, 106);
        this.btnCadastrar.Name = "btnCadastrar";
        this.btnCadastrar.Size = new System.Drawing.Size(92, 23);
        this.btnCadastrar.TabIndex = 5;
        this.btnCadastrar.Text = "Cadastrar-se";
        this.btnCadastrar.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        this.txtSenha.Location = new System.Drawing.Point(100, 69);
        this.txtSenha.Name = "txtSenha";
        this.txtSenha.Size = new System.Drawing.Size(150, 23);
        this.txtSenha.TabIndex = 6;
        this.txtSenha.Multiline = false;
        this.txtSenha.PasswordChar = '*';
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(592, 475);
        this.Controls.Add(this.txtSenha);
        this.Controls.Add(this.btnCadastrar);
        this.Controls.Add(this.btnEntrar);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "Form1";
        Text = "Form1";
        this.txtNomeUsuario = new System.Windows.Forms.TextBox();
        this.txtNomeUsuario.Location = new System.Drawing.Point(100, 35);
        this.txtNomeUsuario.Name = "txtNomeUsuario";
        this.txtNomeUsuario.Size = new System.Drawing.Size(150, 23);
        this.txtNomeUsuario.TabIndex = 6;
        this.Controls.Add(this.txtNomeUsuario);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnEntrar;
    private System.Windows.Forms.Button btnCadastrar;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.TextBox txtNomeUsuario;

}
