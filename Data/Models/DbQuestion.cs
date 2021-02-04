using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CorporateQnA.Data.Models
{
    public class DbQuestion
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [ForeignKey("Categories")]
        public string CategoryId { get; set; }
        public DbCategory Category { get; set; }
        [ForeignKey("UserDetails")]
        public string UserId { get; set; }
        public AuthUser User { get; set; }
        public int UpVotes { get; set; }
        public int Views { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
