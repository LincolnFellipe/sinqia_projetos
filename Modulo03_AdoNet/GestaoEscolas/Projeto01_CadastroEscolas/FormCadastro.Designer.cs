namespace Projeto01_CadastroEscolas
{
	partial class formCadastro
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.incluirEscolaButton = new System.Windows.Forms.Button();
			this.telefoneEscolaTextBox = new System.Windows.Forms.TextBox();
			this.enderecoEscolaTextBox = new System.Windows.Forms.TextBox();
			this.descricaoEscolaTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.incluirCursoButton = new System.Windows.Forms.Button();
			this.precoTextBox = new System.Windows.Forms.TextBox();
			this.cargahorariaCursoTextBox = new System.Windows.Forms.TextBox();
			this.descricaoCursoTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buscarEscolaButton = new System.Windows.Forms.Button();
			this.escolaComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.codigoCursoTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cursosDataGridView = new System.Windows.Forms.DataGridView();
			this.buscarCodigoButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cursosDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.incluirEscolaButton);
			this.groupBox1.Controls.Add(this.telefoneEscolaTextBox);
			this.groupBox1.Controls.Add(this.enderecoEscolaTextBox);
			this.groupBox1.Controls.Add(this.descricaoEscolaTextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(405, 185);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados da Escola";
			// 
			// incluirEscolaButton
			// 
			this.incluirEscolaButton.Location = new System.Drawing.Point(142, 145);
			this.incluirEscolaButton.Name = "incluirEscolaButton";
			this.incluirEscolaButton.Size = new System.Drawing.Size(122, 23);
			this.incluirEscolaButton.TabIndex = 6;
			this.incluirEscolaButton.Text = "Incluir Escola";
			this.incluirEscolaButton.UseVisualStyleBackColor = true;
			this.incluirEscolaButton.Click += new System.EventHandler(this.incluirEscolaButton_Click);
			// 
			// telefoneEscolaTextBox
			// 
			this.telefoneEscolaTextBox.Location = new System.Drawing.Point(70, 104);
			this.telefoneEscolaTextBox.Name = "telefoneEscolaTextBox";
			this.telefoneEscolaTextBox.Size = new System.Drawing.Size(299, 20);
			this.telefoneEscolaTextBox.TabIndex = 5;
			// 
			// enderecoEscolaTextBox
			// 
			this.enderecoEscolaTextBox.Location = new System.Drawing.Point(70, 70);
			this.enderecoEscolaTextBox.Name = "enderecoEscolaTextBox";
			this.enderecoEscolaTextBox.Size = new System.Drawing.Size(299, 20);
			this.enderecoEscolaTextBox.TabIndex = 4;
			// 
			// descricaoEscolaTextBox
			// 
			this.descricaoEscolaTextBox.Location = new System.Drawing.Point(70, 33);
			this.descricaoEscolaTextBox.Name = "descricaoEscolaTextBox";
			this.descricaoEscolaTextBox.Size = new System.Drawing.Size(299, 20);
			this.descricaoEscolaTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Telefone:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Endereço:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Descrição:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buscarCodigoButton);
			this.groupBox2.Controls.Add(this.cursosDataGridView);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.codigoCursoTextBox);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.incluirCursoButton);
			this.groupBox2.Controls.Add(this.precoTextBox);
			this.groupBox2.Controls.Add(this.cargahorariaCursoTextBox);
			this.groupBox2.Controls.Add(this.descricaoCursoTextBox);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.buscarEscolaButton);
			this.groupBox2.Controls.Add(this.escolaComboBox);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(423, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(375, 382);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dados do Curso";
			// 
			// incluirCursoButton
			// 
			this.incluirCursoButton.Location = new System.Drawing.Point(212, 190);
			this.incluirCursoButton.Name = "incluirCursoButton";
			this.incluirCursoButton.Size = new System.Drawing.Size(122, 20);
			this.incluirCursoButton.TabIndex = 9;
			this.incluirCursoButton.Text = "Incluir Curso";
			this.incluirCursoButton.UseVisualStyleBackColor = true;
			this.incluirCursoButton.Click += new System.EventHandler(this.incluirCursoButton_Click);
			// 
			// precoTextBox
			// 
			this.precoTextBox.Location = new System.Drawing.Point(95, 190);
			this.precoTextBox.Name = "precoTextBox";
			this.precoTextBox.Size = new System.Drawing.Size(66, 20);
			this.precoTextBox.TabIndex = 8;
			// 
			// cargahorariaCursoTextBox
			// 
			this.cargahorariaCursoTextBox.Location = new System.Drawing.Point(95, 164);
			this.cargahorariaCursoTextBox.Name = "cargahorariaCursoTextBox";
			this.cargahorariaCursoTextBox.Size = new System.Drawing.Size(271, 20);
			this.cargahorariaCursoTextBox.TabIndex = 7;
			// 
			// descricaoCursoTextBox
			// 
			this.descricaoCursoTextBox.Location = new System.Drawing.Point(95, 135);
			this.descricaoCursoTextBox.Name = "descricaoCursoTextBox";
			this.descricaoCursoTextBox.Size = new System.Drawing.Size(271, 20);
			this.descricaoCursoTextBox.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(49, 193);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Preço:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Carga Horária:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Descrição:";
			// 
			// buscarEscolaButton
			// 
			this.buscarEscolaButton.Location = new System.Drawing.Point(276, 30);
			this.buscarEscolaButton.Name = "buscarEscolaButton";
			this.buscarEscolaButton.Size = new System.Drawing.Size(75, 23);
			this.buscarEscolaButton.TabIndex = 2;
			this.buscarEscolaButton.Text = "Buscar";
			this.buscarEscolaButton.UseVisualStyleBackColor = true;
			this.buscarEscolaButton.Click += new System.EventHandler(this.buscarEscolaButton_Click);
			// 
			// escolaComboBox
			// 
			this.escolaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.escolaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.escolaComboBox.FormattingEnabled = true;
			this.escolaComboBox.Location = new System.Drawing.Point(63, 33);
			this.escolaComboBox.Name = "escolaComboBox";
			this.escolaComboBox.Size = new System.Drawing.Size(206, 21);
			this.escolaComboBox.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Escola:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(44, 107);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Código:";
			// 
			// codigoCursoTextBox
			// 
			this.codigoCursoTextBox.Location = new System.Drawing.Point(95, 104);
			this.codigoCursoTextBox.Name = "codigoCursoTextBox";
			this.codigoCursoTextBox.Size = new System.Drawing.Size(100, 20);
			this.codigoCursoTextBox.TabIndex = 11;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(90, 65);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(178, 25);
			this.label9.TabIndex = 12;
			this.label9.Text = "Inclusão De Cursos";
			// 
			// cursosDataGridView
			// 
			this.cursosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cursosDataGridView.Location = new System.Drawing.Point(6, 232);
			this.cursosDataGridView.Name = "cursosDataGridView";
			this.cursosDataGridView.Size = new System.Drawing.Size(360, 144);
			this.cursosDataGridView.TabIndex = 13;
			// 
			// buscarCodigoButton
			// 
			this.buscarCodigoButton.Location = new System.Drawing.Point(212, 104);
			this.buscarCodigoButton.Name = "buscarCodigoButton";
			this.buscarCodigoButton.Size = new System.Drawing.Size(102, 23);
			this.buscarCodigoButton.TabIndex = 14;
			this.buscarCodigoButton.Text = "Buscar Codigo";
			this.buscarCodigoButton.UseVisualStyleBackColor = true;
			this.buscarCodigoButton.Click += new System.EventHandler(this.buscarCodigoButton_Click);
			// 
			// formCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(806, 394);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "formCadastro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inclusão e Busca de Cadastros";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cursosDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button incluirEscolaButton;
		private System.Windows.Forms.TextBox telefoneEscolaTextBox;
		private System.Windows.Forms.TextBox enderecoEscolaTextBox;
		private System.Windows.Forms.TextBox descricaoEscolaTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button incluirCursoButton;
		private System.Windows.Forms.TextBox precoTextBox;
		private System.Windows.Forms.TextBox cargahorariaCursoTextBox;
		private System.Windows.Forms.TextBox descricaoCursoTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buscarEscolaButton;
		private System.Windows.Forms.ComboBox escolaComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox codigoCursoTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView cursosDataGridView;
		private System.Windows.Forms.Button buscarCodigoButton;
	}
}

