using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy_CRUD
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
