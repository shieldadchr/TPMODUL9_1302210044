using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302210044
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa : Controller
    {
        public static List<mahasiswa> mhs = new List<mahasiswa>
        {
            new mahasiswa {Nama = "Nadhifa Affiyan Zalwi", Nim = "1302213035"},
            new mahasiswa {Nama = "Marsya Rayani Humaira", Nim = "1302213003"},
            new mahasiswa {Nama = "Hilmi Fauziyyah Supriatna", Nim = "1302210081"},
            new mahasiswa {Nama = "Gabriela Sheryl Audrey Tambunan", Nim = "1302213054"},
            new mahasiswa {Nama = "Muthia Khairunnisa", Nim = "1302213062"}
        };

        // GET: api/<Mahasiswa>
        // mereturn output berupa list dari semua obj mhs
        [HttpGet]
        public IEnumerable<mahasiswa> Get()
        {
            return mhs;
        }

        // GET api/<Mahasiswa>/{id}
        // mereturn output berupa obj mhs ke-i
        [HttpGet("{id}")]
        public mahasiswa Get(int id)
        {
            return mhs[id];
        }

        // POST api/<Mahasiswa>
        // menambah obj mhs baru 
        [HttpPost]
        public IActionResult Post([FromBody] mahasiswa newMhs)
        {
            mhs.Add(newMhs);
            return Ok();
        }

        // DELETE api/<Mahasiswa>/{id}
        // menghapus obj mhs ke-i
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id >= mhs.Count)
            {
                return NotFound();
            }

            mhs.RemoveAt(id);
            return Ok();
        }
    }

    public class mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
    }
}