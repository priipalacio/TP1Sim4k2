﻿namespace TPSIM
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txt_semilla = new System.Windows.Forms.TextBox();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.txt_g = new System.Windows.Forms.TextBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.cmb_metodo = new System.Windows.Forms.ComboBox();
            this.lbl_semilla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNumeros = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_siguienteNumero = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_chi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estPrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtn_20 = new System.Windows.Forms.RadioButton();
            this.rbtn_15 = new System.Windows.Forms.RadioButton();
            this.rbtn_10 = new System.Windows.Forms.RadioButton();
            this.rbtn_5 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cant_generada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_generacion = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_pruebaChi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(122, 32);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(100, 22);
            this.txt_semilla.TabIndex = 0;
            // 
            // txt_k
            // 
            this.txt_k.Location = new System.Drawing.Point(122, 81);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(100, 22);
            this.txt_k.TabIndex = 1;
            // 
            // txt_g
            // 
            this.txt_g.Location = new System.Drawing.Point(122, 131);
            this.txt_g.Name = "txt_g";
            this.txt_g.Size = new System.Drawing.Size(100, 22);
            this.txt_g.TabIndex = 2;
            // 
            // btn_generar
            // 
            this.btn_generar.Enabled = false;
            this.btn_generar.Location = new System.Drawing.Point(31, 278);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(81, 28);
            this.btn_generar.TabIndex = 3;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // cmb_metodo
            // 
            this.cmb_metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_metodo.FormattingEnabled = true;
            this.cmb_metodo.Items.AddRange(new object[] {
            "Congruencial Mixto",
            "Congruencial Multiplicativo"});
            this.cmb_metodo.Location = new System.Drawing.Point(122, 171);
            this.cmb_metodo.Name = "cmb_metodo";
            this.cmb_metodo.Size = new System.Drawing.Size(169, 24);
            this.cmb_metodo.TabIndex = 4;
            this.cmb_metodo.SelectedIndexChanged += new System.EventHandler(this.cmb_metodo_SelectedIndexChanged);
            // 
            // lbl_semilla
            // 
            this.lbl_semilla.AutoSize = true;
            this.lbl_semilla.Location = new System.Drawing.Point(63, 35);
            this.lbl_semilla.Name = "lbl_semilla";
            this.lbl_semilla.Size = new System.Drawing.Size(53, 17);
            this.lbl_semilla.TabIndex = 5;
            this.lbl_semilla.Text = "Semilla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Constante k";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Constante g";
            // 
            // txt_c
            // 
            this.txt_c.Enabled = false;
            this.txt_c.Location = new System.Drawing.Point(122, 205);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(100, 22);
            this.txt_c.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Constante c";
            // 
            // dgvNumeros
            // 
            this.dgvNumeros.AllowUserToAddRows = false;
            this.dgvNumeros.AllowUserToDeleteRows = false;
            this.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.numero});
            this.dgvNumeros.Location = new System.Drawing.Point(28, 21);
            this.dgvNumeros.Name = "dgvNumeros";
            this.dgvNumeros.RowHeadersVisible = false;
            this.dgvNumeros.RowHeadersWidth = 51;
            this.dgvNumeros.RowTemplate.Height = 24;
            this.dgvNumeros.Size = new System.Drawing.Size(240, 375);
            this.dgvNumeros.TabIndex = 10;
            // 
            // iteracion
            // 
            this.iteracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iteracion.HeaderText = "Iteración";
            this.iteracion.MinimumWidth = 6;
            this.iteracion.Name = "iteracion";
            this.iteracion.Width = 91;
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numero.HeaderText = "Numero";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.Width = 87;
            // 
            // btn_siguienteNumero
            // 
            this.btn_siguienteNumero.Enabled = false;
            this.btn_siguienteNumero.Location = new System.Drawing.Point(145, 278);
            this.btn_siguienteNumero.Name = "btn_siguienteNumero";
            this.btn_siguienteNumero.Size = new System.Drawing.Size(142, 28);
            this.btn_siguienteNumero.TabIndex = 11;
            this.btn_siguienteNumero.Text = "Siguiente numero";
            this.btn_siguienteNumero.UseVisualStyleBackColor = true;
            this.btn_siguienteNumero.Click += new System.EventHandler(this.btn_siguienteNumero_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_semilla);
            this.groupBox1.Controls.Add(this.btn_siguienteNumero);
            this.groupBox1.Controls.Add(this.txt_k);
            this.groupBox1.Controls.Add(this.txt_g);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_generar);
            this.groupBox1.Controls.Add(this.txt_c);
            this.groupBox1.Controls.Add(this.cmb_metodo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_semilla);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 328);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Punto a)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Metodo";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(58, 402);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(189, 59);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Limpiar todo";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_pruebaChi);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.rbtn_20);
            this.groupBox2.Controls.Add(this.rbtn_15);
            this.groupBox2.Controls.Add(this.rbtn_10);
            this.groupBox2.Controls.Add(this.rbtn_5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_cant_generada);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmb_generacion);
            this.groupBox2.Location = new System.Drawing.Point(638, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 478);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Punto b) y c)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_chi);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(21, 361);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi-Cuadrado calculado";
            // 
            // lbl_chi
            // 
            this.lbl_chi.AutoSize = true;
            this.lbl_chi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chi.Location = new System.Drawing.Point(14, 37);
            this.lbl_chi.Name = "lbl_chi";
            this.lbl_chi.Size = new System.Drawing.Size(175, 29);
            this.lbl_chi.TabIndex = 0;
            this.lbl_chi.Text = "Chi-Cuadrado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalo,
            this.fObservada,
            this.fEsperada,
            this.estPrueba});
            this.dataGridView1.Location = new System.Drawing.Point(20, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(527, 172);
            this.dataGridView1.TabIndex = 8;
            // 
            // intervalo
            // 
            this.intervalo.HeaderText = "Intervalo";
            this.intervalo.MinimumWidth = 6;
            this.intervalo.Name = "intervalo";
            this.intervalo.Width = 125;
            // 
            // fObservada
            // 
            this.fObservada.HeaderText = "Frecuencia Observada";
            this.fObservada.MinimumWidth = 6;
            this.fObservada.Name = "fObservada";
            this.fObservada.Width = 125;
            // 
            // fEsperada
            // 
            this.fEsperada.HeaderText = "Frecuencia Esperada";
            this.fEsperada.MinimumWidth = 6;
            this.fEsperada.Name = "fEsperada";
            this.fEsperada.Width = 125;
            // 
            // estPrueba
            // 
            this.estPrueba.HeaderText = "((Fo-Fe)^2)/Fe";
            this.estPrueba.MinimumWidth = 6;
            this.estPrueba.Name = "estPrueba";
            this.estPrueba.Width = 125;
            // 
            // rbtn_20
            // 
            this.rbtn_20.AutoSize = true;
            this.rbtn_20.Location = new System.Drawing.Point(374, 80);
            this.rbtn_20.Name = "rbtn_20";
            this.rbtn_20.Size = new System.Drawing.Size(110, 21);
            this.rbtn_20.TabIndex = 7;
            this.rbtn_20.TabStop = true;
            this.rbtn_20.Text = "20 Intervalos";
            this.rbtn_20.UseVisualStyleBackColor = true;
            // 
            // rbtn_15
            // 
            this.rbtn_15.AutoSize = true;
            this.rbtn_15.Location = new System.Drawing.Point(257, 80);
            this.rbtn_15.Name = "rbtn_15";
            this.rbtn_15.Size = new System.Drawing.Size(110, 21);
            this.rbtn_15.TabIndex = 6;
            this.rbtn_15.TabStop = true;
            this.rbtn_15.Text = "15 Intervalos";
            this.rbtn_15.UseVisualStyleBackColor = true;
            // 
            // rbtn_10
            // 
            this.rbtn_10.AutoSize = true;
            this.rbtn_10.Location = new System.Drawing.Point(140, 80);
            this.rbtn_10.Name = "rbtn_10";
            this.rbtn_10.Size = new System.Drawing.Size(110, 21);
            this.rbtn_10.TabIndex = 5;
            this.rbtn_10.TabStop = true;
            this.rbtn_10.Text = "10 Intervalos";
            this.rbtn_10.UseVisualStyleBackColor = true;
            // 
            // rbtn_5
            // 
            this.rbtn_5.AutoSize = true;
            this.rbtn_5.Location = new System.Drawing.Point(31, 81);
            this.rbtn_5.Name = "rbtn_5";
            this.rbtn_5.Size = new System.Drawing.Size(102, 21);
            this.rbtn_5.TabIndex = 4;
            this.rbtn_5.TabStop = true;
            this.rbtn_5.Text = "5 Intervalos";
            this.rbtn_5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cantidad a generar: ";
            // 
            // txt_cant_generada
            // 
            this.txt_cant_generada.Enabled = false;
            this.txt_cant_generada.Location = new System.Drawing.Point(448, 34);
            this.txt_cant_generada.Name = "txt_cant_generada";
            this.txt_cant_generada.Size = new System.Drawing.Size(100, 22);
            this.txt_cant_generada.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Generación por: ";
            // 
            // cmb_generacion
            // 
            this.cmb_generacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_generacion.FormattingEnabled = true;
            this.cmb_generacion.Items.AddRange(new object[] {
            "Random Lenguaje",
            "Congruencial Mixto"});
            this.cmb_generacion.Location = new System.Drawing.Point(139, 34);
            this.cmb_generacion.Name = "cmb_generacion";
            this.cmb_generacion.Size = new System.Drawing.Size(150, 24);
            this.cmb_generacion.TabIndex = 0;
            this.cmb_generacion.SelectedIndexChanged += new System.EventHandler(this.cmb_generacion_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_clear);
            this.groupBox3.Controls.Add(this.dgvNumeros);
            this.groupBox3.Location = new System.Drawing.Point(336, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 478);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabla de numeros";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grafico);
            this.groupBox5.Location = new System.Drawing.Point(12, 506);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1198, 335);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Grafico";
            // 
            // grafico
            // 
            chartArea4.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.grafico.Legends.Add(legend4);
            this.grafico.Location = new System.Drawing.Point(6, 22);
            this.grafico.Name = "grafico";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.grafico.Series.Add(series4);
            this.grafico.Size = new System.Drawing.Size(1167, 300);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            // 
            // btn_pruebaChi
            // 
            this.btn_pruebaChi.Enabled = false;
            this.btn_pruebaChi.Location = new System.Drawing.Point(194, 119);
            this.btn_pruebaChi.Name = "btn_pruebaChi";
            this.btn_pruebaChi.Size = new System.Drawing.Size(142, 44);
            this.btn_pruebaChi.TabIndex = 10;
            this.btn_pruebaChi.Text = "Realizar prueba Chi^2";
            this.btn_pruebaChi.UseVisualStyleBackColor = true;
            this.btn_pruebaChi.Click += new System.EventHandler(this.btn_pruebaChi_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 853);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Generador de Números Aleatorios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_semilla;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.TextBox txt_g;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.ComboBox cmb_metodo;
        private System.Windows.Forms.Label lbl_semilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.Button btn_siguienteNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn estPrueba;
        private System.Windows.Forms.RadioButton rbtn_20;
        private System.Windows.Forms.RadioButton rbtn_15;
        private System.Windows.Forms.RadioButton rbtn_10;
        private System.Windows.Forms.RadioButton rbtn_5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cant_generada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_generacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_chi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button btn_pruebaChi;
    }
}

