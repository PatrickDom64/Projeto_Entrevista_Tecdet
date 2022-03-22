namespace Projeto_Entrevista
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bt_Abrir = new System.Windows.Forms.Button();
            this.tx_dir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_mostrarJsonBruto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_Placa = new System.Windows.Forms.TextBox();
            this.tx_Data = new System.Windows.Forms.TextBox();
            this.tx_Hora = new System.Windows.Forms.TextBox();
            this.tx_Equipamento = new System.Windows.Forms.TextBox();
            this.tx_Faixa = new System.Windows.Forms.TextBox();
            this.Lb_Lido = new System.Windows.Forms.Label();
            this.bt_Enviar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lb_NãoLido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // bt_Abrir
            // 
            this.bt_Abrir.Location = new System.Drawing.Point(278, 29);
            this.bt_Abrir.Name = "bt_Abrir";
            this.bt_Abrir.Size = new System.Drawing.Size(108, 20);
            this.bt_Abrir.TabIndex = 0;
            this.bt_Abrir.Text = "Abrir";
            this.bt_Abrir.UseVisualStyleBackColor = true;
            this.bt_Abrir.Click += new System.EventHandler(this.bt_Abrir_Click);
            // 
            // tx_dir
            // 
            this.tx_dir.Location = new System.Drawing.Point(12, 29);
            this.tx_dir.Name = "tx_dir";
            this.tx_dir.Size = new System.Drawing.Size(260, 20);
            this.tx_dir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione um Diretorio";
            // 
            // tx_mostrarJsonBruto
            // 
            this.tx_mostrarJsonBruto.Location = new System.Drawing.Point(13, 303);
            this.tx_mostrarJsonBruto.Multiline = true;
            this.tx_mostrarJsonBruto.Name = "tx_mostrarJsonBruto";
            this.tx_mostrarJsonBruto.Size = new System.Drawing.Size(370, 59);
            this.tx_mostrarJsonBruto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Equipamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Faixa";
            // 
            // tx_Placa
            // 
            this.tx_Placa.Location = new System.Drawing.Point(15, 105);
            this.tx_Placa.Name = "tx_Placa";
            this.tx_Placa.Size = new System.Drawing.Size(165, 20);
            this.tx_Placa.TabIndex = 9;
            // 
            // tx_Data
            // 
            this.tx_Data.Location = new System.Drawing.Point(15, 144);
            this.tx_Data.Name = "tx_Data";
            this.tx_Data.Size = new System.Drawing.Size(165, 20);
            this.tx_Data.TabIndex = 10;
            // 
            // tx_Hora
            // 
            this.tx_Hora.Location = new System.Drawing.Point(15, 183);
            this.tx_Hora.Name = "tx_Hora";
            this.tx_Hora.Size = new System.Drawing.Size(165, 20);
            this.tx_Hora.TabIndex = 11;
            // 
            // tx_Equipamento
            // 
            this.tx_Equipamento.Location = new System.Drawing.Point(14, 220);
            this.tx_Equipamento.Name = "tx_Equipamento";
            this.tx_Equipamento.Size = new System.Drawing.Size(166, 20);
            this.tx_Equipamento.TabIndex = 12;
            // 
            // tx_Faixa
            // 
            this.tx_Faixa.Location = new System.Drawing.Point(15, 261);
            this.tx_Faixa.Name = "tx_Faixa";
            this.tx_Faixa.Size = new System.Drawing.Size(165, 20);
            this.tx_Faixa.TabIndex = 13;
            // 
            // Lb_Lido
            // 
            this.Lb_Lido.AutoSize = true;
            this.Lb_Lido.Location = new System.Drawing.Point(373, 128);
            this.Lb_Lido.Name = "Lb_Lido";
            this.Lb_Lido.Size = new System.Drawing.Size(13, 13);
            this.Lb_Lido.TabIndex = 14;
            this.Lb_Lido.Text = "0";
            // 
            // bt_Enviar
            // 
            this.bt_Enviar.Location = new System.Drawing.Point(308, 261);
            this.bt_Enviar.Name = "bt_Enviar";
            this.bt_Enviar.Size = new System.Drawing.Size(75, 23);
            this.bt_Enviar.TabIndex = 15;
            this.bt_Enviar.Text = "Enviar";
            this.bt_Enviar.UseVisualStyleBackColor = true;
            this.bt_Enviar.Click += new System.EventHandler(this.bt_Enviar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Passagem lida com sucesso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Passagem NÃO lida";
            // 
            // Lb_NãoLido
            // 
            this.Lb_NãoLido.AutoSize = true;
            this.Lb_NãoLido.Location = new System.Drawing.Point(373, 190);
            this.Lb_NãoLido.Name = "Lb_NãoLido";
            this.Lb_NãoLido.Size = new System.Drawing.Size(13, 13);
            this.Lb_NãoLido.TabIndex = 18;
            this.Lb_NãoLido.Text = "0";
            this.Lb_NãoLido.Validated += new System.EventHandler(this.bt_Enviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(398, 374);
            this.Controls.Add(this.Lb_NãoLido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_Enviar);
            this.Controls.Add(this.Lb_Lido);
            this.Controls.Add(this.tx_Faixa);
            this.Controls.Add(this.tx_Equipamento);
            this.Controls.Add(this.tx_Hora);
            this.Controls.Add(this.tx_Data);
            this.Controls.Add(this.tx_Placa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_mostrarJsonBruto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_dir);
            this.Controls.Add(this.bt_Abrir);
            this.Name = "Form1";
            this.Text = "Passagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bt_Abrir;
        private System.Windows.Forms.TextBox tx_dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_mostrarJsonBruto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_Placa;
        private System.Windows.Forms.TextBox tx_Data;
        private System.Windows.Forms.TextBox tx_Hora;
        private System.Windows.Forms.TextBox tx_Equipamento;
        private System.Windows.Forms.TextBox tx_Faixa;
        private System.Windows.Forms.Label Lb_Lido;
        private System.Windows.Forms.Button bt_Enviar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lb_NãoLido;
    }
}

