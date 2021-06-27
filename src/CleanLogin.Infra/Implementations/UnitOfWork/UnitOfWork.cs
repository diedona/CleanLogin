using CleanLogin.Application.Interfaces.Repositories;
using CleanLogin.Application.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogin.Infra.Implementations.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUsuarioRepository UsuarioRepository { get; }

        public UnitOfWork(IUsuarioRepository usuarioRepository)
        {
            UsuarioRepository = usuarioRepository;
        }

        public void Begin()
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }
    }
}
