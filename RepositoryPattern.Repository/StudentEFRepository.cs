using RepositoryPattern.Core.DomainObjecs;
using RepositoryPattern.EFSource;

namespace RepositoryPattern.Repository
{

    public class StudentEFRepository: EFRepositoryBase<SchoolContext, Student, int>, IStudentRepository
    {

    }
}
