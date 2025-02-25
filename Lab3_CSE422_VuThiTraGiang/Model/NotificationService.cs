﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CSE422_VuThiTraGiang.Model
{
    public class NotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Notification: {message}");
        }

        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"Notification to {recipient}: {message}");
        }

        public void SendNotification(string message, List<string> recipients)
        {
            foreach (var recipient in recipients)
            {
                Console.WriteLine($"Notification to {recipient}: {message}");
            }
        }

        public void LogBorrowing(string bookTitle)
        {
            Console.WriteLine($"Log: Book '{bookTitle}' borrowed at {DateTime.Now}");
        }
    }
}
