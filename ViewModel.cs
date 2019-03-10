using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assertion
{
    class ViewModel:IViewModel
    {
        private Model _model;
        //public ClassModel clm;
        //public List<Student> li_stu;

        public ViewModel(ClassModel clm)
        {
            _model = new Model(clm);
            //li_stu = _model.listStud;

        }


        public List<Student> GetViewStudentList( SortBy sortBy)
        {
            switch (sortBy)
            {
                case SortBy.ByName:
                    return _model.listStud.OrderBy(o => o.Name).ToList();
                case SortBy.ByMark:
                    return _model.listStud.OrderBy(o => o.Mark).ToList();
                default:
                    return _model.listStud.OrderBy(o => o.Mark).ToList();
                   
            }
        }








    }
}
