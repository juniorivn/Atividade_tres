namespace Poder_Habito
{
    partial class CriarRotina
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblTermino = new System.Windows.Forms.Label();
            this.lblAtividade = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.txtAtividade = new System.Windows.Forms.TextBox();
            this.txtHrIn = new System.Windows.Forms.TextBox();
            this.txtHrTerm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMmIni = new System.Windows.Forms.TextBox();
            this.txtMmTer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRIA UMA ATIVIDADE DIÁRIA";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(159, 114);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(23, 13);
            this.lblDia.TabIndex = 1;
            this.lblDia.Text = "Dia";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(159, 179);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 2;
            this.lblInicio.Text = "Inicio";
            // 
            // lblTermino
            // 
            this.lblTermino.AutoSize = true;
            this.lblTermino.Location = new System.Drawing.Point(159, 210);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(45, 13);
            this.lblTermino.TabIndex = 3;
            this.lblTermino.Text = "Termino";
            // 
            // lblAtividade
            // 
            this.lblAtividade.AutoSize = true;
            this.lblAtividade.Location = new System.Drawing.Point(159, 146);
            this.lblAtividade.Name = "lblAtividade";
            this.lblAtividade.Size = new System.Drawing.Size(51, 13);
            this.lblAtividade.TabIndex = 4;
            this.lblAtividade.Text = "Atividade";
            // 
            // cmbDia
            // 
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado",
            "Domingo"});
            this.cmbDia.Location = new System.Drawing.Point(243, 111);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(177, 21);
            this.cmbDia.TabIndex = 5;
            // 
            // txtAtividade
            // 
            this.txtAtividade.Location = new System.Drawing.Point(243, 146);
            this.txtAtividade.Name = "txtAtividade";
            this.txtAtividade.Size = new System.Drawing.Size(177, 20);
            this.txtAtividade.TabIndex = 6;
            // 
            // txtHrIn
            // 
            this.txtHrIn.Location = new System.Drawing.Point(243, 179);
            this.txtHrIn.Name = "txtHrIn";
            this.txtHrIn.Size = new System.Drawing.Size(32, 20);
            this.txtHrIn.TabIndex = 7;
            this.txtHrIn.Text = "HH";
            this.txtHrIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHrTerm
            // 
            this.txtHrTerm.Location = new System.Drawing.Point(243, 210);
            this.txtHrTerm.Name = "txtHrTerm";
            this.txtHrTerm.Size = new System.Drawing.Size(32, 20);
            this.txtHrTerm.TabIndex = 8;
            this.txtHrTerm.Text = "HH";
            this.txtHrTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Incluir Atividade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMmIni
            // 
            this.txtMmIni.Location = new System.Drawing.Point(298, 179);
            this.txtMmIni.Name = "txtMmIni";
            this.txtMmIni.Size = new System.Drawing.Size(32, 20);
            this.txtMmIni.TabIndex = 10;
            this.txtMmIni.Text = "MM";
            this.txtMmIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMmTer
            // 
            this.txtMmTer.Location = new System.Drawing.Point(298, 210);
            this.txtMmTer.Name = "txtMmTer";
            this.txtMmTer.Size = new System.Drawing.Size(32, 20);
            this.txtMmTer.TabIndex = 11;
            this.txtMmTer.Text = "MM";
            this.txtMmTer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = ":";
            // 
            // CriarRotina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMmTer);
            this.Controls.Add(this.txtMmIni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHrTerm);
            this.Controls.Add(this.txtHrIn);
            this.Controls.Add(this.txtAtividade);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.lblAtividade);
            this.Controls.Add(this.lblTermino);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CriarRotina";
            this.Text = "CriarRotina";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblTermino;
        private System.Windows.Forms.Label lblAtividade;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.TextBox txtAtividade;
        private System.Windows.Forms.TextBox txtHrIn;
        private System.Windows.Forms.TextBox txtHrTerm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMmIni;
        private System.Windows.Forms.TextBox txtMmTer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}