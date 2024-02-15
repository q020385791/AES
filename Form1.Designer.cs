namespace AES
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
			btnConvert = new Button();
			labtoEncrypt = new Label();
			label2 = new Label();
			txtToEnCrypt = new TextBox();
			txtEncryptR = new TextBox();
			label1 = new Label();
			label3 = new Label();
			txtToDeCrypt = new TextBox();
			txtDecryptR = new TextBox();
			SuspendLayout();
			// 
			// btnConvert
			// 
			btnConvert.Location = new Point(33, 263);
			btnConvert.Name = "btnConvert";
			btnConvert.Size = new Size(75, 23);
			btnConvert.TabIndex = 0;
			btnConvert.Text = "轉換";
			btnConvert.UseVisualStyleBackColor = true;
			btnConvert.Click += btnConvert_Click;
			// 
			// labtoEncrypt
			// 
			labtoEncrypt.AutoSize = true;
			labtoEncrypt.Location = new Point(33, 21);
			labtoEncrypt.Name = "labtoEncrypt";
			labtoEncrypt.Size = new Size(79, 15);
			labtoEncrypt.TabIndex = 1;
			labtoEncrypt.Text = "要加密的字串";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(33, 65);
			label2.Name = "label2";
			label2.Size = new Size(55, 15);
			label2.TabIndex = 2;
			label2.Text = "加密結果";
			label2.Click += label2_Click;
			// 
			// txtToEnCrypt
			// 
			txtToEnCrypt.Location = new Point(36, 39);
			txtToEnCrypt.Name = "txtToEnCrypt";
			txtToEnCrypt.Size = new Size(504, 23);
			txtToEnCrypt.TabIndex = 3;
			// 
			// txtEncryptR
			// 
			txtEncryptR.Location = new Point(33, 83);
			txtEncryptR.Name = "txtEncryptR";
			txtEncryptR.Size = new Size(504, 23);
			txtEncryptR.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(33, 148);
			label1.Name = "label1";
			label1.Size = new Size(79, 15);
			label1.TabIndex = 1;
			label1.Text = "要解密的字串";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(33, 192);
			label3.Name = "label3";
			label3.Size = new Size(55, 15);
			label3.TabIndex = 2;
			label3.Text = "解密結果";
			label3.Click += label2_Click;
			// 
			// txtToDeCrypt
			// 
			txtToDeCrypt.Location = new Point(36, 166);
			txtToDeCrypt.Name = "txtToDeCrypt";
			txtToDeCrypt.Size = new Size(504, 23);
			txtToDeCrypt.TabIndex = 3;
			// 
			// txtDecryptR
			// 
			txtDecryptR.Location = new Point(33, 210);
			txtDecryptR.Name = "txtDecryptR";
			txtDecryptR.Size = new Size(504, 23);
			txtDecryptR.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(809, 298);
			Controls.Add(txtDecryptR);
			Controls.Add(txtToDeCrypt);
			Controls.Add(txtEncryptR);
			Controls.Add(label3);
			Controls.Add(txtToEnCrypt);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(labtoEncrypt);
			Controls.Add(btnConvert);
			Name = "Form1";
			Text = "AES";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnConvert;
		private Label labtoEncrypt;
		private Label label2;
		private TextBox txtToEnCrypt;
		private TextBox txtEncryptR;
		private Label label1;
		private Label label3;
		private TextBox txtToDeCrypt;
		private TextBox txtDecryptR;
	}
}