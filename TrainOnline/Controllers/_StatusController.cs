using System;
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
    public class _StatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public _StatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: _Status
        public async Task<IActionResult> Index(string filter = "", bool? sortTableName = null, int index = 1, int size = 10)
        {
           // var result = _context.Saches.Include(r => r.GetNhaXuatBan).AsQueryable();

            var result = _context.Statuses.AsQueryable();
            if (filter != null)
            {
                result = result.Where(r => r.TableName.ToLower().Contains(filter.ToLower())
                );

                //var giaTien = 0;
                //int.TryParse(filter, out giaTien);
                //result = result.Where(r => r.Ten.ToLower().Contains(filter.ToLower()) ||
                //                           r.DonViTinh.ToLower().Contains(filter.ToLower()) ||
                //                           (giaTien > 0 && r.GiaTien <= giaTien)

                //);
            }

            if (sortTableName != null)
            {
                if (sortTableName == true)
                {
                    result = result.OrderBy(r => r.TableName);
                }
                else
                {
                    result = result.OrderByDescending(r => r.TableName);
                }
            }

            var total = result.Count();
            result = result.Skip((index - 1) * size).Take(size);

            ViewBag.Filter = filter;
            ViewBag.SortTableName = sortTableName;
            ViewBag.Total = total;
            ViewBag.Index = index;
            ViewBag.Size = size;
            return View(result);
        }

        // GET: _Status/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Statuses == null)
            {
                return NotFound();
            }

            var _Status = await _context.Statuses
                .FirstOrDefaultAsync(m => m.StatusId == id);
            if (_Status == null)
            {
                return NotFound();
            }

            return View(_Status);
        }

        // GET: _Status/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: _Status/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StatusId,TableName,StateName,Value,CSSClass,Sorting,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,DeleteDate")] _Status _Status)
        {
            if (ModelState.IsValid)
            {
                _context.Add(_Status);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(_Status);
        }

        // GET: _Status/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Statuses == null)
            {
                return NotFound();
            }

            var _Status = await _context.Statuses.FindAsync(id);
            if (_Status == null)
            {
                return NotFound();
            }
            return View(_Status);
        }

        // POST: _Status/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StatusId,TableName,StateName,Value,CSSClass,Sorting,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,DeleteDate")] _Status _Status)
        {
            if (id != _Status.StatusId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(_Status);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_StatusExists(_Status.StatusId))
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
            return View(_Status);
        }

        // GET: _Status/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Statuses == null)
            {
                return NotFound();
            }

            var _Status = await _context.Statuses
                .FirstOrDefaultAsync(m => m.StatusId == id);
            if (_Status == null)
            {
                return NotFound();
            }

            return View(_Status);
        }

        // POST: _Status/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Statuses == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Statuses'  is null.");
            }
            var _Status = await _context.Statuses.FindAsync(id);
            if (_Status != null)
            {
                _context.Statuses.Remove(_Status);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool _StatusExists(int id)
        {
          return (_context.Statuses?.Any(e => e.StatusId == id)).GetValueOrDefault();
        }
    }
}
