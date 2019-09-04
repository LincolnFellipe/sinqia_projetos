﻿namespace Projeto01_CadastroEventos
{
	partial class FormCadastro
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
			this.incluireventoButton = new System.Windows.Forms.Button();
			this.dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.precoTextBox = new System.Windows.Forms.TextBox();
			this.responsavelTextBox = new System.Windows.Forms.TextBox();
			this.descricaoTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.incluirConvidadoButton = new System.Windows.Forms.Button();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.telefoneTextBox = new System.Windows.Forms.TextBox();
			this.nomeTextBox = new System.Windows.Forms.TextBox();
			this.cpfTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.eventoComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buscarConvidadosButton = new System.Windows.Forms.Button();
			this.convidadosdataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosdataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.incluireventoButton);
			this.groupBox1.Controls.Add(this.dataMaskedTextBox);
			this.groupBox1.Controls.Add(this.precoTextBox);
			this.groupBox1.Controls.Add(this.responsavelTextBox);
			this.groupBox1.Controls.Add(this.descricaoTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(347, 362);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados Do Evento";
			// 
			// incluireventoButton
			// 
			this.incluireventoButton.Location = new System.Drawing.Point(84, 219);
			this.incluireventoButton.Name = "incluireventoButton";
			this.incluireventoButton.Size = new System.Drawing.Size(121, 23);
			this.incluireventoButton.TabIndex = 8;
			this.incluireventoButton.Text = "Incluir Evento";
			this.incluireventoButton.UseVisualStyleBackColor = true;
			this.incluireventoButton.Click += new System.EventHandler(this.incluireventoButton_Click);
			// 
			// dataMaskedTextBox
			// 
			this.dataMaskedTextBox.Location = new System.Drawing.Point(84, 119);
			this.dataMaskedTextBox.Mask = "00/00/0000";
			this.dataMaskedTextBox.Name = "dataMaskedTextBox";
			this.dataMaskedTextBox.Size = new System.Drawing.Size(70, 20);
			this.dataMaskedTextBox.TabIndex = 6;
			// 
			// precoTextBox
			// 
			this.precoTextBox.Location = new System.Drawing.Point(84, 158);
			this.precoTextBox.Name = "precoTextBox";
			this.precoTextBox.Size = new System.Drawing.Size(100, 20);
			this.precoTextBox.TabIndex = 7;
			// 
			// responsavelTextBox
			// 
			this.responsavelTextBox.Location = new System.Drawing.Point(84, 83);
			this.responsavelTextBox.Name = "responsavelTextBox";
			this.responsavelTextBox.Size = new System.Drawing.Size(238, 20);
			this.responsavelTextBox.TabIndex = 5;
			// 
			// descricaoTextBox
			// 
			this.descricaoTextBox.Location = new System.Drawing.Point(84, 42);
			this.descricaoTextBox.Name = "descricaoTextBox";
			this.descricaoTextBox.Size = new System.Drawing.Size(238, 20);
			this.descricaoTextBox.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Preço:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(45, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Data:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Responsável:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Descrição:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.convidadosdataGridView);
			this.groupBox2.Controls.Add(this.buscarConvidadosButton);
			this.groupBox2.Controls.Add(this.incluirConvidadoButton);
			this.groupBox2.Controls.Add(this.emailTextBox);
			this.groupBox2.Controls.Add(this.telefoneTextBox);
			this.groupBox2.Controls.Add(this.nomeTextBox);
			this.groupBox2.Controls.Add(this.cpfTextBox);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.eventoComboBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(428, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(367, 362);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dados do Convidado";
			// 
			// incluirConvidadoButton
			// 
			this.incluirConvidadoButton.Location = new System.Drawing.Point(111, 188);
			this.incluirConvidadoButton.Name = "incluirConvidadoButton";
			this.incluirConvidadoButton.Size = new System.Drawing.Size(145, 23);
			this.incluirConvidadoButton.TabIndex = 10;
			this.incluirConvidadoButton.Text = "Incluir Convidado";
			this.incluirConvidadoButton.UseVisualStyleBackColor = true;
			this.incluirConvidadoButton.Click += new System.EventHandler(this.incluirConvidadoButton_Click);
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(79, 162);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(215, 20);
			this.emailTextBox.TabIndex = 9;
			// 
			// telefoneTextBox
			// 
			this.telefoneTextBox.Location = new System.Drawing.Point(79, 136);
			this.telefoneTextBox.Name = "telefoneTextBox";
			this.telefoneTextBox.Size = new System.Drawing.Size(128, 20);
			this.telefoneTextBox.TabIndex = 8;
			// 
			// nomeTextBox
			// 
			this.nomeTextBox.Location = new System.Drawing.Point(79, 106);
			this.nomeTextBox.Name = "nomeTextBox";
			this.nomeTextBox.Size = new System.Drawing.Size(215, 20);
			this.nomeTextBox.TabIndex = 7;
			// 
			// cpfTextBox
			// 
			this.cpfTextBox.Location = new System.Drawing.Point(79, 76);
			this.cpfTextBox.Name = "cpfTextBox";
			this.cpfTextBox.Size = new System.Drawing.Size(128, 20);
			this.cpfTextBox.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(38, 165);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = "Email:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(29, 139);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Telefone:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(35, 109);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Nome:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(35, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Cpf:";
			// 
			// eventoComboBox
			// 
			this.eventoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.eventoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.eventoComboBox.FormattingEnabled = true;
			this.eventoComboBox.Location = new System.Drawing.Point(79, 41);
			this.eventoComboBox.Name = "eventoComboBox";
			this.eventoComboBox.Size = new System.Drawing.Size(138, 21);
			this.eventoComboBox.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Evento:";
			// 
			// buscarConvidadosButton
			// 
			this.buscarConvidadosButton.Location = new System.Drawing.Point(223, 40);
			this.buscarConvidadosButton.Name = "buscarConvidadosButton";
			this.buscarConvidadosButton.Size = new System.Drawing.Size(138, 23);
			this.buscarConvidadosButton.TabIndex = 11;
			this.buscarConvidadosButton.Text = "Buscar";
			this.buscarConvidadosButton.UseVisualStyleBackColor = true;
			this.buscarConvidadosButton.Click += new System.EventHandler(this.buscarConvidadosButton_Click);
			// 
			// convidadosdataGridView
			// 
			this.convidadosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.convidadosdataGridView.Location = new System.Drawing.Point(7, 231);
			this.convidadosdataGridView.Name = "convidadosdataGridView";
			this.convidadosdataGridView.Size = new System.Drawing.Size(354, 125);
			this.convidadosdataGridView.TabIndex = 12;
			// 
			// FormCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 386);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormCadastro";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosdataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button incluireventoButton;
		private System.Windows.Forms.MaskedTextBox dataMaskedTextBox;
		private System.Windows.Forms.TextBox precoTextBox;
		private System.Windows.Forms.TextBox responsavelTextBox;
		private System.Windows.Forms.TextBox descricaoTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox eventoComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button incluirConvidadoButton;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox telefoneTextBox;
		private System.Windows.Forms.TextBox nomeTextBox;
		private System.Windows.Forms.TextBox cpfTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView convidadosdataGridView;
		private System.Windows.Forms.Button buscarConvidadosButton;
	}
}

