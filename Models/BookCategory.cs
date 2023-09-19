﻿using System;
using System.Collections.Generic;

namespace Assignment6.Models;

public partial class BookCategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
