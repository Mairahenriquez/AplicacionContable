﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacionContable.Models;
using AplicacionContable.Entities;

namespace AplicacionContable.Controllers
{
    public class ProveedoresController : Controller
    {
        contexto db = new contexto();
        BitacorasController bt = new BitacorasController();
        // GET: Proveedores
        public ActionResult Index()
        {
            var _proveedores = db.vw_proveedores.ToList();
            return View(_proveedores);
        }

        public ActionResult Details(int id)
        {
            var _proveedor = db.vw_proveedores.Where(x => x.PK_codigo == id).FirstOrDefault();

            if (_proveedor != null)
            {
                return View(_proveedor);
            }
            else
            {
                return View("Error");
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(proveedores_Model value)
        {
            try
            {
                //Se valida que el modelo no sea nulo.
                if (value != null)
                {
                    //Se valida el DataAnnotation que sea valido.
                    if (ModelState.IsValid)
                    {
                        //Se asignan valores iniciales.
                        value.fecha_hora = DateTime.Now;
                        value.saldo = 0;
                        value.abonado = 0;
                        value.total = 0;
                        value.FK_tipo_contribuyente = 1;
                        value.FK_cuenta_contable = 1;

                        //Guarda el registro en la base de datos.
                        db.proveedores.Add(value);
                        db.SaveChanges();

                        //Guarda en bitacora.
                        var descripcion = $"Proveedor agregado: {value.PK_codigo} - {value.nombre_comercial}.";
                        var FK_usuario = 1;
                        bt.Create(descripcion, FK_usuario);

                        //Redirecciona a la vista Details.
                        return RedirectToAction("Details/" + value.PK_codigo);
                    }
                }
                //Actualiza la vista.
                return View();
            }
            catch (Exception e)
            {
                //Guarda en bitacora.
                var descripcion = $"ProveedoresController :: Create() :: {e.Message}.";
                bt.Create(descripcion, 1);

                //Actualiza la vista.
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var _proveedor = db.vw_proveedores.Where(x => x.PK_codigo == id).FirstOrDefault();
            return View(_proveedor);

        }
        [HttpPost]
        public ActionResult Edit(vw_proveedores_Model value)
        {
            try
            {
                //Se valida que el modelo no sea nulo.
                if (value != null)
                {
                    //Se valida el DataAnnotation que sea valido.
                    if (ModelState.IsValid)
                    {
                        //Se busca el registro.
                        var _proveedor = db.proveedores.Where(x => x.PK_codigo == value.PK_codigo).FirstOrDefault();

                        //Se igualan valores.
                        _proveedor.razon_social = value.razon_social;
                        _proveedor.nombre_comercial = value.nombre_comercial;
                        _proveedor.dui = value.dui;
                        _proveedor.nit = value.nit;
                        _proveedor.nrc = value.nrc;
                        _proveedor.telefono = value.telefono;
                        _proveedor.direccion = value.direccion;
                        _proveedor.FK_municipio = value.FK_municipio;

                        //Se actualiza el registro.
                        db.SaveChanges();

                        //Guarda en bitacora.
                        var descripcion = $"Proveedor actualizado: {value.PK_codigo} - {value.nombre_comercial}.";
                        var FK_usuario = 1;
                        bt.Create(descripcion, FK_usuario);

                        //Retorna hacia la pantalla de Detalle.
                        return RedirectToAction("Details/" + value.PK_codigo);
                    }
                }
                //Actualiza a vista.
                return View();
            }
            catch (Exception e)
            {
                //Guarda en bitacora.
                var descripcion = $"ProveedoresController :: Edit() :: {e.Message}.";
                bt.Create(descripcion, 1);

                //Actualiza la vista.
                return View();
            }
        }

    }
}