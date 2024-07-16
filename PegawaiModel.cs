using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih13_MdiFormLanjutan
{
    public class PegawaiModel
    {
        [Key]
        public int id { get; set; }
        public string nama { get; set; } = string.Empty;
        public string jenis_kelamin { get; set; }= string.Empty;
        public DateTime tgl_lahir { get; set; } = new DateTime(1900, 01, 01);
        public string alamat { get; set; }=string.Empty;
    }
}
