using System;
using System.Collections.Generic;
using System.Text;

namespace LR_5
{
 interface IActionsWithStudents
    {
        bool PositiveAverageMark();
        void TransferFaculty(Faculty newFaculty);
        void TransferSpeciality(int newSpeciality);
    }
}
