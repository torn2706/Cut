﻿using System.Collections.Generic;
using System.Linq;

namespace ComboGenerationFeature
{
    public class ListUniqueService : IListUniqueService
    {
        public List<int> GetUniqueElements(List<int> template)
        {
            return (from x in template select x).Distinct().ToList();
        }
    }
}