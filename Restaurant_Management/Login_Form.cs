using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        database db = new database();

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Tạo một kết nối đến cơ sở dữ liệu
            db.Open();

            // Kiểm tra kết nối có thất bại không
            if(!db.status_connection)
            {
                // Đưa ra thông báo lỗi khi không kết nối được tới cơ sở dữ liệu
                MessageBox.Show("Lỗi hệ thống! Không thể kết nối được tới database: " + db.err_database.Message);
                Application.Exit();
            }
        }
    }
}
