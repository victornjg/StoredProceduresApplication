﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StoredProceduresApplication.Models.DB;

namespace StoredProceduresApplication.Controllers
{
    public class AppointmentsMVCController : Controller
    {
        private readonly StoredProceduresDatabaseContext _context;

        public AppointmentsMVCController(StoredProceduresDatabaseContext context)
        {
            _context = context;
        }

        // GET: AppointmentsMVC
        public async Task<IActionResult> Index()
        {
            return View(await _context.Appointments.ToListAsync());
        }

        // GET: AppointmentsMVC/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointments = await _context.Appointments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointments == null)
            {
                return NotFound();
            }

            return View(appointments);
        }

        // GET: AppointmentsMVC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppointmentsMVC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,DoctorName,PatientName,StartTime,EndTime")] Appointments appointments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appointments);
        }

        // GET: AppointmentsMVC/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointments = await _context.Appointments.FindAsync(id);
            if (appointments == null)
            {
                return NotFound();
            }
            return View(appointments);
        }

        // POST: AppointmentsMVC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,DoctorName,PatientName,StartTime,EndTime")] Appointments appointments)
        {
            if (id != appointments.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentsExists(appointments.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(appointments);
        }

        // GET: AppointmentsMVC/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointments = await _context.Appointments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointments == null)
            {
                return NotFound();
            }

            return View(appointments);
        }

        // POST: AppointmentsMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appointments = await _context.Appointments.FindAsync(id);
            _context.Appointments.Remove(appointments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentsExists(int id)
        {
            return _context.Appointments.Any(e => e.Id == id);
        }
    }
}
