﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTO
{
    public abstract class BaseDto
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
