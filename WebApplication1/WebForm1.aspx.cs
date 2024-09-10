using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double a, b, h;
            string errorMessage = "";

            if (!double.TryParse(so_a.Text, out a) || a <= 0)
            {
                errorMessage += "Đáy lớn (a) phải là số dương. ";
            }
            if (!double.TryParse(so_b.Text, out b) || b <= 0)
            {
                errorMessage += "Đáy nhỏ (b) phải là số dương. ";
            }

            if (errorMessage != "")
            {
                lblResult.Text = "Lỗi: " + errorMessage;
            }
            else
            {
                double area = Class1.tich(a, b);
                lblResult.Text = $"Diện tích hình thang là: {area}";
            }
        }
    }
}