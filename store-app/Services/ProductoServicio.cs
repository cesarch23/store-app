using store_app.Database;
using store_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_app.Services
{
    public static class ProductoServicio

    {

        public static Producto Obtener(int id)
        {
            using (StoreContext context = new StoreContext()) {
                return context.Productos.Where(u => u.Id == id).FirstOrDefault();
            }
            
        }
        public static List<Producto> Listar() {
            using (StoreContext context = new())
            {
                List<Producto> list = context.Productos.ToList();
                return list;
            }
        }
        public static void Crear(Producto producto) {
            using(StoreContext context = new())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }
        }
        public static bool Modificar(Producto producto) {
            using (StoreContext ctx = new StoreContext()) {
                if (Obtener(producto.Id) is not null)
                {
                    ctx.Update(producto);
                    ctx.SaveChanges();
                    return true;
                }
                else return false;
            }
        }
        public static bool Eliminar(int id) {
            using (StoreContext context = new StoreContext())
            {
                Producto p = Obtener(id);
                if (p is not null)
                {
                    context.Remove(p);
                    context.SaveChanges();
                    return true;
                }
                else return false;
            }
        }

    }
}
