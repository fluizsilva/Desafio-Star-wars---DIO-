
namespace EstrelaDaMorte.Forms
{
    partial class frmRegistrarEntradaSaida
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lvAlertas = new System.Windows.Forms.ListView();
            this.grbDadosRegistro = new System.Windows.Forms.GroupBox();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.lblNomeNave = new System.Windows.Forms.Label();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.lblNomePiloto = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAlertas = new System.Windows.Forms.Label();
            this.grbDadosRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(470, 12);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar Entrada/Saída";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lvAlertas
            // 
            this.lvAlertas.HideSelection = false;
            this.lvAlertas.Location = new System.Drawing.Point(12, 246);
            this.lvAlertas.Name = "lvAlertas";
            this.lvAlertas.Size = new System.Drawing.Size(533, 192);
            this.lvAlertas.TabIndex = 1;
            this.lvAlertas.UseCompatibleStateImageBehavior = false;
            // 
            // grbDadosRegistro
            // 
            this.grbDadosRegistro.Controls.Add(this.lblPlaneta);
            this.grbDadosRegistro.Controls.Add(this.lblNomeNave);
            this.grbDadosRegistro.Controls.Add(this.lblAnoNascimento);
            this.grbDadosRegistro.Controls.Add(this.lblNomePiloto);
            this.grbDadosRegistro.Controls.Add(this.lblClasse);
            this.grbDadosRegistro.Controls.Add(this.lblModelo);
            this.grbDadosRegistro.Location = new System.Drawing.Point(12, 12);
            this.grbDadosRegistro.Name = "grbDadosRegistro";
            this.grbDadosRegistro.Size = new System.Drawing.Size(398, 203);
            this.grbDadosRegistro.TabIndex = 8;
            this.grbDadosRegistro.TabStop = false;
            this.grbDadosRegistro.Text = "Dados do Registro";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(22, 177);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(49, 15);
            this.lblPlaneta.TabIndex = 13;
            this.lblPlaneta.Text = "Planeta:";
            // 
            // lblNomeNave
            // 
            this.lblNomeNave.AutoSize = true;
            this.lblNomeNave.Location = new System.Drawing.Point(22, 144);
            this.lblNomeNave.Name = "lblNomeNave";
            this.lblNomeNave.Size = new System.Drawing.Size(89, 15);
            this.lblNomeNave.TabIndex = 12;
            this.lblNomeNave.Text = "Nome da Nave:";
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(22, 111);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(99, 15);
            this.lblAnoNascimento.TabIndex = 11;
            this.lblAnoNascimento.Text = "Ano Nascimento:";
            // 
            // lblNomePiloto
            // 
            this.lblNomePiloto.AutoSize = true;
            this.lblNomePiloto.Location = new System.Drawing.Point(22, 84);
            this.lblNomePiloto.Name = "lblNomePiloto";
            this.lblNomePiloto.Size = new System.Drawing.Size(94, 15);
            this.lblNomePiloto.TabIndex = 10;
            this.lblNomePiloto.Text = "Nome do Piloto:";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(22, 55);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(43, 15);
            this.lblClasse.TabIndex = 9;
            this.lblClasse.Text = "Classe:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(22, 27);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(51, 15);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblAlertas
            // 
            this.lblAlertas.AutoSize = true;
            this.lblAlertas.Location = new System.Drawing.Point(12, 228);
            this.lblAlertas.Name = "lblAlertas";
            this.lblAlertas.Size = new System.Drawing.Size(43, 15);
            this.lblAlertas.TabIndex = 9;
            this.lblAlertas.Text = "Alertas";
            // 
            // frmRegistrarEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.lblAlertas);
            this.Controls.Add(this.grbDadosRegistro);
            this.Controls.Add(this.lvAlertas);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "frmRegistrarEntradaSaida";
            this.Text = "Registro de Entradas / Saídas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistrarEntradaSaida_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistrarEntradaSaida_Load);
            this.grbDadosRegistro.ResumeLayout(false);
            this.grbDadosRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListView lvAlertas;
        private System.Windows.Forms.GroupBox grbDadosRegistro;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Label lblNomeNave;
        private System.Windows.Forms.Label lblAnoNascimento;
        private System.Windows.Forms.Label lblNomePiloto;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAlertas;
    }
}