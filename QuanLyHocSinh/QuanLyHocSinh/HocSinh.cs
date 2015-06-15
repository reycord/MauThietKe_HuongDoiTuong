using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    class HocSinh : Table
    {
        public void Load(Control GirdView)
        {
            ServerView.Load(GirdView,"HocSinh");
        }
    }
}
