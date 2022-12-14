
using Microsoft.AspNetCore.Mvc;
using SistemaWebEmpleado.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using WebPasajero.Context.EntityFrameworkExample.Data;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {



        private readonly SistemaWebEmpleadoContext _context;

        public EmpleadoController(SistemaWebEmpleadoContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            
            return View("View", _context.Empleados.ToList());
        }



        [HttpGet("/Empleado/ListaPorTitulo/{titulo}")]
        // GET: /Empleado/ListaPorTitulo/ingeniero
        public IActionResult ListaPorTitulo(string titulo)
        {
            List<Empleado> lista = (from p in _context.Empleados
                                    where p.Titulo == titulo
                                    select p).ToList();
            return View("View", lista);
            
        }



        public IActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View("Create", empleado);
        }


        // POST: /Pasajero/Create
        [HttpPost]
        public IActionResult Create(Empleado empleado)
        {
            _context.Add(empleado);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


     
      [HttpGet]
      public IActionResult Edit(int id)
      {
          Empleado empleado = _context.Empleados.SingleOrDefault(m => m.EmpleadoId == id);
          return View("Edit", empleado);
      }

      

   [HttpPost]
   public IActionResult Edit(int id, Empleado empleado)
   {

       _context.Update(empleado);
       _context.SaveChanges();
       return RedirectToAction(nameof(Index));
   }

     

 [HttpGet]
 public IActionResult Delete_confirm(int id)
 {
     Empleado empleado = _context.Empleados.SingleOrDefault(m => m.EmpleadoId== id);
     return View("Delete", empleado);
 }

 [HttpPost]
 public IActionResult Delete(int EmpleadoId)
 {
     var empleado = _context.Empleados.SingleOrDefault(m => m.EmpleadoId == EmpleadoId);
     _context.Empleados.Remove(empleado);
     _context.SaveChanges();
     return RedirectToAction(nameof(Index));
 }


}
    
}
