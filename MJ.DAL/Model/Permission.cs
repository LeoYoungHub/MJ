using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ.DAL.Model
{
    [Table("Permission")]
    public class Permission
    {
        [Key]//主键
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
        public DateTime CreatTime { get; set; }

    }
}
