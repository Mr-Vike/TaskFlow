using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFlow.Services
{
    interface INavigationService
    {
        public void Navigate(string pageKey);
    }
}
