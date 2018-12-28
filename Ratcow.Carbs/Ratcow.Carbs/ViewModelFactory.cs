using System;
using System.Collections.Generic;
using System.Text;

namespace Ratcow.Carbs
{
    /// <summary>
    /// Will replace this with IoC at some point.
    /// </summary>
    internal static class ViewModelFactory
    {
       public static IMainPageViewModel GetMainPageViewModel()
        {
            return new MainPageViewModel();
        }
    }
}
