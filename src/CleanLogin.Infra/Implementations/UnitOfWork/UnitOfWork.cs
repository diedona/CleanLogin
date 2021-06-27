﻿using CleanLogin.Application.Interfaces.Repositories;
using CleanLogin.Application.Interfaces.UnitOfWork;
using CleanLogin.Infra.Database;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogin.Infra.Implementations.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CleanLoginContext _Context;
        private IDbContextTransaction _Transaction;

        public IUsuarioRepository UsuarioRepository { get; }

        public UnitOfWork(CleanLoginContext context, IUsuarioRepository usuarioRepository)
        {
            UsuarioRepository = usuarioRepository;
            _Context = context;
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void BeginTransaction()
        {
            _Transaction = _Context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _Transaction.Commit();
        }

        public void RollBackTransaction()
        {
            _Transaction.Rollback();
        }
    }
}
