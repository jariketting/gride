﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gride.Data;
using Gride.Models;

namespace Gride.Controllers
{
    public class SkillsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SkillsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: skills
        public async Task<IActionResult> Index()
        {
            return View(await _context.Skill.ToListAsync());
        }

        // GET: skills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skill
                .FirstOrDefaultAsync(m => m.SkillID == id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }

        // GET: skills/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: skills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SkillID,Name")] Skill skill)
        {
            if (ModelState.IsValid)
            {
                _context.Add(skill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(skill);
        }

        // GET: skills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skill.FindAsync(id);
            if (skill == null)
            {
                return NotFound();
            }
            return View(skill);
        }

        // POST: skills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SkillID,Name")] Skill skill)
        {
            if (id != skill.SkillID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillExists(skill.SkillID))
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
            return View(skill);
        }

        // GET: skills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skill
                .FirstOrDefaultAsync(m => m.SkillID == id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }

        // POST: skills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var skill = await _context.Skill.FindAsync(id);
            _context.Skill.Remove(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkillExists(int id)
        {
            return _context.Skill.Any(e => e.SkillID == id);
        }
    }
}
