using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NZBDK.Models
{
    public partial class Variant
    {
        public int Id { get; set; }
        public int Sygnature_Id { get; set; }
        public string? Name { get; set; }
        public int Segment_Id { get; set; }

    }
}
