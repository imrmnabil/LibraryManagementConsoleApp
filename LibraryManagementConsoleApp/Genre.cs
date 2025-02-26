using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementConsoleApp
{
    class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }

        public string Details { get; set; }

        public Genre (int id, string genreName)
        {
            Id = id;
            GenreName = genreName;
        }

        public string GetInfo()
        {
            return $"Id: {Id}, Genre: {GenreName}, Details: {Details}";
        }

    }
}
