namespace AES
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
            try
            {
                if (!string.IsNullOrEmpty(txtToEnCrypt.Text))
                {
                    txtEncryptR.Text = WanLib.AES.AESEncrypt(txtToEnCrypt.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�[�K�L�{���o�Ϳ��~�G{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (!string.IsNullOrEmpty(txtToDeCrypt.Text))
                {
                    txtDecryptR.Text = WanLib.AES.AESDecrypt(txtToDeCrypt.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�ѱK�L�{���o�Ϳ��~�G{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}