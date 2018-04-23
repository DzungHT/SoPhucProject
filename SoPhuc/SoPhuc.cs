using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoPhuc
{
    public class SoPhuc
    {
        /// <summary>
        /// Phần thực
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// Phần ảo
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Viết lại hàm mặc định để chuyển Số phức về dạng chuỗi
        /// </summary>
        /// <returns>a + bi</returns>
        public override string ToString()
        {
            return string.Format("{0} + {1}i", A, B);
        }

        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        public SoPhuc()
        {
            A = 0;
            B = 0;
        }

        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        /// <param name="a">Giá trị phần thực</param>
        /// <param name="b">Giá trị phần ảo</param>
        public SoPhuc(double a, double b)
        {
            A = a;
            B = b;
        }

        /// <summary>
        /// Cộng 2 số phức
        /// </summary>
        /// <param name="soPhuc">Số phức cần cộng</param>
        /// <returns>Kết quả tổng của số phức hiện tại và số phức truyền vào.</returns>
        public SoPhuc Cong(SoPhuc soPhuc)
        {
            SoPhuc ketQua = new SoPhuc();

            ketQua.A = this.A + soPhuc.A;
            ketQua.B = this.B + soPhuc.B;

            return ketQua;
        }



    }
}
