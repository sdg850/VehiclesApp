using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VehiclesApp.Api.Data;
using VehiclesApp.Api.Data.Entities;

namespace VehiclesApp.Api.Controllers
{
    public class VehiclesTypesController : Controller
    {
        private readonly DataContext _context;

        public VehiclesTypesController(DataContext context)
        {
            _context = context;
        }

        // GET: VehiclesTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.VehiclesType.ToListAsync());
        }


        // GET: VehiclesTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Description")] VehiclesType vehiclesType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(vehiclesType);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbUpdateException)
                {
                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "This vehicle already exist.");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, dbUpdateException.InnerException.Message);
                    }
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }
            }
            return View(vehiclesType);
        }

        // GET: VehiclesTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiclesType = await _context.VehiclesType.FindAsync(id);
            if (vehiclesType == null)
            {
                return NotFound();
            }
            return View(vehiclesType);
        }

        // POST: VehiclesTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  VehiclesType vehiclesType)
        {
            if (id != vehiclesType.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehiclesType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException dbUpdateException)
                {
                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "This vehicle already exist.");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, dbUpdateException.InnerException.Message);
                    }
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }
                
            }
            return View(vehiclesType);
        }

        // GET: VehiclesTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehiclesType = await _context.VehiclesType
                .FirstOrDefaultAsync(m => m.id == id);
            if (vehiclesType == null)
            {
                return NotFound();
            }

            _context.VehiclesType.Remove(vehiclesType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
 