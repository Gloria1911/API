using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAPP
{
    public class Students
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        [MaxLength(255), NotNull]

        public string Name { get; set; }

        [MaxLength(255), NotNull]

        public string Surname { get; set; }

      //  [ForeignKey(typeof(Class))]

       // public int Id_Class { get; set; }
    }
}
