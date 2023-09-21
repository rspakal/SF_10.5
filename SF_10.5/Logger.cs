using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_10._5
{
    internal class Logger
    {
        ILogged logService;
        public Logger(ILogged logService) => this.logService = logService;
        public void Log (string message) => logService.ShowMessage (message);
    }
}
