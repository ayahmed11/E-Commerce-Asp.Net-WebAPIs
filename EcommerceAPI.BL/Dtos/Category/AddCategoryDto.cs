﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.Category
{
    public class AddCategoryDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = string.Empty;
    }
}
