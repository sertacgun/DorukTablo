using DorukOtomasyon_MesutSertacGun.Model;
using DorukOtomasyon_MesutSertacGun.Services;
using System.Collections.Generic;

namespace DorukOtomasyon_MesutSertacGun.Data_Generate
{
    public static class DataOfStopProcess
    {
        public static List<StopOfProcess> GetList()
        {
            List<StopOfProcess> listProcessStop = new List<StopOfProcess>();

            CreateProcessOrStopOfProcess.CreateData("Mola" , "1.01.2017 10:00:00", "1.01.2017 10:10:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Arıza", "1.01.2017 10:30:00", "1.01.2017 11:00:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "1.01.2017 12:00:00", "1.01.2017 12:30:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "1.01.2017 14:00:00", "1.01.2017 14:10:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Setup", "1.01.2017 15:00:00", "1.01.2017 16:30:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "1.01.2017 18:00:00", "1.01.2017 18:10:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "1.01.2017 20:00:00", "1.01.2017 20:30:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "1.01.2017 22:00:00", "1.01.2017 22:10:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Arge" , "1.01.2017 23:00:00", "2.01.2017 08:30:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "2.01.2017 10:00:00", "2.01.2017 10:10:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "2.01.2017 12:00:00", "2.01.2017 12:30:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Arıza", "2.01.2017 13:00:00", "2.01.2017 13:45:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "2.01.2017 14:00:00", "2.01.2017 14:10:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Arge" , "2.01.2017 20:00:00", "3.01.2017 02:10:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "3.01.2017 04:00:00", "3.01.2017 04:30:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Setup", "3.01.2017 06:00:00", "3.01.2017 09:30:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "3.01.2017 10:00:00", "3.01.2017 10:10:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "3.01.2017 12:00:00", "3.01.2017 12:30:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Arıza", "3.01.2017 15:00:00", "3.01.2017 18:45:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "3.01.2017 20:00:00", "3.01.2017 20:30:00", listProcessStop);
            CreateProcessOrStopOfProcess.CreateData("Mola" , "3.01.2017 22:00:00", "3.01.2017 22:10:00", listProcessStop);

            return listProcessStop;
        }

        public static List<StopOfProcess> AddToList(string reason, string startDate, string endDate, List<StopOfProcess> listProcessStop)
        {
            CreateProcessOrStopOfProcess.CreateData(reason, startDate, endDate, listProcessStop);
            return listProcessStop;
        }
    }
}