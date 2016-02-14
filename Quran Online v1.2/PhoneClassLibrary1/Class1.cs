using Microsoft.Phone.BackgroundAudio;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PhoneClassLibrary1
{
    public static class Class1
    {
        // What's the current track?
       public static int currentTrackNumber ;

        // A playlist made up of AudioTrack items.
       public static List<AudioTrack> _playList;
        static Class1()
    {
        _playList = new List<AudioTrack>();
        currentTrackNumber = 0;
    }
    }
}
