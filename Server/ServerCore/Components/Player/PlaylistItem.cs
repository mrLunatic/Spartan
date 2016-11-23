﻿using System.Diagnostics;
using NetAudioPlayer.Common.Data;

namespace NetAudioPlayer.ServerCore.Components.Player
{
    [DebuggerDisplay("{Track}. Played: {IsPlayed}")]
    public class PlaylistItem
    {
        public Track Track { get; }

        public int? HistoryIndex { get; set; }

        public bool IsPlayed => HistoryIndex.HasValue;        

        public PlaylistItem(Track track)
        {
            Track = track;
        }
    }
}