
namespace CalculoObras
{
    partial class Form1
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
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPrazoContratual = new System.Windows.Forms.NumericUpDown();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDescricaoOrdemSuspensao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDownPrazo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDescricaoTermoAditamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.numericUpDownPrazo2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdicionar2 = new System.Windows.Forms.Button();
            this.dateTimePickerInicio2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownDiaCalcularData = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerDataCalcularData = new System.Windows.Forms.DateTimePicker();
            this.labelDataCalculada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrazoContratual)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrazo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrazo2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiaCalcularData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data início:";
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(108, 18);
            this.dateTimePickerDataInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(123, 26);
            this.dateTimePickerDataInicio.TabIndex = 1;
            this.dateTimePickerDataInicio.Value = new System.DateTime(2021, 2, 28, 11, 37, 24, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prazo contratual (dias):";
            // 
            // numericUpDownPrazoContratual
            // 
            this.numericUpDownPrazoContratual.Location = new System.Drawing.Point(441, 21);
            this.numericUpDownPrazoContratual.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownPrazoContratual.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrazoContratual.Name = "numericUpDownPrazoContratual";
            this.numericUpDownPrazoContratual.Size = new System.Drawing.Size(97, 26);
            this.numericUpDownPrazoContratual.TabIndex = 3;
            this.numericUpDownPrazoContratual.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(445, 287);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(422, 29);
            this.buttonCalcular.TabIndex = 5;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDescricaoOrdemSuspensao);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.numericUpDownPrazo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonAdicionar);
            this.groupBox1.Controls.Add(this.dateTimePickerInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 219);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordem de Suspensão";
            // 
            // textBoxDescricaoOrdemSuspensao
            // 
            this.textBoxDescricaoOrdemSuspensao.Location = new System.Drawing.Point(104, 68);
            this.textBoxDescricaoOrdemSuspensao.Name = "textBoxDescricaoOrdemSuspensao";
            this.textBoxDescricaoOrdemSuspensao.Size = new System.Drawing.Size(309, 26);
            this.textBoxDescricaoOrdemSuspensao.TabIndex = 2322;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Descrição:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(17, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(396, 104);
            this.listBox1.TabIndex = 28;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // numericUpDownPrazo
            // 
            this.numericUpDownPrazo.Location = new System.Drawing.Point(308, 30);
            this.numericUpDownPrazo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownPrazo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrazo.Name = "numericUpDownPrazo";
            this.numericUpDownPrazo.Size = new System.Drawing.Size(72, 26);
            this.numericUpDownPrazo.TabIndex = 20;
            this.numericUpDownPrazo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Prazo (dias):";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(386, 28);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(27, 29);
            this.buttonAdicionar.TabIndex = 23;
            this.buttonAdicionar.Text = "+";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(71, 29);
            this.dateTimePickerInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(123, 26);
            this.dateTimePickerInicio.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Início:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDescricaoTermoAditamento);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.numericUpDownPrazo2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonAdicionar2);
            this.groupBox2.Controls.Add(this.dateTimePickerInicio2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(445, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 218);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Termo de Aditamento";
            // 
            // textBoxDescricaoTermoAditamento
            // 
            this.textBoxDescricaoTermoAditamento.Location = new System.Drawing.Point(104, 67);
            this.textBoxDescricaoTermoAditamento.Name = "textBoxDescricaoTermoAditamento";
            this.textBoxDescricaoTermoAditamento.Size = new System.Drawing.Size(309, 26);
            this.textBoxDescricaoTermoAditamento.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Descrição:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(17, 103);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(396, 104);
            this.listBox2.TabIndex = 27;
            this.listBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox2_KeyDown);
            // 
            // numericUpDownPrazo2
            // 
            this.numericUpDownPrazo2.Location = new System.Drawing.Point(308, 29);
            this.numericUpDownPrazo2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownPrazo2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrazo2.Name = "numericUpDownPrazo2";
            this.numericUpDownPrazo2.Size = new System.Drawing.Size(72, 26);
            this.numericUpDownPrazo2.TabIndex = 20;
            this.numericUpDownPrazo2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Prazo (dias):";
            // 
            // buttonAdicionar2
            // 
            this.buttonAdicionar2.Location = new System.Drawing.Point(386, 28);
            this.buttonAdicionar2.Name = "buttonAdicionar2";
            this.buttonAdicionar2.Size = new System.Drawing.Size(27, 29);
            this.buttonAdicionar2.TabIndex = 25;
            this.buttonAdicionar2.Text = "+";
            this.buttonAdicionar2.UseVisualStyleBackColor = true;
            this.buttonAdicionar2.Click += new System.EventHandler(this.buttonAdicionar2_Click);
            // 
            // dateTimePickerInicio2
            // 
            this.dateTimePickerInicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicio2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio2.Location = new System.Drawing.Point(71, 29);
            this.dateTimePickerInicio2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerInicio2.Name = "dateTimePickerInicio2";
            this.dateTimePickerInicio2.Size = new System.Drawing.Size(123, 26);
            this.dateTimePickerInicio2.TabIndex = 16;
            this.dateTimePickerInicio2.Value = new System.DateTime(2021, 2, 28, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Início:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 322);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(855, 261);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(12, 287);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(422, 29);
            this.buttonLimpar.TabIndex = 18;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDataCalculada);
            this.groupBox3.Controls.Add(this.numericUpDownDiaCalcularData);
            this.groupBox3.Controls.Add(this.dateTimePickerDataCalcularData);
            this.groupBox3.Location = new System.Drawing.Point(549, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 51);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calcular data";
            // 
            // numericUpDownDiaCalcularData
            // 
            this.numericUpDownDiaCalcularData.Location = new System.Drawing.Point(130, 19);
            this.numericUpDownDiaCalcularData.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownDiaCalcularData.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDiaCalcularData.Name = "numericUpDownDiaCalcularData";
            this.numericUpDownDiaCalcularData.Size = new System.Drawing.Size(60, 26);
            this.numericUpDownDiaCalcularData.TabIndex = 25;
            this.numericUpDownDiaCalcularData.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDiaCalcularData.ValueChanged += new System.EventHandler(this.numericUpDownDiaCalcularData_ValueChanged);
            // 
            // dateTimePickerDataCalcularData
            // 
            this.dateTimePickerDataCalcularData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataCalcularData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataCalcularData.Location = new System.Drawing.Point(6, 19);
            this.dateTimePickerDataCalcularData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerDataCalcularData.Name = "dateTimePickerDataCalcularData";
            this.dateTimePickerDataCalcularData.Size = new System.Drawing.Size(117, 26);
            this.dateTimePickerDataCalcularData.TabIndex = 24;
            this.dateTimePickerDataCalcularData.ValueChanged += new System.EventHandler(this.dateTimePickerDataCalcularData_ValueChanged);
            // 
            // labelDataCalculada
            // 
            this.labelDataCalculada.AutoSize = true;
            this.labelDataCalculada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataCalculada.Location = new System.Drawing.Point(200, 21);
            this.labelDataCalculada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataCalculada.Name = "labelDataCalculada";
            this.labelDataCalculada.Size = new System.Drawing.Size(0, 20);
            this.labelDataCalculada.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 595);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.numericUpDownPrazoContratual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDataInicio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo Obras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrazoContratual)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrazo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrazo2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiaCalcularData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPrazoContratual;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAdicionar2;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownPrazo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPrazo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBoxDescricaoOrdemSuspensao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDescricaoTermoAditamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelDataCalculada;
        private System.Windows.Forms.NumericUpDown numericUpDownDiaCalcularData;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataCalcularData;
    }
}

