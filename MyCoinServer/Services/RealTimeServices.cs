using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoinServer.Services
{
    using System.Threading;

    public class RealTimeServices
    {
        public static Thread CheckConnexionThread = new Thread(
            (t) =>
                {

                });
        public static Thread CheckInscrptionThread = new Thread(
            (t) =>
                {

                });
    }
}
