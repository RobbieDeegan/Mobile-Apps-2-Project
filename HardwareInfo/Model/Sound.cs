using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Adapted from a youtube tutorial by at https://www.youtube.com/watch?v=SbgHIvrD11U

namespace HardwareInfo.Model
{
    public class Sound
    {
        public String Name { get; set; }
        public String AudioFile { get; set; }


        // Constructer used to get the location of the sounds
        public Sound(String name)
        {
            Name = name;
            AudioFile = String.Format("/Assets/Sounds/{0}.wav", name); // Used to get the location using the name
        }

    }
}
