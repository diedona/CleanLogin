using CleanLogin.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogin.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Begin();
        void Commit();
        void RollBack();

        IUsuarioRepository UsuarioRepository { get; }
    }
}
