﻿using store_app.Database;
using store_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_app.Services
{
    public static class VentaService
    {

        public static Venta Obtener(int id) {
            using (StoreContext context = new())
            {
                return context.Venta.Find(id);
            }
        }
        public static List<Venta> Listar() {
            using (StoreContext context = new())
            {
                return context.Venta.ToList();
            }
        }
        public static void Crear(Venta venta) {
            using (StoreContext context = new())
            {
                context.Venta.Add(venta);
                context.SaveChanges();
            }
        }
        public static bool Modificar(Venta v)
        {
            using (StoreContext ctx = new())
            {
                if (Obtener(v.Id) is not null)
                {
                    ctx.Venta.Update(v);
                    ctx.SaveChanges();
                    return true;
                }
                else return false;
            }
        }
        public static bool Delete(int id) {
            using (StoreContext ctx = new())
            {
                Venta v = Obtener(id);
                if (v is not null)
                {
                    ctx.Venta.Remove(v);
                    ctx.SaveChanges();
                    return true;
                }
                else return false;
            }
        }   
 
    }
}
