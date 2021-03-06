﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TournamentMaker.Models;

namespace TournamentMaker.UI.Admin.Interfaces {
    public interface IPlayerLookupDataService {
        Task<IEnumerable<LookupItem>> GetFriendLookupAsync();
    }
}