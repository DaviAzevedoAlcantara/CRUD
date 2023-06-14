namespace Projeto3Camadas
{
    partial class FrmAlterCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAterar = new Button();
            lblEmail = new Label();
            lblNome = new Label();
            textNovoEmail = new TextBox();
            textNovoNome = new TextBox();
            label1 = new Label();
            textIdAlter = new TextBox();
            SuspendLayout();
            // 
            // btnAterar
            // 
            btnAterar.Location = new Point(200, 147);
            btnAterar.Name = "btnAterar";
            btnAterar.Size = new Size(136, 60);
            btnAterar.TabIndex = 9;
            btnAterar.Text = "Alterar";
            btnAterar.UseVisualStyleBackColor = true;
            btnAterar.Click += btnAterar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 99);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Novo Email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(10, 55);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(75, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Novo Nome:";
            lblNome.Click += lblNome_Click;
            // 
            // textNovoEmail
            // 
            textNovoEmail.Location = new Point(91, 96);
            textNovoEmail.Name = "textNovoEmail";
            textNovoEmail.Size = new Size(398, 23);
            textNovoEmail.TabIndex = 6;
            // 
            // textNovoNome
            // 
            textNovoNome.Location = new Point(91, 52);
            textNovoNome.Name = "textNovoNome";
            textNovoNome.Size = new Size(398, 23);
            textNovoNome.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 24);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 10;
            label1.Text = "ID:";
            // 
            // textIdAlter
            // 
            textIdAlter.Location = new Point(384, 21);
            textIdAlter.Name = "textIdAlter";
            textIdAlter.Size = new Size(105, 23);
            textIdAlter.TabIndex = 11;
            // 
            // FrmAlterCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 258);
            Controls.Add(textIdAlter);
            Controls.Add(label1);
            Controls.Add(btnAterar);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(textNovoEmail);
            Controls.Add(textNovoNome);
            Name = "FrmAlterCliente";
            Text = "FrmAlterCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAterar;
        private Label lblEmail;
        private Label lblNome;
        private TextBox textNovoEmail;
        private TextBox textNovoNome;
        private Label label1;
        private TextBox textIdAlter;
    }
}