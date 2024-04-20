using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacionContable.Entities;
using AplicacionContable.Models;

namespace AplicacionContable.Controllers
{
    public class Select2Controller : Controller
    {
        contexto db = new contexto();
        // GET: Select2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectMunicipio(string terms)
        {
            try
            {
                List<vw_paises_municipios_Model> dato = new List<vw_paises_municipios_Model>();
                if (terms != null && terms != "")
                {
                    //Busqueda por texto de entrada.
                    dato = db.vw_paises_municipios.Where(m => m.nombre.Contains(terms)).OrderBy(y => y.nombre).Take(5).ToList();
                }
                else
                {
                    //Busqueda por texto de entrada.
                    dato = db.vw_paises_municipios.OrderBy(y => y.nombre).Take(5).ToList();
                }
                //Creación de objeto para para mostrar datos.
                var modificarData = dato.Select(x => new
                {
                    id = x.PK_codigo, x.nombre, text = $"{x.nombre}"
                });
                //Retorno de datos como json.
                return Json(modificarData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult SelectCuentaContable(string terms)
        {
            try
            {
                List<vw_contabilidad_cuentas_contables_Model> dato = new List<vw_contabilidad_cuentas_contables_Model>();
                if (terms != null)
                {
                    //Busqueda por texto de entrada.
                    dato = db.vw_contabilidad_cuentas_contables.Where(m => m.nombre.Contains(terms) || m.numero.Contains(terms)).OrderBy(y => y.nombre).Take(10).ToList();
                }
                else
                {
                    //Busqueda por texto de entrada.
                    dato = db.vw_contabilidad_cuentas_contables.OrderBy(y => y.nombre).Take(10).ToList();
                }
                //Creación de objeto para para mostrar datos.
                var modificarData = dato.Select(x => new
                {
                    id = x.PK_codigo,
                    x.nombre,
                    text = $"{x.numero} - {x.nombre}"
                });
                //Retorno de datos como json.
                return Json(modificarData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult SelectClasificacionCuentaContable(string terms)
        {
            try
            {
                List<contabilidad_cuentas_contables_clasificaciones_Model> dato = new List<contabilidad_cuentas_contables_clasificaciones_Model>();
                if (terms != null)
                {
                    //Busqueda por texto de entrada.
                    dato = db.contabilidad_cuentas_contables_clasificaciones.Where(m => m.nombre.Contains(terms) || m.identificador.Contains(terms)).OrderBy(y => y.nombre).Take(10).ToList();
                }
                else
                {
                    //Busqueda por texto de entrada.
                    dato = db.contabilidad_cuentas_contables_clasificaciones.OrderBy(y => y.nombre).Take(10).ToList();
                }
                //Creación de objeto para para mostrar datos.
                var modificarData = dato.Select(x => new
                {
                    id = x.PK_codigo,
                    x.nombre,
                    text = $"{x.identificador} - {x.nombre}"
                });
                //Retorno de datos como json.
                return Json(modificarData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
                
        public ActionResult SelectBodega(string terms)
        {
            try
            {
                List<bodegas_Model> dato = new List<bodegas_Model>();
                if (terms != null)
                {
                    //Busqueda por texto de entrada.
                    dato = db.bodegas.Where(m => m.nombre.Contains(terms) || m.descripcion.Contains(terms)).OrderBy(y => y.nombre).Take(10).ToList();
                }
                else
                {
                    //Busqueda por texto de entrada.
                    dato = db.bodegas.OrderBy(y => y.nombre).Take(10).ToList();
                }
                //Creación de objeto para para mostrar datos.
                var modificarData = dato.Select(x => new
                {
                    id = x.PK_codigo,
                    x.nombre,
                    text = $"{x.PK_codigo} - {x.nombre}"
                });
                //Retorno de datos como json.
                return Json(modificarData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult SelectProveedor(string terms)
        {
            try
            {
                List<proveedores_Model> dato = new List<proveedores_Model>();
                if (terms != null)
                {
                    //Busqueda por texto de entrada.
                    dato = db.proveedores.Where(m => m.nombre_comercial.Contains(terms) || m.razon_social.Contains(terms)).OrderBy(y => y.nombre_comercial).Take(10).ToList();
                }
                else
                {
                    //Busqueda por texto de entrada.
                    dato = db.proveedores.OrderBy(y => y.nombre_comercial).Take(10).ToList();
                }
                //Creación de objeto para para mostrar datos.
                var modificarData = dato.Select(x => new
                {
                    id = x.PK_codigo,
                    x.nombre_comercial,
                    text = $"{x.PK_codigo} - {x.nombre_comercial}"
                });
                //Retorno de datos como json.
                return Json(modificarData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult SelectFormaPago(string terms)
        {
            try
            {
                List<formas_pagos_Model> dato = new List<formas_pagos_Model>();
                if (terms != null)
                {
                    //Busqueda por texto de entrada.
                    dato = db.formas_pagos.Where(m => m.nombre.Contains(terms)).OrderBy(y => y.nombre).Take(10).ToList();
                }
                else
                {
                    //Busqueda por texto de entrada.
                    dato = db.formas_pagos.OrderBy(y => y.nombre).Take(10).ToList();
                }
                //Creación de objeto para para mostrar datos.
                var modificarData = dato.Select(x => new
                {
                    id = x.PK_codigo,
                    x.nombre,
                    text = $"{x.PK_codigo} - {x.nombre}"
                });
                //Retorno de datos como json.
                return Json(modificarData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult SelectCondicionPago(string terms)
        {
            try
            {
                List<condiciones_pagos_Model> dato = new List<condiciones_pagos_Model>();
                if (terms != null)
                {
                    //Busqueda por texto de entrada.
                    dato = db.condiciones_pagos.Where(m => m.nombre.Contains(terms)).OrderBy(y => y.nombre).Take(10).ToList();
                }
                else
                {
                    //Busqueda por texto de entrada.
                    dato = db.condiciones_pagos.OrderBy(y => y.nombre).Take(10).ToList();
                }
                //Creación de objeto para para mostrar datos.
                var modificarData = dato.Select(x => new
                {
                    id = x.PK_codigo,
                    x.nombre,
                    text = $"{x.PK_codigo} - {x.nombre}"
                });
                //Retorno de datos como json.
                return Json(modificarData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult SelectInventariosCompras(string terms)
        {
            try
            {
                List<vw_inventarios_Model> dato = new List<vw_inventarios_Model>();
                if (terms != null)
                {
                    //Busqueda por texto de entrada.
                    dato = db.vw_inventarios.Where(m => (m.identificador.Contains(terms) || m.descripcion.Contains(terms)) && m.comprable == true).OrderBy(y => y.PK_codigo).Take(10).ToList();
                }
                else
                {
                    //Busqueda por texto de entrada.
                    dato = db.vw_inventarios.Where(m => m.comprable == true).OrderBy(y => y.PK_codigo).Take(10).ToList();
                }
                //Creación de objeto para para mostrar datos.
                var modificarData = dato.Select(x => new
                {
                    id = x.PK_codigo,
                    x.descripcion,
                    text = $"{x.identificador} - {x.descripcion}"
                });
                //Retorno de datos como json.
                return Json(modificarData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult SelectInventariosVendible(string terms)
        {
            try
            {
                List<vw_inventarios_Model> dato = new List<vw_inventarios_Model>();
                if (terms != null)
                {
                    //Busqueda por texto de entrada.
                    dato = db.vw_inventarios.Where(m => (m.identificador.Contains(terms) || m.descripcion.Contains(terms)) && m.vendible == true && m.existencia_fisica > 0).OrderBy(y => y.PK_codigo).Take(10).ToList();
                }
                else
                {
                    //Busqueda por texto de entrada.
                    dato = db.vw_inventarios.Where(m => m.vendible == true).OrderBy(y => y.PK_codigo).Take(10).ToList();
                }
                //Creación de objeto para para mostrar datos.
                var modificarData = dato.Select(x => new
                {
                    id = x.PK_codigo,
                    x.descripcion,
                    text = $"{x.identificador} - {x.descripcion}"
                });
                //Retorno de datos como json.
                return Json(modificarData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult SelectClientes(string terms)
        {
            try
            {
                List<vw_clientes_Model> dato = new List<vw_clientes_Model>();
                if (terms != null)
                {
                    //Busqueda por texto de entrada.
                    dato = db.vw_clientes.Where(m => (m.nombre.Contains(terms) || m.nombre_comercial.Contains(terms)) && m.FK_estado == 1).OrderBy(y => y.PK_codigo).Take(10).ToList();
                }
                else
                {
                    //Busqueda por texto de entrada.
                    dato = db.vw_clientes.Where(m => m.FK_estado == 1).OrderBy(y => y.PK_codigo).Take(10).ToList();
                }
                //Creación de objeto para para mostrar datos.
                var modificarData = dato.Select(x => new
                {
                    id = x.PK_codigo,
                    x.nombre_comercial,
                    text = $"{x.PK_codigo} - {x.nombre_comercial}"
                });
                //Retorno de datos como json.
                return Json(modificarData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
    }
}