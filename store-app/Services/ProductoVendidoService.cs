﻿using store_app.Database;
using store_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_app.Services
{
    public static class ProductoVendidoService
    {

        public static ProductoVendido Obtener(int id) {
            using (StoreContext context = new StoreContext())
            {
                return context.ProductoVendidos.Where(u => u.Id == id).FirstOrDefault();
            }
        }
        public static List<ProductoVendido> Listar() {
            using (StoreContext context = new()) {
                return context.ProductoVendidos.ToList();
            }
        }
        public static void Crear(ProductoVendido productoVendido) {
            using   (StoreContext context = new StoreContext())
            {
                context.ProductoVendidos.Add(productoVendido);
                context.SaveChanges();
            }
        }

        public static bool Modificar(ProductoVendido productoVendido) { 
           using(StoreContext context = new StoreContext())
            {
                if (productoVendido == null)return false;
                context.ProductoVendidos.Update(productoVendido);
                context.SaveChanges();
                return true;
            }
        }

        public static bool Eliminar(int id) { 
            using(StoreContext context = new())
            {

                if (Obtener(id) is not null)
                {
                    context.ProductoVendidos.Remove(Obtener(id));
                    context.SaveChanges();
                    return true;
                }
                else return false;
            }

        }
    }
}
