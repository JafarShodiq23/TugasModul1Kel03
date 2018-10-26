using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Kelompok03.Model
{
    class DataMahasiswa
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Jurusan { get; set; }

        public override string ToString()
        {
            return "Nama : " + this.Nama + " ==> Jurusan : " + this.Jurusan;
        }
    }
}
