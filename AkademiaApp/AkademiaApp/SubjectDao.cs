using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaApp
{
    interface SubjectDao
    {
        void addSubject(Subject subject);
        void modifySubject(Subject subject);
        void deleteSubject(Subject subject);
        List<Subject> getAllSubject();
        Subject getSubjectById(int id);
        Subject getSubjectByString();
        List<SubjectMark> getSubjectWithMark(int id);
    }
}
