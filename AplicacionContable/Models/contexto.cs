using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AplicacionContable.Entities;

namespace AplicacionContable.Models
{
    public class contexto: DbContext  
    {
        public contexto() : base("Conexion")
        {

        }
        public DbSet<clientes_Model> clientes { get; set; }
        public DbSet<vw_clientes_Model> vw_clientes { get; set; }
        public DbSet<clientes_pedidos_Model> clientes_pedidos { get; set; }
        public DbSet<vw_clientes_pedidos_Model> vw_clientes_pedidos { get; set; }
        public DbSet<clientes_pedidos_detalle_Model> clientes_pedidos_detalle { get; set; }
        public DbSet<vw_clientes_pedidos_detalle_Model> vw_clientes_pedidos_detalle { get; set; }
        public DbSet<clientes_solicitudes_creditos_Model> clientes_solicitudes_creditos { get; set; }
        public DbSet<condiciones_pagos_Model> condiciones_pagos { get; set; }
        public DbSet<contabilidad_cuentas_contables_Model> contabilidad_cuentas_contables { get; set; }
        public DbSet<vw_contabilidad_cuentas_contables_Model> vw_contabilidad_cuentas_contables { get; set; }
        public DbSet<contabilidad_cuentas_contables_clasificaciones_Model> contabilidad_cuentas_contables_clasificaciones { get; set; }
        public DbSet<contabilidad_partidas_Model> contabilidad_partidas { get; set; }
        public DbSet<vw_contabilidad_partidas_Model> vw_contabilidad_partidas_Model { get; set; }
        public DbSet<contabilidad_partidas_detalle_Model> contabilidad_partidas_detalle { get; set; }
        public DbSet<vw_contabilidad_partidas_detalle_Model> vw_contabilidad_partidas_detalle { get; set; }
        public DbSet<facturacion_Model> facturacion { get; set; }
        public DbSet<vw_facturacion_Model> vw_facturacion { get; set; }
        public DbSet<facturacion_detalle_Model> facturacion_detalle { get; set; }
        public DbSet<vw_facturacion_detalle_Model> vw_facturacion_detalle { get; set; }
        public DbSet<formas_pagos_Model> formas_pagos { get; set; }
        public DbSet<inventarios_Model> inventarios { get; set; }
        public DbSet<vw_inventarios_Model> vw_inventarios { get; set; }
        public DbSet<inventarios_movimientos_Model> inventarios_movimientos { get; set; }
        public DbSet<vw_inventarios_movimientos_Model> vw_inventarios_movimientos { get; set; }
        public DbSet<inventarios_movimientos_detalle_Model> inventarios_movimientos_detalle { get; set; }
        public DbSet<proveedores_Model> proveedores { get; set; }
        public DbSet<vw_proveedores_Model> vw_proveedores { get; set; }
        public DbSet<proveedores_compras_Model> proveedores_compras { get; set; }
        public DbSet<vw_proveedores_compras_Model> vw_proveedores_compras { get; set; }
        public DbSet<proveedores_compras_detalle_Model> proveedores_compras_detalle { get; set; }
        public DbSet<proveedores_ordenes_compras_Model> proveedores_ordenes_compras { get; set; }
        public DbSet<vw_proveedores_ordenes_compras_Model> vw_proveedores_ordenes_compras { get; set; }
        public DbSet<proveedores_ordenes_compras_detalle_Model> proveedores_ordenes_compras_detalle { get; set; }
        public DbSet<vw_proveedores_compras_detalle_Model> vw_proveedores_compras_detalle { get; set; }
        public DbSet<vw_proveedores_ordenes_compras_detalle_Model> vw_proveedores_ordenes_compras_detalle { get; set; }
        public DbSet<usuarios_Model> usuarios { get; set; }
        public DbSet<usuarios_roles_Model> usuarios_roles { get; set; }
        public DbSet<bitacoras_Model> bitacoras { get; set; }
        public DbSet<vw_paises_municipios_Model> vw_paises_municipios { get; set; }
        public DbSet<bodegas_Model> bodegas { get; set; }
    }
}