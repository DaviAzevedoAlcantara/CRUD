namespace Projeto3Camadas
{
    partial class FrmDelCliente
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
        public void InitializeComponent()
        {
            textID_delete = new TextBox();
            btnDelete = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textID_delete
            // 
            textID_delete.Location = new Point(46, 86);
            textID_delete.Name = "textID_delete";
            textID_delete.Size = new Size(443, 23);
            textID_delete.TabIndex = 0;
            textID_delete.TextChanged += textBox1_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(188, 129);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 60);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 89);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // FrmDelCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 258);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(textID_delete);
            Name = "FrmDelCliente";
            Text = "FrmDelCliente";
            Load += FrmDelCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textID_delete;
        private Button btnDelete;
        private Label label1;
    }
}