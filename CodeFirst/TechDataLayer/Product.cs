﻿using System;
using System.Collections.Generic;

namespace TechDataLayer;

public  class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int CategoryId { get; set; }

    public float Price { get; set; }

    public Category Category { get; set; }
}
