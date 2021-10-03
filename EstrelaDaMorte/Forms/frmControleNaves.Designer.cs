
namespace EstrelaDaMorte.Forms
{
    partial class frmControleNaves
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
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnBuscarNave = new System.Windows.Forms.Button();
            this.btnBuscarPiloto = new System.Windows.Forms.Button();
            this.dgvNaves = new System.Windows.Forms.DataGridView();
            this.txtNomeNave = new System.Windows.Forms.TextBox();
            this.txtNomePiloto = new System.Windows.Forms.TextBox();
            this.lblNomeNave = new System.Windows.Forms.Label();
            this.lblNomePiloto = new System.Windows.Forms.Label();
            this.panDestino = new System.Windows.Forms.Panel();
            this.rdbChegando = new System.Windows.Forms.RadioButton();
            this.rdbSaindo = new System.Windows.Forms.RadioButton();
            this.dgvPilotos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaves)).BeginInit();
            this.panDestino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(284, 415);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 0;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnBuscarNave
            // 
            this.btnBuscarNave.Location = new System.Drawing.Point(302, 23);
            this.btnBuscarNave.Name = "btnBuscarNave";
            this.btnBuscarNave.Size = new System.Drawing.Size(99, 23);
            this.btnBuscarNave.TabIndex = 1;
            this.btnBuscarNave.Text = "Buscar Nave";
            this.btnBuscarNave.UseVisualStyleBackColor = true;
            this.btnBuscarNave.Click += new System.EventHandler(this.btnBuscarNave_Click);
            // 
            // btnBuscarPiloto
            // 
            this.btnBuscarPiloto.Location = new System.Drawing.Point(720, 23);
            this.btnBuscarPiloto.Name = "btnBuscarPiloto";
            this.btnBuscarPiloto.Size = new System.Drawing.Size(92, 23);
            this.btnBuscarPiloto.TabIndex = 2;
            this.btnBuscarPiloto.Text = "Buscar Piloto";
            this.btnBuscarPiloto.UseVisualStyleBackColor = true;
            this.btnBuscarPiloto.Click += new System.EventHandler(this.btnBuscarPiloto_Click);
            // 
            // dgvNaves
            // 
            this.dgvNaves.AllowUserToAddRows = false;
            this.dgvNaves.AllowUserToDeleteRows = false;
            this.dgvNaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaves.Location = new System.Drawing.Point(23, 54);
            this.dgvNaves.Name = "dgvNaves";
            this.dgvNaves.RowTemplate.Height = 25;
            this.dgvNaves.Size = new System.Drawing.Size(378, 312);
            this.dgvNaves.TabIndex = 4;
            // 
            // txtNomeNave
            // 
            this.txtNomeNave.Location = new System.Drawing.Point(23, 23);
            this.txtNomeNave.Name = "txtNomeNave";
            this.txtNomeNave.Size = new System.Drawing.Size(272, 23);
            this.txtNomeNave.TabIndex = 5;
            // 
            // txtNomePiloto
            // 
            this.txtNomePiloto.Location = new System.Drawing.Point(435, 23);
            this.txtNomePiloto.Name = "txtNomePiloto";
            this.txtNomePiloto.Size = new System.Drawing.Size(275, 23);
            this.txtNomePiloto.TabIndex = 6;
            // 
            // lblNomeNave
            // 
            this.lblNomeNave.AutoSize = true;
            this.lblNomeNave.Location = new System.Drawing.Point(23, 5);
            this.lblNomeNave.Name = "lblNomeNave";
            this.lblNomeNave.Size = new System.Drawing.Size(91, 15);
            this.lblNomeNave.TabIndex = 9;
            this.lblNomeNave.Text = "Filtrar Por Nave:";
            // 
            // lblNomePiloto
            // 
            this.lblNomePiloto.AutoSize = true;
            this.lblNomePiloto.Location = new System.Drawing.Point(435, 5);
            this.lblNomePiloto.Name = "lblNomePiloto";
            this.lblNomePiloto.Size = new System.Drawing.Size(92, 15);
            this.lblNomePiloto.TabIndex = 10;
            this.lblNomePiloto.Text = "Filtrar por Piloto";
            // 
            // panDestino
            // 
            this.panDestino.Controls.Add(this.rdbChegando);
            this.panDestino.Controls.Add(this.rdbSaindo);
            this.panDestino.Location = new System.Drawing.Point(23, 383);
            this.panDestino.Name = "panDestino";
            this.panDestino.Size = new System.Drawing.Size(177, 55);
            this.panDestino.TabIndex = 11;
            // 
            // rdbChegando
            // 
            this.rdbChegando.AutoSize = true;
            this.rdbChegando.Location = new System.Drawing.Point(83, 20);
            this.rdbChegando.Name = "rdbChegando";
            this.rdbChegando.Size = new System.Drawing.Size(80, 19);
            this.rdbChegando.TabIndex = 9;
            this.rdbChegando.Text = "Chegando";
            this.rdbChegando.UseVisualStyleBackColor = true;
            // 
            // rdbSaindo
            // 
            this.rdbSaindo.AutoSize = true;
            this.rdbSaindo.Checked = true;
            this.rdbSaindo.Location = new System.Drawing.Point(16, 20);
            this.rdbSaindo.Name = "rdbSaindo";
            this.rdbSaindo.Size = new System.Drawing.Size(61, 19);
            this.rdbSaindo.TabIndex = 8;
            this.rdbSaindo.TabStop = true;
            this.rdbSaindo.Text = "Saindo";
            this.rdbSaindo.UseVisualStyleBackColor = true;
            // 
            // dgvPilotos
            // 
            this.dgvPilotos.AllowUserToAddRows = false;
            this.dgvPilotos.AllowUserToDeleteRows = false;
            this.dgvPilotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPilotos.Location = new System.Drawing.Point(434, 54);
            this.dgvPilotos.Name = "dgvPilotos";
            this.dgvPilotos.RowTemplate.Height = 25;
            this.dgvPilotos.Size = new System.Drawing.Size(378, 312);
            this.dgvPilotos.TabIndex = 12;
            // 
            // frmControleNaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.dgvPilotos);
            this.Controls.Add(this.panDestino);
            this.Controls.Add(this.lblNomePiloto);
            this.Controls.Add(this.lblNomeNave);
            this.Controls.Add(this.txtNomePiloto);
            this.Controls.Add(this.txtNomeNave);
            this.Controls.Add(this.dgvNaves);
            this.Controls.Add(this.btnBuscarPiloto);
            this.Controls.Add(this.btnBuscarNave);
            this.Controls.Add(this.btnAvancar);
            this.Name = "frmControleNaves";
            this.Text = "Controle de Naves";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmControleNaves_FormClosing);
            this.Load += new System.EventHandler(this.frmControleNaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaves)).EndInit();
            this.panDestino.ResumeLayout(false);
            this.panDestino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnBuscarNave;
        private System.Windows.Forms.Button btnBuscarPiloto;
        private System.Windows.Forms.DataGridView dgvNaves;
        private System.Windows.Forms.TextBox txtNomeNave;
        private System.Windows.Forms.TextBox txtNomePiloto;
        private System.Windows.Forms.Label lblNomeNave;
        private System.Windows.Forms.Label lblNomePiloto;
        private System.Windows.Forms.Panel panDestino;
        private System.Windows.Forms.RadioButton rdbChegando;
        private System.Windows.Forms.RadioButton rdbSaindo;
        private System.Windows.Forms.DataGridView dgvPilotos;
    }
}