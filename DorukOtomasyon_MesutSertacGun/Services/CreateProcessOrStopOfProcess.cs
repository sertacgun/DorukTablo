using DorukOtomasyon_MesutSertacGun.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DorukOtomasyon_MesutSertacGun.Services
{
    public static class CreateProcessOrStopOfProcess
    {

        public static void CreateData(int id, string startDate, string endDate, List<Process> listProcess)
        {
            Process process = new Process();
            process.ID = id;
            process.StartDate = Convert.ToDateTime(startDate);
            process.EndDate = Convert.ToDateTime(endDate);
            listProcess.Add(process);
        }

        public static void CreateData(string reason, string startDate, string endDate, List<StopOfProcess> listProcessStop)
        {
            StopOfProcess processStop = new StopOfProcess();
            processStop.Reason = reason;
            processStop.StartDate = Convert.ToDateTime(startDate);
            processStop.EndDate = Convert.ToDateTime(endDate);
            listProcessStop.Add(processStop);
        }

    }
}