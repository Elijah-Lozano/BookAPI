﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookAPI.Models;

namespace BookAPI.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> Get(int Id);
        Task<Book> Create(Book book);
        Task Update(Book book);
        Task Delete(int Id);
    }
}