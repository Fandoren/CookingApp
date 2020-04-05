using CookingApp.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookingApp.ViewModel
{
    class WindowViewModel
    {
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;
    }
}
