﻿using TorneioApp.Repositories;
using System;

namespace TorneioApp.Data
{
    public interface IUnitOfWork : IDisposable
    {
        ITorneioRepository Torneios { get; }
        IJogadorRepository Jogadores { get; }
        int Complete();
    }
}
