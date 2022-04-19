using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class Tender
    {
        public String title { get; set; }
        public String description { get; set; }    
        
        public String longDescription { get; set; }
        public String category { get; set; }

        public String tenderProcedure { get; set; }

        public String procurementTechnique { get; set; }

        public String bidInvitationDate { get; set; }

        public String clarificationDeadline { get; set; }

        public String submissionDeadline { get; set; }

        public String contractNoticeDate { get; set; }

        public String procurementPlan { get; set; }

        public List<String> planItems { get; set; }


    }
}
