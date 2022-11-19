﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Models;

namespace Training.Services.Interfaces
{
    public interface IBookService
    {
        int GetCount(Predicate<Book> predicate);
    }
}
