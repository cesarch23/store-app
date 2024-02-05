using store_app.Models;
using store_app.Services;

namespace store_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dgv.DataSource = null;
            //dgv.AutoGenerateColumns = true;
            //ProductoVendido p = new ProductoVendido();
            //p.Id = 5    ;
            //p.IdProducto = 5;
            //p.Stock = 55;
            //p.IdVenta = 1;
            //si no se especifica el id al modificar inserta un nuevo elemento

            //bool b = ProductoVendidoService.Eliminar(5);
        }
    }
}