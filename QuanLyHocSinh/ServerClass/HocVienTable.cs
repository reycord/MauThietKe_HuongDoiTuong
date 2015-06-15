using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerClass
{
    public class HocVienTable : Table
    {
        private HocVien hocvien;

        public HocVienTable()
        {
            TableName = "HocVien";
        }
        public void Load(Control GridView)
        {
            ServerView.View.LoadTable(GridView, this.TableName);
        }

        //Làm tiếp đê
    }
}
