using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Restaurant_Management
{
    class database
    {
        // Thông tin cần thiết để kết nối cơ sở dữ liệu
        private static string host = "127.0.0.1";
        private static string user_id = "root";
        private static string password = "root";
        private static string db_name = "Restaurant_Management";

        // Dối tượng database
        public MySqlConnection con;

        // Thuộc tính dùng để kiểm tra trạng thái kết nối đến database
        public bool status_connection = false;

        // Thuộc tính để lưu trữ lại lỗi khi gặp 
        public MySqlException err_database;

        public database()
        {
            // Tạo một đối tượng MySqlConnection để thao tác với Database
            string connection_string = string.Format("SERVER={0};UID={1};PASSWORD={2};DATABASE={3}", host, user_id, password, db_name);
            con = new MySqlConnection(connection_string);
        }

        public void Open()
        {
            try
            {
                // Kết nối tới cơ sở dữ liệu và cập nhật trạng thái kết nối
                con.Open();
                err_database = null;
                status_connection = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Cập nhật lại trang thái kết nối và trả về lỗi
                status_connection = false;
                err_database = ex;
            }
        }

        public void Close()
        {
            try
            {
                // Đóng kết nối tới cơ sở dữ liệu và cập nhật trạng thái kết nối
                con.Close();
                err_database = null;
                status_connection = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Cập nhật lại trạng thái kết nối và trả về lỗi
                status_connection = true;
                err_database = ex;
            }
        }
    }
}
