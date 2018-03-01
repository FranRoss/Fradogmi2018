using System;
using System.Collections.Generic;

namespace Fradogmi2018.Entities
{
    public class OutputManagerDataList
    {
        public List<OutputManagerData> output { get; set; }
        public OutputManagerDataList(List<OutputManagerData> output)
        {
            this.output = output;
        }
    }
}
