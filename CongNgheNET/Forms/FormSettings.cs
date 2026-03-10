using LibraryManagement.Data;

namespace LibraryManagement.Forms
{
    public partial class FormSettings : Form
    {
        private SystemSettingDAO settingDAO = new SystemSettingDAO();

        public FormSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
        }
    }
}
