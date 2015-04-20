using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LCL.Tools
{
    public partial class ConnectionString : Form
    {
        public ConnectionString( )
        {
            InitializeComponent();
            this.comboBoxDBType.SelectedIndex = 2;
        }
        bool errFlag = true;
        private void saveUtils( )
        {
            Utils.NameSpace = txtEntityNameSpace.Text;
            Utils.TargetFolder = txtTargetFolder.Text;
            Utils.Author = txtAuthor.Text;
            Utils.DataBaseType = (DataBaseType)Enum.Parse(typeof(DataBaseType), comboBoxDBType.Text, true);
        }
        private void btn_DbOK_Click(object sender, EventArgs e)
        {
            if (!errFlag) MessageBox.Show("������������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            string str = this.comboBoxServer.Text.Trim();
            string str2 = this.txtUser.Text.Trim();
            string str3 = this.txtPass.Text.Trim();
            #region �ַ���
            Utils.User = str2;
            Utils.Pwd = str3;
            Utils.Sqlserver = str;
            #endregion
            SqlConnection connection = new SqlConnection(Utils.ConnStr);
            try
            {
                connection.Open();
                saveUtils();
                connection.Close();
                btn_DbOK.Enabled = true;
                MessageBox.Show(this, "���ݿ����óɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "���ӷ�����ʧ�ܣ������������ַ���û��������Ƿ���ȷ��" + ex.Message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            finally
            {
                connection.Close();
            }
        }
        //ʵ����һ��ErrorProvider
        ErrorProvider errorUser = new ErrorProvider();
        private void txtUser_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || txtUser.Text.Length == 0)
            {
                errorUser.SetError(txtUser, "���ݿ��½���Ʋ���Ϊ��!");
                errFlag = false;
            }
            else
            {
                errorUser.SetError(txtUser, "");
                errFlag = true;
            }
        }

        private void txtEntityNameSpace_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEntityNameSpace.Text) || txtEntityNameSpace.Text.Length == 0)
            {
                errorUser.SetError(txtEntityNameSpace, "�����ռ䲻��Ϊ��!");
                errFlag = false;
            }
            else
            {
                errorUser.SetError(txtEntityNameSpace, "");
                errFlag = true;
            }
        }
    }
}