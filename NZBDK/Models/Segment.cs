    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NZBDK.Models
{
    public partial class Segment
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
