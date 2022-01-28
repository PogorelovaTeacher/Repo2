using System;
using System.Windows.Forms;


namespace ProjectOne
{
    public class Calendar
    {
        public static void Main()
        {
            DateTime now = GetCurrentDate();
            Console.WriteLine($"Today's date is {now} ");
            //MessageBox.Show($"Today's date is {now} ");
            Console.ReadLine();

            
        }

        static DateTime GetCurrentDate()
        {
            return DateTime.Now.Date;
        }


    }
}
