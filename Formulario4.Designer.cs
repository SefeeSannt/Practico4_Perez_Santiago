namespace Practico4
{
    partial class frm4
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lstNumeros = new ListBox();
            panel1 = new Panel();
            btnLimpiar = new Button();
            chkPrimos = new CheckBox();
            chkImpares = new CheckBox();
            chkPares = new CheckBox();
            btnGenerar = new Button();
            txtHasta = new TextBox();
            txtDesde = new TextBox();
            lblHasta = new Label();
            lblDesde = new Label();
            lblTitulo = new Label();
            errIngresoDatos = new ErrorProvider(components);
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errIngresoDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 15;
            lstNumeros.Location = new Point(209, 83);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(181, 214);
            lstNumeros.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(chart1);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(chkPrimos);
            panel1.Controls.Add(chkImpares);
            panel1.Controls.Add(chkPares);
            panel1.Controls.Add(btnGenerar);
            panel1.Controls.Add(txtHasta);
            panel1.Controls.Add(txtDesde);
            panel1.Controls.Add(lblHasta);
            panel1.Controls.Add(lblDesde);
            panel1.Controls.Add(lstNumeros);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 315);
            panel1.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(57, 274);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // chkPrimos
            // 
            chkPrimos.AutoSize = true;
            chkPrimos.Location = new Point(17, 241);
            chkPrimos.Name = "chkPrimos";
            chkPrimos.Size = new Size(63, 19);
            chkPrimos.TabIndex = 8;
            chkPrimos.Text = "Primos";
            chkPrimos.UseVisualStyleBackColor = true;
            // 
            // chkImpares
            // 
            chkImpares.AutoSize = true;
            chkImpares.Location = new Point(17, 216);
            chkImpares.Name = "chkImpares";
            chkImpares.Size = new Size(68, 19);
            chkImpares.TabIndex = 7;
            chkImpares.Text = "Impares";
            chkImpares.UseVisualStyleBackColor = true;
            chkImpares.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chkPares
            // 
            chkPares.AutoSize = true;
            chkPares.Location = new Point(17, 191);
            chkPares.Name = "chkPares";
            chkPares.Size = new Size(54, 19);
            chkPares.TabIndex = 6;
            chkPares.Text = "Pares";
            chkPares.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(47, 153);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(114, 23);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "Generar función";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtHasta
            // 
            txtHasta.Location = new Point(86, 112);
            txtHasta.Name = "txtHasta";
            txtHasta.Size = new Size(100, 23);
            txtHasta.TabIndex = 4;
            txtHasta.KeyPress += onlyDigits;
            // 
            // txtDesde
            // 
            txtDesde.Location = new Point(86, 83);
            txtDesde.Name = "txtDesde";
            txtDesde.Size = new Size(100, 23);
            txtDesde.TabIndex = 3;
            txtDesde.KeyPress += onlyDigits;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(17, 115);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(37, 15);
            lblHasta.TabIndex = 2;
            lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(17, 86);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(39, 15);
            lblDesde.TabIndex = 1;
            lblDesde.Text = "Desde";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ActiveBorder;
            lblTitulo.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitulo.ForeColor = SystemColors.HotTrack;
            lblTitulo.Location = new Point(181, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(221, 36);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Lista de numeros";
            // 
            // errIngresoDatos
            // 
            errIngresoDatos.ContainerControl = this;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(414, 83);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 214);
            chart1.TabIndex = 11;
            chart1.Text = "chart1";
            // 
            // frm4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 346);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frm4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario 4";
            Load += frm4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errIngresoDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNumeros;
        private Panel panel1;
        private TextBox txtHasta;
        private TextBox txtDesde;
        private Label lblHasta;
        private Label lblDesde;
        private Label lblTitulo;
        private CheckBox chkPrimos;
        private CheckBox chkImpares;
        private CheckBox chkPares;
        private Button btnGenerar;
        private Button btnLimpiar;
        private ErrorProvider errIngresoDatos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}