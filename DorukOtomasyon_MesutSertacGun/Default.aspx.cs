using DorukOtomasyon_MesutSertacGun.Data_Generate;
using DorukOtomasyon_MesutSertacGun.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DorukOtomasyon_MesutSertacGun
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Process> processList = DataOfProcess.GetList();
            List<StopOfProcess> stopProcessList = DataOfStopProcess.GetList();

            DataTable dataTable = new DataTable();

            AddColumnToDataTable(processList, stopProcessList, dataTable);
            AddRowToDataTable(processList, stopProcessList, dataTable);

            GridView.DataSource = dataTable;
            GridView.DataBind();
        }

        private void AddColumnToDataTable(List<Process> processList, List<StopOfProcess> stopProcessList, DataTable dataTable)
        {
            dataTable.Columns.Add(new DataColumn("İş Emri", typeof(string)));

            DataColumnCollection columns = dataTable.Columns;

            foreach (var stopProcess in stopProcessList)
            {
                if (!columns.Contains(stopProcess.Reason))
                {
                    dataTable.Columns.Add(new DataColumn(stopProcess.Reason, typeof(int)));
                }
            }
            dataTable.Columns.Add(new DataColumn("Toplam", typeof(string)));
        }

        private void AddRowToDataTable(List<Process> processList, List<StopOfProcess> stopProcessList, DataTable dataTable)
        {
            DateTime maxStart;
            DateTime minEnd;
            DataRow newRow;

            foreach (var process in processList)
            {
                newRow = dataTable.NewRow();
                newRow[0] = process.ID;
                for (int i = 1; i < dataTable.Columns.Count; i++)
                {
                    newRow[i] = 0;
                }
                dataTable.Rows.Add(newRow);

                foreach (var stopProcess in stopProcessList)
                {
                    if (process.StartDate >= stopProcess.StartDate)
                    {
                        maxStart = process.StartDate;
                    }
                    else
                    {
                        maxStart = stopProcess.StartDate;
                    }
                    if (process.EndDate <= stopProcess.EndDate)
                    {
                        minEnd = process.EndDate;
                    }
                    else
                    {
                        minEnd = stopProcess.EndDate;
                    }
                    if (maxStart < minEnd)
                    {
                        int minutesOfBetweenProcessAndStopPrecess = (int)minEnd.Subtract(maxStart).TotalMinutes;
                        dataTable.Rows[dataTable.Rows.Count-1][stopProcess.Reason] = minutesOfBetweenProcessAndStopPrecess + dataTable.Rows[dataTable.Rows.Count-1][stopProcess.Reason].GetHashCode();
                    }
                }
            }

            newRow = dataTable.NewRow();
            newRow[0] = "Toplam";
            dataTable.Rows.Add(newRow);

            int totalRow = 0;
            int totalColumn = 0;

            foreach (var col in dataTable.Columns)
            {
                totalColumn = 0;
                if (col.ToString() != "İş Emri")
                {
                    for (int i = 0; i < dataTable.Rows.Count - 1; i++)
                    {
                        totalColumn += dataTable.Rows[i][col.ToString()].GetHashCode();
                    }
                    dataTable.Rows[dataTable.Rows.Count - 1][col.ToString()] = totalColumn;
                }
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                totalRow = 0;
                foreach (var col in dataTable.Columns)
                {
                    if (col.ToString() != "İş Emri" && col.ToString() != "Toplam")
                    {
                        totalRow += dataTable.Rows[i][col.ToString()].GetHashCode();
                    }
                }
                dataTable.Rows[i]["Toplam"] = totalRow;
            }
        }

        protected void ButtonAddNewData_Click(object sender, EventArgs e)
        {
            List<Process> processList = DataOfProcess.GetList();
            List<StopOfProcess> stopProcessList = DataOfStopProcess.GetList();

            DataOfProcess.AddToList(1010, "5.01.2017 08:00:00", "5.01.2017 16:00:00", processList);
            DataOfProcess.AddToList(1011, "3.01.2017 16:00:00", "5.01.2017 18:00:00", processList);
            DataOfProcess.AddToList(1012, "5.01.2017 17:00:00", "5.01.2017 19:30:00", processList);
            DataOfProcess.AddToList(1013, "5.01.2017 19:00:00", "5.01.2017 23:00:00", processList);
            DataOfProcess.AddToList(1014, "5.01.2017 03:00:00", "5.01.2017 12:00:00", processList);
            DataOfProcess.AddToList(1015, "5.01.2017 15:00:00", "5.01.2017 23:00:00", processList);

            DataOfStopProcess.AddToList("EK1", "5.01.2017 00:00:00", "5.01.2017 04:10:00", stopProcessList);
            DataOfStopProcess.AddToList("EK2", "5.01.2017 04:30:00", "5.01.2017 08:00:00", stopProcessList);
            DataOfStopProcess.AddToList("EK3", "5.01.2017 08:00:00", "5.01.2017 12:30:00", stopProcessList);
            DataOfStopProcess.AddToList("EK4", "5.01.2017 16:00:00", "5.01.2017 20:10:00", stopProcessList);
            DataOfStopProcess.AddToList("EK5", "5.01.2017 15:00:00", "5.01.2017 16:30:00", stopProcessList);
            DataOfStopProcess.AddToList("EK6", "5.01.2017 18:00:00", "5.01.2017 23:10:00", stopProcessList);

            DataTable dataTable = new DataTable();

            AddColumnToDataTable(processList, stopProcessList, dataTable);
            AddRowToDataTable(processList, stopProcessList, dataTable);

            GridView.DataSource = dataTable;
            GridView.DataBind();
        }
    }
}