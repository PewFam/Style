using System;

namespace prog // Modify here
{
   
    internal class Style
    {
        public int bottom = Console.WindowHeight - 1;
        private static int width = Console.WindowWidth;
        private static int height = Console.WindowHeight;
        private int left = width / 2;
        private int top = height / 2 - 1;

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para><em>Any type string</em></para></description></item>
        /// <item><description><para><em>Interval in ms.</em> 0 = normal</para></description></item>
        /// </list>
        /// </summary>
        public void Center(string text, double interval)
        {
            
            int centered = left - text.Length / 2;
            Console.SetCursorPosition(centered,top);
            
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                
                System.Threading.Thread.Sleep(Convert.ToInt32(interval));
            }
            Console.ResetColor();
        }
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para><em>Any type string</em></para></description></item>
        /// <item><description><para><em>Interval in ms.</em> 0 = normal</para></description></item>
        /// </list>
        /// </summary>
        public void XCenter(string text,double interval)
        {
            int centered = left - text.Length / 2;
            Console.SetCursorPosition(centered,Console.CursorTop);
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                System.Threading.Thread.Sleep(Convert.ToInt32(interval));
            }
            Console.ResetColor();
        }


    }
    public class Colors
    {
        public string resetBackground = "\u001b[48;5;0m";
        public string resetForeground = "\u001b[38;5;0m";
        public string blackFore = "\x1b[38;5;0m";
        public string redFore = "\x1b[38;5;1m";
        public string greenFore = "\x1b[38;5;2m";
        public string yellowFore = "\x1b[38;5;3m";
        public string blueFore = "\x1b[38;5;4m";
        public string purpleFore = "\x1b[38;5;5m";
        public string tealFore = "\x1b[38;5;6m";
        public string silverFore = "\x1b[38;5;7m";
        public string greyFore = "\x1b[38;5;8m";
        public string b_redFore = "\x1b[38;5;9m";
        public string b_greenFore = "\x1b[38;5;10m";
        public string b_yellowFore = "\x1b[38;5;11m";
        public string b_blueFore = "\x1b[38;5;12m";
        public string fushiaFore = "\x1b[38;5;13m";
        public string cyanFore = "\x1b[38;5;14m";
        public string whiteFore = "\x1b[38;5;15m";
        public string navyBlueFore = "\x1b[38;5;17m";
        public string darkBlueFore = "\x1b[38;5;18m";
        public string darkGreenFore = "\x1b[38;5;22m";
        public string turquoiseFore = "\x1b[38;5;30m";
        public string cyan1Fore = "\x1b[38;5;50m";
        public string cyan2Fore = "\x1b[38;5;51m";
        public string darkRedFore = "\x1b[38;5;52m";
        public string darkPinkFore = "\x1b[38;5;53m";
        public string coolPurpleFore = "\x1b[38;5;56m";
        public string pinkFore = "\x1b[38;5;165m";
        public string darkOrangeFore = "\x1b[38;5;166m";
        public string orangeFore = "\x1b[38;5;172m";
        public string salmonFore = "\x1b[38;5;173m";
        public string lemonFore = "\x1b[38;5;150m";
        public string blackBack = "\x1b[48;5;0m";
        public string redBack = "\x1b[48;5;1m";
        public string greenBack = "\x1b[48;5;2m";
        public string yellowBack = "\x1b[48;5;3m";
        public string blueBack = "\x1b[48;5;4m";
        public string purpleBack = "\x1b[48;5;5m";
        public string tealBack = "\x1b[48;5;6m";
        public string silverBack = "\x1b[48;5;7m";
        public string greyBack = "\x1b[48;5;8m";
        public string b_redBack = "\x1b[48;5;9m";
        public string b_greenBack = "\x1b[48;5;10m";
        public string b_yellowBack = "\x1b[48;5;11m";
        public string b_blueBack = "\x1b[48;5;12m";
        public string fushiaBack = "\x1b[48;5;13m";
        public string cyanBack = "\x1b[48;5;14m";
        public string whiteBack = "\x1b[48;5;15m";
        public string navyBlueBack = "\x1b[48;5;17m";
        public string darkBlueBack = "\x1b[48;5;18m";
        public string darkGreenBack = "\x1b[48;5;22m";
        public string turquoiseBack = "\x1b[48;5;30m";
        public string cyan1Back = "\x1b[48;5;50m";
        public string cyan2Back = "\x1b[48;5;51m";
        public string darkRedBack = "\x1b[48;5;52m";
        public string darkPinkBack = "\x1b[48;5;53m";
        public string coolPurpleBack = "\x1b[48;5;56m";
        public string pinkBack = "\x1b[48;5;165m";
        public string darkOrangeBack = "\x1b[48;5;166m";
        public string orangeBack = "\x1b[48;5;172m";
        public string salmonBack = "\x1b[48;5;173m";
        public string lemonBack = "\x1b[48;5;150m";



    }
}
