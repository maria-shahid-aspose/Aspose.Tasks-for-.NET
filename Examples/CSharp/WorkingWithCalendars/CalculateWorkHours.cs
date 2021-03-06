﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCalendars
{
    class CalculateWorkHours
    {
        public static void Run()
        {
            // ExStart:CalculateWorkHours
            // Load an existing project
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);
            Project project = new Project(dataDir + "CalculateWorkHours.mpp");

            // Access Task By Id
            Task task = project.RootTask.Children.GetById(1);

            // Access Calendar and it's start and end dates
            Aspose.Tasks.Calendar taskCalendar = task.Get(Tsk.Calendar);
            DateTime startDate = task.Get(Tsk.Start);
            DateTime endDate = task.Get(Tsk.Finish);
            DateTime tempDate = startDate;

            // Access resource and their calendar
            Resource resource = project.Resources.GetByUid(1);
            Aspose.Tasks.Calendar resourceCalendar = resource.Get(Rsc.Calendar);

            TimeSpan timeSpan;

            // Get Duration in Minutes
            double durationInMins = 0;
            while (tempDate < endDate)
            {
                if (taskCalendar.IsDayWorking(tempDate) && resourceCalendar.IsDayWorking(tempDate))
                {
                    timeSpan = taskCalendar.GetWorkingHours(tempDate);
                    durationInMins = durationInMins + timeSpan.TotalMinutes;
                }
                tempDate = tempDate.AddDays(1);
            }
            tempDate = startDate;

            // Get Duration in Hours
            double durationInHours = 0;
            while (tempDate < endDate)
            {
                if (taskCalendar.IsDayWorking(tempDate) && resourceCalendar.IsDayWorking(tempDate))
                {
                    timeSpan = taskCalendar.GetWorkingHours(tempDate);
                    durationInHours = durationInHours + timeSpan.TotalHours;
                }
                tempDate = tempDate.AddDays(1);
            }
            tempDate = startDate;

            // Get Duration in Days
            double durationInDays = 0;
            while (tempDate < endDate)
            {
                if (taskCalendar.IsDayWorking(tempDate) && resourceCalendar.IsDayWorking(tempDate))
                {
                    timeSpan = taskCalendar.GetWorkingHours(tempDate);
                    if (timeSpan.TotalHours > 0)
                        durationInDays = durationInDays + timeSpan.TotalDays * (24 / (timeSpan.TotalHours));
                }
                tempDate = tempDate.AddDays(1);
            }

            Console.WriteLine("Duration in Minutes = " + durationInMins);
            Console.WriteLine("Duration in Hours = " + durationInHours);
            Console.WriteLine("Duration in Days = " + durationInDays);
            // ExEnd:CalculateWorkHours
        }
    }
}
