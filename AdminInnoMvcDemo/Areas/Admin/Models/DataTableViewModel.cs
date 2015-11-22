using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminInnoMvcDemo.Areas.Admin.Models
{
    public class DataTableViewModel
    {

        public string RenderingEngine { get; set; }

        public string Browser { get; set; }


        public string Platform { get; set; }


        public string EngineVersion { get; set; }


        public string CSSGrade { get; set; }

        public List<DataTableViewModel> GetList()
        {
            return new List<DataTableViewModel>()
            {
                new DataTableViewModel { RenderingEngine="Trident",  Browser = "InternetExplorer 4.0", Platform ="Win 95+",  EngineVersion = "4", CSSGrade = "X"},
                new DataTableViewModel { RenderingEngine="Trident",  Browser = "InternetExplorer 4.0", Platform ="Win 95+",  EngineVersion = "4", CSSGrade = "X"},
                new DataTableViewModel { RenderingEngine="Trident",  Browser = "InternetExplorer 4.0", Platform ="Win 95+",  EngineVersion = "4", CSSGrade = "X"},
                new DataTableViewModel { RenderingEngine="Trident",  Browser = "InternetExplorer 4.0", Platform ="Win 95+",  EngineVersion = "4", CSSGrade = "X"},
                new DataTableViewModel { RenderingEngine="Trident",  Browser = "InternetExplorer 4.0", Platform ="Win 95+",  EngineVersion = "4", CSSGrade = "X"},
                new DataTableViewModel { RenderingEngine="Trident",  Browser = "InternetExplorer 4.0", Platform ="Win 95+",  EngineVersion = "4", CSSGrade = "X"},
                new DataTableViewModel { RenderingEngine="Trident",  Browser = "InternetExplorer 4.0", Platform ="Win 95+",  EngineVersion = "4", CSSGrade = "X"},
                new DataTableViewModel { RenderingEngine="Trident",  Browser = "InternetExplorer 4.0", Platform ="Win 95+",  EngineVersion = "4", CSSGrade = "X"},
                new DataTableViewModel { RenderingEngine="Trident",  Browser = "InternetExplorer 4.0", Platform ="Win 95+",  EngineVersion = "4", CSSGrade = "X"},
                new DataTableViewModel { RenderingEngine="Trident",  Browser = "InternetExplorer 4.0", Platform ="Win 95+",  EngineVersion = "4", CSSGrade = "X"},
                new DataTableViewModel { RenderingEngine="Trident",  Browser = "InternetExplorer 4.0", Platform ="Win 95+",  EngineVersion = "4", CSSGrade = "X"},
                new DataTableViewModel { RenderingEngine="Trident",  Browser = "InternetExplorer 4.0", Platform ="Win 95+",  EngineVersion = "4", CSSGrade = "X"},
            };
        }
    }
}