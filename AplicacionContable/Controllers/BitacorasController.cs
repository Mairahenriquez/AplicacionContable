﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacionContable.Entities;
using AplicacionContable.Models;

namespace AplicacionContable.Controllers
{
    public class BitacorasController : Controller
    {
        contexto db = new contexto();
        bitacoras_Model _bitacora = new bitacoras_Model();
        // GET: Bitacoras
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(string descripcion, int FK_usuario)
        {
            try
            {
                //Asignar valores.
                _bitacora.descripcion = (descripcion != null && descripcion != "") ? descripcion : "Descripcion";
                _bitacora.FK_usuario = FK_usuario;

                //Se valida que el modelo no sea nulo.
                if (_bitacora != null)
                {
                    //Se valida el DataAnnotation que sea valido.
                    if (ModelState.IsValid)
                    {
                        //Guarda el registro en la base de datos.
                        db.bitacoras.Add(_bitacora);
                        db.SaveChanges();

                        //Redirecciona a la vista.
                        return View();
                    }
                }
                //Actualiza la vista.
                return View();
            }
            catch (Exception e)
            {
                //Actualiza la vista.
                return View();
            }
        }
    }
}