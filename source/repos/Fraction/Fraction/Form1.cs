using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // onClick là tên đặt của click của button thực hiện nhé <3
        private void onClick(object sender, EventArgs e)
        {
            // xét nếu đẻ rỗng thì k đc chạy
            if (cb1.Text == "" || txtA.Text == "" || txtB.Text == ""
                               || txtC.Text == "" || txtD.Text == "")
                MessageBox.Show("nhap thieu");
            else
            {
                // khởi tạo đối tượng của class phan số
                PhanSo phanSo = new PhanSo();

                // chuyển các thứ mình nhập trong a,b,c,d về số

                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);
                int d = int.Parse(txtD.Text);

                String s =  "";
                String s1 = "";

                // cb1 là name của combox để chon là công trừ , nhân hay chia
                // sau đó chuyển nó sang chuồi dùng toString

                if (cb1.SelectedItem.ToString() == "Cộng")
                {
                    s = phanSo.Cong(a, b, c, d);
                    s1 = "+";
                    // s1 là dấu của biểu thức, khi chọn cộng thì  gán nó thành + 
                }
                else
                    if (cb1.SelectedItem.ToString() == "Trừ")
                {
                    s = phanSo.Tru(a, b, c, d);
                    s1 = "-";
                }
                else
                    if (cb1.SelectedItem.ToString() == "Nhân")
                {
                    s = phanSo.Nhan(a, b, c, d);
                    s1 = "*";
                }
                else
                {
                    // chỉ còn lại là chia thôi :v
                    s = phanSo.Chia(a, b, c, d);
                    s1 = "/";
                }
                // khi hiện là 1/2 + 1/3 = 5/6
                // nên nó có dạng ở dưới
                // s1 là dấu nhé, khi mình chọn cộng là dấu cộng, trừ nó sẽ thành dấu trừ,,...

                lb1.Items.Add(a + "/" + b + " " + s1 + " " + c + "/" + d +"  =  " + s);
            }

        }
    }
}
