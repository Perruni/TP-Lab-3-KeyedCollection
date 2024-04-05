﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab_3
{
    public class College_System : KeyedCollection<int, Student>
    {
        
        protected override int GetKeyForItem(Student student)
        {
            return student.Legacy;
        }

        public void ReplaceStudent(Student student)
        {

            if (Contains(student.Legacy))
            {

                int index = IndexOf(this[student.Legacy]);

                base.SetItem(index, student);
            }
        }

    }
}

