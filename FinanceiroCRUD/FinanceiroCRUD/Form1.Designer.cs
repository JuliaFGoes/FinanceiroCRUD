namespace FinanceiroCRUD
{
    partial class Form1
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
            txbDescricao = new TextBox();
            lblDescricao = new Label();
            dtData = new DateTimePicker();
            btnAdd = new Button();
            btnConsultar = new Button();
            btnExcluir = new Button();
            lvDados = new ListView();
            lblData = new Label();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblSaldo = new Label();
            lblSaldoValor = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblValor = new Label();
            txbValor = new TextBox();
            btnAlterar = new Button();
            groupBox1 = new GroupBox();
            dgvDados = new DataGridView();
            groupBox2 = new GroupBox();
            label7 = new Label();
            textBox1 = new TextBox();
            btnFiltrar = new Button();
            label6 = new Label();
            txbDescricaoF = new TextBox();
            cmbTipoF = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txbDescricao
            // 
            txbDescricao.BackColor = Color.LightSteelBlue;
            txbDescricao.Location = new Point(101, 251);
            txbDescricao.Multiline = true;
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new Size(298, 90);
            txbDescricao.TabIndex = 0;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(18, 254);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(77, 20);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição:";
            // 
            // dtData
            // 
            dtData.CalendarMonthBackground = Color.LightSteelBlue;
            dtData.Location = new Point(101, 374);
            dtData.Name = "dtData";
            dtData.Size = new Size(298, 27);
            dtData.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSteelBlue;
            btnAdd.Location = new Point(101, 481);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(761, 480);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightSteelBlue;
            btnExcluir.Location = new Point(227, 481);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lvDados
            // 
            lvDados.Location = new Point(761, 65);
            lvDados.Name = "lvDados";
            lvDados.Size = new Size(226, 386);
            lvDados.TabIndex = 7;
            lvDados.UseCompatibleStateImageBehavior = false;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(51, 379);
            lblData.Name = "lblData";
            lblData.Size = new Size(44, 20);
            lblData.TabIndex = 8;
            lblData.Text = "Data:";
            lblData.Click += lblData_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(53, 438);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 20);
            lblTipo.TabIndex = 9;
            lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = Color.LightSteelBlue;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(101, 435);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(72, 28);
            cmbTipo.TabIndex = 10;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(238, 438);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(50, 20);
            lblSaldo.TabIndex = 11;
            lblSaldo.Text = "Saldo:";
            // 
            // lblSaldoValor
            // 
            lblSaldoValor.AutoSize = true;
            lblSaldoValor.Location = new Point(320, 438);
            lblSaldoValor.Name = "lblSaldoValor";
            lblSaldoValor.Size = new Size(27, 20);
            lblSaldoValor.TabIndex = 12;
            lblSaldoValor.Text = "---";
            lblSaldoValor.Click += lblSaldoValor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 52);
            label1.Name = "label1";
            label1.Size = new Size(158, 30);
            label1.TabIndex = 13;
            label1.Text = "Lançamentos ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 82);
            label2.Name = "label2";
            label2.Size = new Size(271, 37);
            label2.TabIndex = 14;
            label2.Text = "Financeiros Pessoais";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(775, 36);
            label3.Name = "label3";
            label3.Size = new Size(202, 26);
            label3.TabIndex = 15;
            label3.Text = "Registros anteriores:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(49, 193);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(46, 20);
            lblValor.TabIndex = 16;
            lblValor.Text = "Valor:";
            // 
            // txbValor
            // 
            txbValor.BackColor = Color.LightSteelBlue;
            txbValor.Location = new Point(101, 193);
            txbValor.Name = "txbValor";
            txbValor.Size = new Size(298, 27);
            txbValor.TabIndex = 17;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(893, 480);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(94, 29);
            btnAlterar.TabIndex = 18;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FloralWhite;
            groupBox1.Controls.Add(dgvDados);
            groupBox1.Controls.Add(txbDescricao);
            groupBox1.Controls.Add(txbValor);
            groupBox1.Controls.Add(lblDescricao);
            groupBox1.Controls.Add(lblValor);
            groupBox1.Controls.Add(dtData);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(lblData);
            groupBox1.Controls.Add(lblSaldoValor);
            groupBox1.Controls.Add(lblTipo);
            groupBox1.Controls.Add(lblSaldo);
            groupBox1.Controls.Add(cmbTipo);
            groupBox1.Location = new Point(288, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 534);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // dgvDados
            // 
            dgvDados.BackgroundColor = SystemColors.ButtonFace;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(18, 13);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 51;
            dgvDados.Size = new Size(381, 153);
            dgvDados.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FloralWhite;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(btnFiltrar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txbDescricaoF);
            groupBox2.Controls.Add(cmbTipoF);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(288, 341);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 260);
            label7.Name = "label7";
            label7.Size = new Size(27, 20);
            label7.TabIndex = 20;
            label7.Text = "ID:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSteelBlue;
            textBox1.Location = new Point(39, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 18;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.LightSteelBlue;
            btnFiltrar.Location = new Point(176, 189);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 18;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 193);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 18;
            label6.Text = "Tipo:";
            // 
            // txbDescricaoF
            // 
            txbDescricaoF.BackColor = Color.LightSteelBlue;
            txbDescricaoF.Location = new Point(6, 84);
            txbDescricaoF.Multiline = true;
            txbDescricaoF.Name = "txbDescricaoF";
            txbDescricaoF.Size = new Size(276, 90);
            txbDescricaoF.TabIndex = 18;
            // 
            // cmbTipoF
            // 
            cmbTipoF.BackColor = Color.LightSteelBlue;
            cmbTipoF.FormattingEnabled = true;
            cmbTipoF.Location = new Point(54, 190);
            cmbTipoF.Name = "cmbTipoF";
            cmbTipoF.Size = new Size(72, 28);
            cmbTipoF.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 61);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 1;
            label5.Text = "Descrição:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 0;
            label4.Text = "Filtrar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AzulJeans;
            ClientSize = new Size(1038, 546);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAlterar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvDados);
            Controls.Add(btnConsultar);
            Name = "Form1";
            Text = "git";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbDescricao;
        private Label lblDescricao;
        private DateTimePicker dtData;
        private Button btnAdd;
        private Button btnConsultar;
        private Button btnExcluir;
        private ListView lvDados;
        private Label lblData;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Label lblSaldo;
        private Label lblSaldoValor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblValor;
        private TextBox txbValor;
        private Button btnAlterar;
        private GroupBox groupBox1;
        private DataGridView dgvDados;
        private GroupBox groupBox2;
        private TextBox txbDescricaoF;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox textBox1;
        private Button btnFiltrar;
        private Label label6;
        private ComboBox cmbTipoF;
    }
}
