using DorukOtomasyon_MesutSertacGun.Model;
using DorukOtomasyon_MesutSertacGun.Services;
using System.Collections.Generic;

namespace DorukOtomasyon_MesutSertacGun.Data_Generate
{
    public static class DataOfProcess
    {
        public static List<Process> GetList()
        {
            List<Process> listProcess = new List<Process>();

            CreateProcessOrStopOfProcess.CreateData(1001, "1.01.2017 08:00:00", "1.01.2017 16:00:00", listProcess);
            CreateProcessOrStopOfProcess.CreateData(1002, "1.01.2017 16:00:00", "2.01.2017 00:00:00", listProcess);
            CreateProcessOrStopOfProcess.CreateData(1003, "2.01.2017 00:00:00", "2.01.2017 08:00:00", listProcess);
            CreateProcessOrStopOfProcess.CreateData(1004, "2.01.2017 08:00:00", "2.01.2017 16:00:00", listProcess);
            CreateProcessOrStopOfProcess.CreateData(1005, "2.01.2017 16:00:00", "3.01.2017 00:00:00", listProcess);
            CreateProcessOrStopOfProcess.CreateData(1006, "3.01.2017 00:00:00", "3.01.2017 08:00:00", listProcess);
            CreateProcessOrStopOfProcess.CreateData(1007, "3.01.2017 08:00:00", "3.01.2017 16:00:00", listProcess);
            CreateProcessOrStopOfProcess.CreateData(1008, "3.01.2017 16:00:00", "4.01.2017 00:00:00", listProcess);
            CreateProcessOrStopOfProcess.CreateData(1009, "4.01.2017 00:00:00", "4.01.2017 08:00:00", listProcess);

            return listProcess;
        }
        public static List<Process> AddToList(int id, string startDate, string endDate, List<Process> listProcess)
        {
            CreateProcessOrStopOfProcess.CreateData(id, startDate, endDate, listProcess);
            return listProcess;
        }
    }
}