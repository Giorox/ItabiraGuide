using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossoApp
{

    public class FrontScreenEstudanteMenuItem
    {
        public FrontScreenEstudanteMenuItem()
        {
            TargetType = typeof(FrontScreenEstudanteDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }

        public Type TargetType { get; set; }
    }
}