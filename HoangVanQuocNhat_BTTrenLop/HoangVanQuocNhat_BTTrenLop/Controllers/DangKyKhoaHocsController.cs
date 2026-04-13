using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HoangVanQuocNhat_BTTrenLop.Data;
using HoangVanQuocNhat_BTTrenLop.Models;

namespace HoangVanQuocNhat_BTTrenLop.Controllers
{
    public class DangKyKhoaHocsController : Controller
    {
        private readonly AppDbContext _context;

        public DangKyKhoaHocsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DangKyKhoaHocs
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.DangKyKhoaHocs.Include(d => d.KhoaHoc).Include(d => d.SinhVien);
            return View(await appDbContext.ToListAsync());
        }

        // GET: DangKyKhoaHocs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangKyKhoaHoc = await _context.DangKyKhoaHocs
                .Include(d => d.KhoaHoc)
                .Include(d => d.SinhVien)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dangKyKhoaHoc == null)
            {
                return NotFound();
            }

            return View(dangKyKhoaHoc);
        }

        // GET: DangKyKhoaHocs/Create
        public IActionResult Create()
        {
            ViewData["mkh"] = new SelectList(_context.KhoaHocs, "mkh", "mkh");
            ViewData["msv"] = new SelectList(_context.SinhViens, "msv", "msv");
            return View();
        }

        // POST: DangKyKhoaHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NgayDK,msv,mkh")] DangKyKhoaHoc dangKyKhoaHoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dangKyKhoaHoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["mkh"] = new SelectList(_context.KhoaHocs, "mkh", "mkh", dangKyKhoaHoc.mkh);
            ViewData["msv"] = new SelectList(_context.SinhViens, "msv", "msv", dangKyKhoaHoc.msv);
            return View(dangKyKhoaHoc);
        }

        // GET: DangKyKhoaHocs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangKyKhoaHoc = await _context.DangKyKhoaHocs.FindAsync(id);
            if (dangKyKhoaHoc == null)
            {
                return NotFound();
            }
            ViewData["mkh"] = new SelectList(_context.KhoaHocs, "mkh", "mkh", dangKyKhoaHoc.mkh);
            ViewData["msv"] = new SelectList(_context.SinhViens, "msv", "msv", dangKyKhoaHoc.msv);
            return View(dangKyKhoaHoc);
        }

        // POST: DangKyKhoaHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NgayDK,msv,mkh")] DangKyKhoaHoc dangKyKhoaHoc)
        {
            if (id != dangKyKhoaHoc.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dangKyKhoaHoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DangKyKhoaHocExists(dangKyKhoaHoc.Id))
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
            ViewData["mkh"] = new SelectList(_context.KhoaHocs, "mkh", "mkh", dangKyKhoaHoc.mkh);
            ViewData["msv"] = new SelectList(_context.SinhViens, "msv", "msv", dangKyKhoaHoc.msv);
            return View(dangKyKhoaHoc);
        }

        // GET: DangKyKhoaHocs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dangKyKhoaHoc = await _context.DangKyKhoaHocs
                .Include(d => d.KhoaHoc)
                .Include(d => d.SinhVien)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dangKyKhoaHoc == null)
            {
                return NotFound();
            }

            return View(dangKyKhoaHoc);
        }

        // POST: DangKyKhoaHocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dangKyKhoaHoc = await _context.DangKyKhoaHocs.FindAsync(id);
            if (dangKyKhoaHoc != null)
            {
                _context.DangKyKhoaHocs.Remove(dangKyKhoaHoc);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DangKyKhoaHocExists(int id)
        {
            return _context.DangKyKhoaHocs.Any(e => e.Id == id);
        }
    }
}
