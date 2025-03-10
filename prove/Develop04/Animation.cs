using System;
using System.Collections.Generic;
using System.Threading;

class Animation
{
    public void ShowSpinner(int duration)
    {
        List<string> animation = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animation[i]);
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the previous character

            i = (i + 1) % animation.Count; // Loop back to the first frame
        }
    }
}