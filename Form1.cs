namespace AES
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtToEnCrypt.Text))
			{
				txtEncryptR.Text =
				PinTechLib.AES.AESEncrypt(txtToEnCrypt.Text);
			}

			if (!string.IsNullOrEmpty(txtToDeCrypt.Text))
			{
				txtDecryptR.Text =
				PinTechLib.AES.AESDecrypt(txtToDeCrypt.Text);
			}
		}
	}
}