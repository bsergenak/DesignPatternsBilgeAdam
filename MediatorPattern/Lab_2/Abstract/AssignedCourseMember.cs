using MediatorPattern.Lab_2.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab_2.Abstract
{
    public abstract class AssignedCourseMember
    {
        private CoreMediator _coreMediator;

        public AssignedCourseMember(CoreMediator coreMediator)
        {
            _coreMediator = coreMediator;
        }
    }
}
