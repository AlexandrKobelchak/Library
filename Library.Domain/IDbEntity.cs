using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{
    public interface IDbEntity
    {
        [Key]
        int Id { get; set; }
    }
}
