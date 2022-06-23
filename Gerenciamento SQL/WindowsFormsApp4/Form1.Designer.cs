using System.Collections.Generic;

namespace WindowsFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.idcolumnheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.placacolumnheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.horaentradacolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.horasaidacolumnheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.permanenciacolumnheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnheadervalor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnheaderestacionado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtboxplaca = new System.Windows.Forms.TextBox();
            this.lblplaca = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnexportar = new System.Windows.Forms.Button();
            this.btnimportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblvagas = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtvagas = new System.Windows.Forms.TextBox();
            this.btnconfigurar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idcolumnheader,
            this.placacolumnheader,
            this.horaentradacolumn,
            this.horasaidacolumnheader,
            this.permanenciacolumnheader,
            this.columnheadervalor,
            this.columnheaderestacionado});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(663, 254);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // idcolumnheader
            // 
            this.idcolumnheader.Text = "ID";
            // 
            // placacolumnheader
            // 
            this.placacolumnheader.Text = "Placa";
            this.placacolumnheader.Width = 80;
            // 
            // horaentradacolumn
            // 
            this.horaentradacolumn.Text = "Hora Entrada";
            this.horaentradacolumn.Width = 120;
            // 
            // horasaidacolumnheader
            // 
            this.horasaidacolumnheader.Text = "Hora saída";
            this.horasaidacolumnheader.Width = 120;
            // 
            // permanenciacolumnheader
            // 
            this.permanenciacolumnheader.Text = "Tempo de permanência";
            this.permanenciacolumnheader.Width = 130;
            // 
            // columnheadervalor
            // 
            this.columnheadervalor.Text = "Valor Cobrado";
            this.columnheadervalor.Width = 69;
            // 
            // columnheaderestacionado
            // 
            this.columnheaderestacionado.Text = "Estacionado";
            this.columnheaderestacionado.Width = 80;
            // 
            // txtboxplaca
            // 
            this.txtboxplaca.Location = new System.Drawing.Point(12, 296);
            this.txtboxplaca.Name = "txtboxplaca";
            this.txtboxplaca.Size = new System.Drawing.Size(101, 20);
            this.txtboxplaca.TabIndex = 2;
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Location = new System.Drawing.Point(12, 280);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(37, 13);
            this.lblplaca.TabIndex = 3;
            this.lblplaca.Text = "Placa:";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(12, 323);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(101, 32);
            this.btnregistrar.TabIndex = 4;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexportar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Location = new System.Drawing.Point(548, 296);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(112, 47);
            this.btnexportar.TabIndex = 5;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // btnimportar
            // 
            this.btnimportar.BackColor = System.Drawing.SystemColors.Control;
            this.btnimportar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnimportar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimportar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnimportar.Location = new System.Drawing.Point(548, 348);
            this.btnimportar.Name = "btnimportar";
            this.btnimportar.Size = new System.Drawing.Size(112, 47);
            this.btnimportar.TabIndex = 6;
            this.btnimportar.Text = "Importar";
            this.btnimportar.UseVisualStyleBackColor = false;
            this.btnimportar.Click += new System.EventHandler(this.btnimportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vagas:";
            // 
            // lblvagas
            // 
            this.lblvagas.AutoSize = true;
            this.lblvagas.Location = new System.Drawing.Point(49, 378);
            this.lblvagas.Name = "lblvagas";
            this.lblvagas.Size = new System.Drawing.Size(0, 13);
            this.lblvagas.TabIndex = 8;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(430, 297);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 9;
            // 
            // txtvagas
            // 
            this.txtvagas.Location = new System.Drawing.Point(430, 323);
            this.txtvagas.Name = "txtvagas";
            this.txtvagas.Size = new System.Drawing.Size(100, 20);
            this.txtvagas.TabIndex = 10;
            // 
            // btnconfigurar
            // 
            this.btnconfigurar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfigurar.Location = new System.Drawing.Point(430, 347);
            this.btnconfigurar.Name = "btnconfigurar";
            this.btnconfigurar.Size = new System.Drawing.Size(100, 47);
            this.btnconfigurar.TabIndex = 11;
            this.btnconfigurar.Text = "Configurar";
            this.btnconfigurar.UseVisualStyleBackColor = true;
            this.btnconfigurar.Click += new System.EventHandler(this.btnconfigurar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Vagas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(683, 409);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnconfigurar);
            this.Controls.Add(this.txtvagas);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.lblvagas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnimportar);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.txtboxplaca);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gerenciador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idcolumnheader;
        private System.Windows.Forms.ColumnHeader placacolumnheader;
        private System.Windows.Forms.ColumnHeader horaentradacolumn;
        private System.Windows.Forms.TextBox txtboxplaca;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.ColumnHeader horasaidacolumnheader;
        private System.Windows.Forms.ColumnHeader permanenciacolumnheader;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.Button btnimportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblvagas;
        private System.Windows.Forms.ColumnHeader columnheadervalor;
        private System.Windows.Forms.ColumnHeader columnheaderestacionado;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtvagas;
        private System.Windows.Forms.Button btnconfigurar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

