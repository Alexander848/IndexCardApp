using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexCardAppUI
{
    public static class ApplicationLayouts
    {
        private static Size defaultFormSize = new(1280, 720);

        public static Size GetFormSize()
        {
            var primaryScreen = Screen.PrimaryScreen;
            if (primaryScreen != null)
            {
                return new Size(primaryScreen.Bounds.Width * 3 / 4, primaryScreen.Bounds.Height * 3 / 4);
            } else
            {
                return defaultFormSize;
            }
         }

        public static int GetFormWidth()
        {
            return GetFormSize().Width;
        }
        public static int GetFormWidth(double factor)
        {
            return (int)(GetFormSize().Width * factor);
        }

        public static int GetFormHeight()
        {
            return GetFormSize().Height;
        }
        public static int GetFormHeight(double factor)
        {
            return (int) (GetFormSize().Height * factor);
        }
    }
}
