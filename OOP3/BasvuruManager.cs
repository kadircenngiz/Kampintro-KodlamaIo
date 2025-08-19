using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List< ILoggerService> loggerService)

        {
            krediManager.Hesapla();
           foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }
        public void KrediOnBigilendirmesiYap(List<IKrediManager> krediler)
        { 
           foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
             
        }
            
    }
}
