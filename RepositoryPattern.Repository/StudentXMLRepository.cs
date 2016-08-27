using RepositoryPattern.Core.DomainObjecs;
using RepositoryPattern.XMLSource;

namespace RepositoryPattern.Repository
{
    public class StudentXMLRepository: XMLRepositoryBase<XMLSet<Student>, Student, int>, IStudentRepository
    {
        public StudentXMLRepository()
            :base("student.xml")
        {

        }
    }
}
