﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrainOnline.Data;
using TrainOnline.Models;

namespace TrainOnline.Controllers
{
    public class TrainsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrainsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Trains
        public async Task<IActionResult> Index(string filter = "", bool? sortTrainNumber = null, int index = 1, int size = 10)
        {

            var result = _context.Trains.AsQueryable();
            if (!string.IsNullOrEmpty(filter))
            {
                var trainNumberFilter = 0;
                int.TryParse(filter, out trainNumberFilter);
                result = result.Where(r => r.TrainNumber.ToString().Equals(trainNumberFilter.ToString()));
            }

            if (sortTrainNumber != null)
            {
                if (sortTrainNumber == true)
                {
                    result = result.OrderBy(r => r.TrainNumber);
                }
                else
                {
                    result = result.OrderByDescending(r => r.TrainNumber);
                }
            }

            var total = result.Count();
            result = result.Skip((index - 1) * size).Take(size);

            ViewBag.Filter = filter;
            ViewBag.SortTrainNumber = sortTrainNumber;
            ViewBag.Total = total;
            ViewBag.Index = index;
            ViewBag.Size = size;
            return View(result);
        }

        // GET: Trains/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Trains == null)
            {
                return NotFound();
            }

            var train = await _context.Trains
                .Include(t => t.GetStatusId)
                .Include(t => t.GetTypeId)
                .FirstOrDefaultAsync(m => m.TrainId == id);
            if (train == null)
            {
                return NotFound();
            }

            return View(train);
        }

        // GET: Trains/Create
        public IActionResult Create()
        {
            ViewData["StatusId"] = new SelectList(_context.Statuses, "StatusId", "StatusId");
            ViewData["TypeId"] = new SelectList(_context.Types, "TypeId", "TypeId");
            return View();
        }

        // POST: Trains/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TrainId,TrainNumber,TypeId,StatusId,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,DeleteDate")] Train train)
        {
            if (ModelState.IsValid)
            {
                _context.Add(train);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusId"] = new SelectList(_context.Statuses, "StatusId", "StatusId", train.StatusId);
            ViewData["TypeId"] = new SelectList(_context.Types, "TypeId", "TypeId", train.TypeId);
            return View(train);
        }

        // GET: Trains/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Trains == null)
            {
                return NotFound();
            }

            var train = await _context.Trains.FindAsync(id);
            if (train == null)
            {
                return NotFound();
            }
            ViewData["StatusId"] = new SelectList(_context.Statuses, "StatusId", "StatusId", train.StatusId);
            ViewData["TypeId"] = new SelectList(_context.Types, "TypeId", "TypeId", train.TypeId);
            return View(train);
        }

        // POST: Trains/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TrainId,TrainNumber,TypeId,StatusId,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,DeleteDate")] Train train)
        {
            if (id != train.TrainId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(train);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainExists(train.TrainId))
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
            ViewData["StatusId"] = new SelectList(_context.Statuses, "StatusId", "StatusId", train.StatusId);
            ViewData["TypeId"] = new SelectList(_context.Types, "TypeId", "TypeId", train.TypeId);
            return View(train);
        }

        // GET: Trains/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Trains == null)
            {
                return NotFound();
            }

            var train = await _context.Trains
                .Include(t => t.GetStatusId)
                .Include(t => t.GetTypeId)
                .FirstOrDefaultAsync(m => m.TrainId == id);
            if (train == null)
            {
                return NotFound();
            }

            return View(train);
        }

        // POST: Trains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Trains == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Trains'  is null.");
            }
            var train = await _context.Trains.FindAsync(id);
            if (train != null)
            {
                _context.Trains.Remove(train);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainExists(int id)
        {
          return (_context.Trains?.Any(e => e.TrainId == id)).GetValueOrDefault();
        }
    }
}
