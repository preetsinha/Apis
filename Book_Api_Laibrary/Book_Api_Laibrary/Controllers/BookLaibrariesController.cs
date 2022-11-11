using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Book_Api_Laibrary.Models;
using Book_Api_Laibrary.DTOs;
using AutoMapper;

namespace Book_Api_Laibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookLaibrariesController : ControllerBase
    {
        private readonly BookDbContext _context;
        private readonly IMapper _mapper;

        public BookLaibrariesController(BookDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/BookLaibraries
        [HttpGet("list")]
        public async Task<ActionResult<IEnumerable<BookLaibrary>>> GetBooks()
        {
            if (_context.Books == null)
            {
                return NotFound();
            }
            return await _context.Books.ToListAsync();
        }

        // GET: api/BookLaibraries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookLaibrary>> GetBookLaibrary(int id)
        {
            if (_context.Books == null)
            {
                return NotFound();
            }
            var bookLaibrary = await _context.Books.FindAsync(id);

            if (bookLaibrary == null)
            {
                return NotFound();
            }

            return bookLaibrary;
        }

        // PUT: api/BookLaibraries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookLaibrary(int id, BookLaibrary bookLaibrary)
        {

            try
            {
                if (id != bookLaibrary.Id)
                {
                    return BadRequest();
                }

                _context.Entry(bookLaibrary).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookLaibraryExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        // POST: api/BookLaibraries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("add")]
        public async Task<ActionResult<BookLaibrary>> PostBookLaibrary([FromBody] BookLiabrary bookLaibrary)
        {
            //BookLaibrary bookLaibrary1 = null;
            var mappedData = _mapper.Map<BookLaibrary>(bookLaibrary);
            if (_context.Books == null)
            {
                return Problem("Entity set 'BookDbContext.Books'  is null.");
            }
            var addedData = _context.Books.Add(mappedData).Entity;
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookLaibrary", new { id = addedData.Id }, bookLaibrary);
        }

        // DELETE: api/BookLaibraries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookLaibrary(int id)
        {
            if (_context.Books == null)
            {
                return NotFound();
            }
            var bookLaibrary = await _context.Books.FindAsync(id);
            if (bookLaibrary == null)
            {
                return NotFound();
            }

            _context.Books.Remove(bookLaibrary);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookLaibraryExists(int id)
        {
            return (_context.Books?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
