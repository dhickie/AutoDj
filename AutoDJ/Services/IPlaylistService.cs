﻿using AutoDJ.Models.Spotify;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDJ.Services
{
    public interface IPlaylistService
    {
        Task<List<Track>> GetBangerPlaylist();
        Task<List<Track>> GetFillerPlaylist();
    }
}