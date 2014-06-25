﻿using System;
using System.Collections.Generic;
using PlayMe.Data.NHibernate.Entities;

namespace PlayMe.Server.Interfaces
{
    public interface IRickRollService
    {
        Track RickRoll(Track track, string user);
        RickRoll AddRickRoll(PlayMeObject playMeObject);
        void RemoveRickRoll(Guid id);
        IEnumerable<RickRoll> GetAllRickRolls();
    }
}
