namespace Projeto3Camadas
{
    partial class FrmCadCliente
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
            textNome = new TextBox();
            textEmail = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            btnIncluir = new Button();
            go_to_delete = new Button();
            go_to_alter = new Button();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(70, 65);
            textNome.Name = "textNome";
            textNome.Size = new Size(398, 23);
            textNome.TabIndex = 0;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(70, 109);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(398, 23);
            textEmail.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(26, 68);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 112);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(197, 160);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(136, 60);
            btnIncluir.TabIndex = 4;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // go_to_delete
            // 
            go_to_delete.BackgroundImage = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz48;
            go_to_delete.BackgroundImageLayout = ImageLayout.Stretch;
            go_to_delete.Location = new Point(12, 12);
            go_to_delete.Name = "go_to_delete";
            go_to_delete.Size = new Size(32, 32);
            go_to_delete.TabIndex = 5;
            go_to_delete.UseVisualStyleBackColor = true;
            go_to_delete.Click += go_to_delete_Click;
            // 
            // go_to_alter
            // 
            go_to_alter.BackgroundImage = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz48;
            go_to_alter.BackgroundImageLayout = ImageLayout.Stretch;
            go_to_alter.Location = new Point(50, 12);
            go_to_alter.Name = "go_to_alter";
            go_to_alter.Size = new Size(32, 32);
            go_to_alter.TabIndex = 6;
            go_to_alter.UseVisualStyleBackColor = true;
            go_to_alter.Click += go_to_alter_Click;
            // 
            // FrmCadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 258);
            Controls.Add(go_to_alter);
            Controls.Add(go_to_delete);
            Controls.Add(btnIncluir);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(textEmail);
            Controls.Add(textNome);
            Name = "FrmCadCliente";
            Load += FrmCadCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox textEmail;
        private Label lblNome;
        private Label lblEmail;
        private Button btnIncluir;
        private Button go_to_delete;
        private Button go_to_alter;
    }
}