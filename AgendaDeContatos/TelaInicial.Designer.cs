namespace AgendaDeContatos
{
    partial class TelaInicial
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbAdicionar = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblKontact = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbAdicionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // grbAdicionar
            // 
            this.grbAdicionar.Controls.Add(this.txbEmail);
            this.grbAdicionar.Controls.Add(this.lblEmail);
            this.grbAdicionar.Controls.Add(this.btnAdd);
            this.grbAdicionar.Controls.Add(this.txbEndereco);
            this.grbAdicionar.Controls.Add(this.txbTelefone);
            this.grbAdicionar.Controls.Add(this.txbNome);
            this.grbAdicionar.Controls.Add(this.lblEndereco);
            this.grbAdicionar.Controls.Add(this.lblTelefone);
            this.grbAdicionar.Controls.Add(this.lblNome);
            this.grbAdicionar.Location = new System.Drawing.Point(23, 111);
            this.grbAdicionar.Name = "grbAdicionar";
            this.grbAdicionar.Size = new System.Drawing.Size(745, 95);
            this.grbAdicionar.TabIndex = 1;
            this.grbAdicionar.TabStop = false;
            this.grbAdicionar.Text = "Adicionar";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(516, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(358, 19);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(137, 20);
            this.txbEndereco.TabIndex = 5;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(113, 56);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(124, 20);
            this.txbTelefone.TabIndex = 4;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(113, 19);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(124, 20);
            this.txbNome.TabIndex = 3;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(270, 16);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(82, 20);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(32, 56);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 20);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(32, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblKontact
            // 
            this.lblKontact.AutoSize = true;
            this.lblKontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontact.Location = new System.Drawing.Point(457, 49);
            this.lblKontact.Name = "lblKontact";
            this.lblKontact.Size = new System.Drawing.Size(311, 25);
            this.lblKontact.TabIndex = 2;
            this.lblKontact.Text = "Kontakt. :: Agenda de Contatos";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(39, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(23, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Olá";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(270, 56);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 25);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(358, 62);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(137, 20);
            this.txbEmail.TabIndex = 8;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblKontact);
            this.Controls.Add(this.grbAdicionar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbAdicionar.ResumeLayout(false);
            this.grbAdicionar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbAdicionar;
        private System.Windows.Forms.Label lblKontact;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}