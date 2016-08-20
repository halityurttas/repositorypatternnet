using RepositoryPattern.Core.DomainObjecs;
using RepositoryPattern.EFSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repository
{

    public class StudentEFRepository: EFRepositoryBase<SchoolContext, Student, int>, IStudentRepository
    {

    }
}
