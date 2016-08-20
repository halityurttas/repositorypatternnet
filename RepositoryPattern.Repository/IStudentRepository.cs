using RepositoryPattern.Core.DomainObjecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repository
{
    public interface IStudentRepository: IRepository<Student, int>
    {
    }
}
