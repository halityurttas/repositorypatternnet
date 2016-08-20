using RepositoryPattern.Core.DomainObjecs;
using RepositoryPattern.XMLSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
