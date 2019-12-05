using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using wxBotModel.DbModel_Sqlite;

namespace wxBot.Controllers
{
    public class WebMediasController : Controller
    {
        private readonly ModelBase _context;

        public WebMediasController(ModelBase context)
        {
            _context = context;
        }

        // GET: WebMedias
        public async Task<IActionResult> Index()
        {
            return View(await _context.webMedia.ToListAsync());
        }

        // GET: WebMedias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webMedia = await _context.webMedia
                .FirstOrDefaultAsync(m => m.ImgId == id);
            if (webMedia == null)
            {
                return NotFound();
            }

            return View(webMedia);
        }

        // GET: WebMedias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WebMedias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImgId,ImgSrc,ImgMD5")] WebMedia webMedia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(webMedia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(webMedia);
        }

        // GET: WebMedias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webMedia = await _context.webMedia.FindAsync(id);
            if (webMedia == null)
            {
                return NotFound();
            }
            return View(webMedia);
        }

        // POST: WebMedias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ImgId,ImgSrc,ImgMD5")] WebMedia webMedia)
        {
            if (id != webMedia.ImgId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(webMedia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WebMediaExists(webMedia.ImgId))
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
            return View(webMedia);
        }

        // GET: WebMedias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webMedia = await _context.webMedia
                .FirstOrDefaultAsync(m => m.ImgId == id);
            if (webMedia == null)
            {
                return NotFound();
            }

            return View(webMedia);
        }

        // POST: WebMedias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var webMedia = await _context.webMedia.FindAsync(id);
            _context.webMedia.Remove(webMedia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WebMediaExists(int id)
        {
            return _context.webMedia.Any(e => e.ImgId == id);
        }
    }
}
