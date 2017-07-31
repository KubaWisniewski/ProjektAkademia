using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaApp
{
    interface MarkDao
    {
        void addMark(Mark mark);
        void modifyMark(Mark mark);
        void deleteMark(Mark mark);
        List<Mark> getAllMarks();
        Mark getMarkById(int id);
        List<Mark> getMarksStudent(int id);
    }
}
