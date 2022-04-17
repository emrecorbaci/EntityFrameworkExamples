using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;



namespace EntityFrameworkCodeFirst.ADODotNetEntityDataModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1 model1 = new Model1();  
        private void button1_Click(object sender, EventArgs e)
        {
            //var data = model1.Categories.ToList();
            //var data = model1.Categories.Select(x => new { Kategori = x.CategoryName }).ToList();//anonymus isimlendirme

            //var data = model1.Products.SelectMany(x => model1.Categories.Where(y => y.CategoryId == x.Category_CategoryId), (x, y) => new { UrunAd = x.ProductName, Kategori = y.CategoryName } ).ToList();//join

            //var data = model1.Products.OrderBy(x => x.Category_CategoryId).GroupBy(y => y.Category_CategoryId).Select(z => new { KategoriId = z.Key, UrunSayisi = z.Count() }).ToList(); //group by

            //var data = model1.Products.SelectMany(x => model1.Categories.Where(y => y.CategoryId == x.Category_CategoryId), (x, y) => new { UrunAd = x.ProductName, Kategori = y.CategoryName }).OrderBy(x => x.Kategori).GroupBy(x => x.Kategori).Select(x => new {Kategori = x.Key, UrunSayisi = x.Count() }).OrderByDescending(x => x.UrunSayisi).ToList();//join ve group by order by

            //var data = model1.Products.Count(x=>x.ProductId>1).ToString(); //count da where kullanimi

           

            //var data = (from x in model1.Products 
            //            orderby x.ProductName descending 
            //            select new { Id = x.ProductId, Name = x.ProductName }).ToList(); //linq

           // dgwList.DataSource = data;
        }
    }
}
