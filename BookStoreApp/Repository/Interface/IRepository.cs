﻿using BookStoreApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Repository.Interface
{
	public interface IRepository
	{
		Task<IEnumerable<Books>> GetBooks();
		IEnumerable<Genres> GetGenres();

	}
}
