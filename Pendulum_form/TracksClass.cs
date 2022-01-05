using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendulum_form
{
    internal class TracksClass
    {
        public string title { get; set; }
        public TimeSpan length { get; set; }
        public string album { get; set; }
        public string url { get; set; }

        public TracksClass(string sor)
        {
            var v = sor.Split(';');
            title = v[0];
            if (TimeSpan.Parse(v[1]).Seconds == 0)
            {
                length = TimeSpan.Parse($"0:{v[1]}");
            }
            else
            {
                length = TimeSpan.Parse(v[1]);
            }
            album = v[2];
            url = v[3];
        }
    }
}
