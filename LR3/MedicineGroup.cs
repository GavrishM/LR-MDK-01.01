using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class MedicineGroup
    {
        private string groupName_;
        private List<Medicine> medicines_;
        public string GroupName
        { 
            get { return groupName_; }
            set { groupName_ = value; } 
        }
        public List<Medicine> Medicines
        {
            get { return medicines_; }
            set { medicines_.AddRange(value); }
        }
        public MedicineGroup(string name, List<Medicine> medicines)
        {
            groupName_ = name;
            medicines_ = medicines;
        }
    }
}
