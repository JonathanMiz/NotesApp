﻿using NotesApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Services
{
	 public interface ILoginService
	 {
		  void Login();

		  User GetUserFromDB(string username);
	 }
}