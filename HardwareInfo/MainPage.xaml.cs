using HardwareInfo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HardwareInfo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // reference to collection in SoundManager.cs
        private ObservableCollection<Sound> Sounds;

        List<string> _partsDesc;

        public MainPage()
        {
            this.InitializeComponent();
            setupDescribtions();
            pvtTitle.SelectedIndex = 0;

            // Populate the sounds
            Sounds = new ObservableCollection<Sound>();
            SoundManager.getAllSounds(Sounds);
        }

        // Setup the text to be displayed on each page
        // Add all the describtions to a list to be outputted
        private void setupDescribtions()
        {
            if (_partsDesc != null)
            {
                return;
            }
            _partsDesc = new List<string>();

            // Add each describtion
            // About info
            _partsDesc.Add("Computers are everywhere wheter it be a desktop, laptop, tablet or phone. All come in different shapes, sizes and colours" +
                " but at the end of the day they are all the same in terms of what makes them work. These devices will work perfectly and uninterupted" +
                " unitl the hardware starts to fail or get older. When they start failing the whole system can slow down and cause serious performance" +
                " drops and danger of data being lost or being corrupted. These failures can be costly due to repair costs to replace parts and for" +
                " someone to diagnose and fix the problem. The aim of this application is to help you understand what the hardware in your machine" +
                " do and help to diagnose your own problems and help you to resolve them with a bit of research online.");

            // Processor info
            _partsDesc.Add("The processor is the brain of your computer and handles all processes and applications. Depending on the speed of your processor" +
                " these applications will run faster or slower. More processing cores affect performance in apps and games. Lets look at Intel Processors." +
                " i3's are entry levels intel chips that have 2 cores. Most are good for general gaming however, they're not great for running demanding programmes for editing or 3D production." +
                " i5's are a step up from the i3 with 2-4 cores. They are great for gaming and will handle most high-end games on the highest settings." +
                " The extra cores and high cache helps in running very demanding programmes for editing or 3D production." +
                " i7's are the big-daddys in the intel family. With anywhere from 4-8 cores these chips will easily handle any game you throw at it and are ideal for demanding 3D programmes." +
                " Intel processors can be identified by the generation they where built in. The latest being the Skylake processors. Each generation tunes" +
                " the processors tp perform better and handle more demanding programs.");

            // Motherboard Info
            _partsDesc.Add("The motherboard lets all your components communicate to eachother. Its a large circut board that everything plugs into." +
                " It has a socket for your processor, PCI slots for expansion cards like graphics, sound and network cards, sata ports for hard drives as well" +
                " as USB connecters and the power switch. Intel and AMD processor need to put in a motherboard to work, but they also need different motherboards." +
                " Intel uses LGA sockets for their cpus. Intel processors don't have pins that stick into the socket any more," +
                " they use sensitive areas that touch the socket at different points. AMD use their own socket and still have pins on their processors. They are much more fragile than the intel processors," +
                " and if they move or bend it could ruin the chip. The pins plug into holes in the socket. All motherboards have a variety of PCI slots from 4x to 16x express slots. Each slot slot takes a different component," +
                " mostly graphics cards and sound cards. All motherboards also have RAM slots where you insert your sticks of RAM. The more slots you have, the more RAM you" +
                " can have in your system.");

            // Graphics Info
            _partsDesc.Add("There are a few different methods of displaying the computer to your monitor. Most Mothernoards have on board graphics which" +
                " usually do the job. If your a gamer or need good graphics for modeling or editing, you may want better looking graphics and will need a graphics" +
                " card. Again like processors, different cards will give you different performance in graphics. Games benefit greatly from more powerful" +
                " graphics adn will make games look better. The more powerful the card, the better the graphics and physical effect. Lots of different company's make Graphics/Video cards. Alot of them use Nvidia's Geforce GTX technology. The cards with" +
                " this technology built in are usually the best performing cards on the market. AMD make the Radeon series of graphics cards. Graphics cards use fast on board DDR5 memory to optimize performance." +
                " Intel have there own on board graphics system for laptops. The idea is to keep the resolution high while" +
                " saving space by soldering the graphics chip onto the motherboard. They're compromising performance in games but there's no need for expensive chips on consumer grade products.");

            // RAM info
            _partsDesc.Add("Random Access Memory is quick temporary memory that keeps your operating system snappy with the more RAM you have in the system." +
                " Games and applications benefit from more RAM as the can hold more temporary actions for longer depending on how much RAM you have. DDR3 is the most common RAM in systems. The effectiveness depends on its clock speed, the most common speeds being 1333" +
                " megahertz or 1600 megahertz. The cost of DDR3 memory has fallen due to the release of quicker DDR4 memory in recent years which delivers quicker" +
                " performing memory clocked at a higher speed.");

            // Storage Info
            _partsDesc.Add("Hard Drives will hold all your system files, pictures, muscic and games. Hard Drives use a mechanical arm that moves over a spinning disc. This arm moves so fast you can hardly see it through the" +
            " human eye. The arm moves over 20 time in .25 of a second to find the data requested. These drives come in high capacity and are optimal for storing games, pictures, music and other static files." +
            " The down side of these drives is the failure rate caused by the moving arm breaking or the hard drive falling and damaged being caused." +
            " The better option is to buy an SSD which stands for Solid State Drive and are much faster than traditional hard drives and are optimal for installing" +
            " Operating Systems and demanding programs like Photoshop or Visual Studio that will benefit from the fast flash memory. There's no spinning disc which makes them faster and less failure prone" +
            " but also come at a higher premium due the cost of the production of the flash memory. I would highly recommned having one of each for optimal performance. ");

            // Power Info
            _partsDesc.Add("All your components will need power to run. This is where your power supply is needed. A power supply does exactly what you think. It supplies" +
                "power to the componets. The supply is connected to the power outlet on your wall and cables run to different comonents with different connectors." +
                "Depending on how much power your parts need, you'll need more wattage from your power supply.");

            // Errors Info
            _partsDesc.Add("As great as all these compnents can be, they become slow or useless if the break or expierence errors or bottlenecks that will slow them down." +
                " If you are having problems with your system, one of the vest ways to find out whats wrong is through a series of beeps that come from a small speaker that" +
                " comes with a motherboard. Errors can be indentified by different beeps.");

            int i;
            TextBlock curr;
            // Loop through the list of describtions to find the one needed
            for (i = 0; i <= 8; i++)
            {
                curr = (TextBlock)pvtTitle.FindName("tblAbout" + i.ToString());
                if (curr != null)
                {
                    curr.Text = _partsDesc[i];
                }
            } // end for 
        } // endSetupDescribtions

        private void Single_Beep_Button_Click(object sender, RoutedEventArgs e)
        {
            singlebeep.Play();
        }

        private void Two_Beep_Button_Click(object sender, RoutedEventArgs e)
        {
            twobeep.Play();
        }

        private void Triple_Beep_Button_Click(object sender, RoutedEventArgs e)
        {
            triplebeep.Play();
        }

        private void Triple_Long_Beep_Button_Click(object sender, RoutedEventArgs e)
        {
            triplelongbeep.Play();
        }

        private void One_One_Beep_Button_Click(object sender, RoutedEventArgs e)
        {
            onelongoneshort.Play();
        }

        private void One_Two_Button_Click(object sender, RoutedEventArgs e)
        {
            onelongtwoshort.Play();
        }
    }
}