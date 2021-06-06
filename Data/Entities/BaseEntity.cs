using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class BaseEntity
    {
        [Key]
        public int  Id { get; set; }

        public int CreatedBy { get; set; } // id na suzdatelq na zapisa
        public DateTime? CreatedOn { get; set; } // data na suzdavane vuprositelnata sled tipa danni e  da moje tezi danni da ne sa zaduljitelni

        public int UpdatedBy { get; set; } // id na updeitva6tiq na zapisa
        public DateTime? UpdatedOn { get; set; } // data na redaktirane
    }
}
