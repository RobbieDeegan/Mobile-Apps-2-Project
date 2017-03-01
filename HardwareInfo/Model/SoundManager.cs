using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareInfo.Model
{
    public class SoundManager
    {
        public static void getAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = getSounds();

            sounds.Clear(); // Remove any old stuff

            // lambda expression to loop through all the sounds added
            // and add them the observable collection of sounds
            allSounds.ForEach(p => sounds.Add(p)); 
        }


        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();

            // Fill the list with the sounds needed
            sounds.Add(new Sound("singlebeep"));
            sounds.Add(new Sound("1long1short"));
            sounds.Add(new Sound("1long2short"));
            sounds.Add(new Sound("triplebeep"));
            sounds.Add(new Sound("twobeep"));
            sounds.Add(new Sound("tripelongbeep"));

            return sounds;
        }

    }
}
