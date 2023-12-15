using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Restaurant_Management
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        database db = new database();
        CommandDatabase cmd = new CommandDatabase();
        string user_id = "";

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

        // Xử lí đăng nhập cho quản lí
        private bool loginManager(string username, string password)
        {
            try
            {
                // Lấy manager có username và password nhập từ form
                string query = string.Format(CommandDatabase.queryManagerLogin, username, password);
                MySqlCommand command = new MySqlCommand(query, db.con);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();

                if (reader == null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    usernameTbox.Text = "";
                    passwordTbox.Text = "";
                    return false;
                }

                // Lưu lại username để chuyển cho form tiếp theo
                user_id = reader["username"].ToString();

                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private bool loginStaff(string username, string password)
        {
            try
            {
                // Lấy staff có username và password nhập từ form
                string query = string.Format(CommandDatabase.queryStaffLogin, username, password);
                MySqlCommand command = new MySqlCommand(query, db.con);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();

                if (reader == null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    usernameTbox.Text = "";
                    passwordTbox.Text = "";
                    return false;
                }

                // Lưu lại username để chuyển cho form tiếp theo
                user_id = reader["username"].ToString();
                reader.Close();


                // Lấy ca làm việc của nhân viên
                query = string.Format(CommandDatabase.queryShiftStaff, username);
                MySqlCommand command1 = new MySqlCommand(query, db.con);
                MySqlDataReader reader1 = command1.ExecuteReader();
                reader1.Read();


                if(reader1 == null)
                {
                    MessageBox.Show("Lỗi hệ thống!");
                    return false;
                }

                // Kiểm tra hiện tại có phải là ca làm việc của nhân viên hay không
                DateTime now = DateTime.Now;
                DayOfWeek day = now.DayOfWeek;

                int number = reader1.GetInt32(day.ToString());
                int start, end;
                if(number == 1)
                {
                    start = 7;
                    end = 12;
                } else if(number == 2)
                {
                    start = 12;
                    end = 17;
                } else
                {
                    start = 17;
                    end = 22;
                }

                if(now.Hour <= start || now.Hour > end)
                {
                    MessageBox.Show("Chưa tới ca làm việc của bạn! Vui lòng chú ý ca làm việc của mình!");
                    usernameTbox.Text = "";
                    passwordTbox.Text = "";
                    return false;
                }
                reader1.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTbox.Text;
            string password = passwordTbox.Text;

            // Kiểm tra username và password có để trống không
            if(username == "" || password == "")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu để trống");
                return;
            }

            bool result_login;
            if(managerOpt.Checked)
            {
                result_login = loginManager(username, password);
                if (result_login)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Manager_Form manager = new Manager_Form();
                    manager.Show(this);
                }
            } else
            {
                result_login = loginStaff(username, password);
                if (result_login)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Staff_Form staff = new Staff_Form();
                    staff.Show(this);
                }
            }
        }
    }
}
