﻿using System.Collections.Generic;
using System.Linq;

namespace Cut
{
    public class ListUniqueService 
    {
        public List<int> GetUniqueElements(List<int> template)
        {
            return (from x in template select x).Distinct().ToList();
        }
    }
}