using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal interface ILoggerService
    {
        void Log(); // Log methodu, loglama işlemini gerçekleştirecek. 
        // Bu metot, farklı loglama yöntemleri için (örneğin, dosyaya yazma, veritabanına kaydetme) uygulanabilir.  
    }
}
