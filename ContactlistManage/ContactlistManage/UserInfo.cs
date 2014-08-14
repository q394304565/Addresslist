using System.Windows.Forms;

namespace ContactlistManage
{
    public partial class UserInfo : UserControl
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        public TextBox TxtName
        {
            get { return txtName; }
        }

        public TextBox TxtAddress
        {
            get { return txtAddress; }
        }

        public TextBox TxtEmail
        {
            get { return txtEmail; }
        }

        public ComboBox CbSex
        {
            get { return cbSex; }
        }

        public MaskedTextBox TxtTelephone
        {
            get { return txtTelephone; }
        }

        public MaskedTextBox TxtCallPhone
        {
            get { return txtCallPhone; }
        }

        public DateTimePicker DtBirthday
        {
            get { return dtBirthday; }
        }

        public PictureBox PbFavicon
        {
            get { return pbFavicon; }
        }
    }
}
