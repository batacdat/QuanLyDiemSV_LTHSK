using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyDiemSinhVien
{
    public class KetNoiCSDL
    {
        SqlConnection sqlCon;   //doi tuong ket noi
        SqlDataAdapter sqlDataAdapter;  //bo dieu huong du lieu

        DataSet ds;  // doi tuong  chua csdl khi giao tiep

        public KetNoiCSDL()
        {
            string strCon = @"Data Source=MUINV\NVM;Initial Catalog=BTL_QuanLyDiemSinhVien;Integrated Security=True";
            sqlCon = new SqlConnection(strCon);

        }
        // phuong thuc de thuc hien cau lenh truy van
        public DataTable Execute(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                // Tạo một đối tượng SqlDataAdapter
                sqlDataAdapter = new SqlDataAdapter(query, sqlCon);

                // Thêm các tham số vào câu lệnh SQL (nếu có)
                if (parameters != null)
                {
                    sqlDataAdapter.SelectCommand = new SqlCommand(query, sqlCon);
                    foreach (var param in parameters)
                    {
                        sqlDataAdapter.SelectCommand.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                // Điền dữ liệu vào DataSet
                ds = new DataSet();
                sqlDataAdapter.Fill(ds);

                // Trả về DataTable đầu tiên trong DataSet
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ví dụ: ghi log, hiển thị thông báo lỗi)
                throw new Exception("Lỗi khi thực hiện câu lệnh SQL: " + ex.Message);
            }
        }

        // Phương thức để thực hiện các lệnh Thêm, Xóa, Sửa với parameterized query
        public void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=MUINV\NVM;Initial Catalog=BTL_QuanLyDiemSinhVien;Integrated Security=True")) // Thay connectionString bằng chuỗi kết nối của bạn
                {
                    sqlCon.Open(); // Mở kết nối

                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        cmd.ExecuteNonQuery(); // Thực hiện lệnh Thêm/Xóa/Sửa
                    }
                } // Kết nối sẽ tự động đóng khi ra khỏi khối using
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ví dụ: ghi log, hiển thị thông báo lỗi)
                throw new Exception("Lỗi khi thực hiện câu lệnh SQL: " + ex.Message);
            }
        }


        // Phương thức ExecuteScalar dùng trong frmDoiMatKhau
        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=MUINV\NVM;Initial Catalog=BTL_QuanLyDiemSinhVien;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm các tham số vào câu lệnh SQL (nếu có)
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    // Thực thi truy vấn và trả về giá trị đầu tiên của kết quả
                    return cmd.ExecuteScalar();
                }
            }
        }
















        // Phương thức để lấy đối tượng SqlConnection
        public SqlConnection GetConnection()
        {
            return sqlCon;
        }
    }
}
