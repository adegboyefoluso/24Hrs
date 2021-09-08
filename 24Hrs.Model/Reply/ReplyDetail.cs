using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hrs.Model.Reply
{
    public class ReplyDetail
    {
        public int ReplyId { get; set; }
        public string Text { get; set; }
        
        public DateTimeOffset CreatedUTc { get; set; }
        public DateTimeOffset ModifiedUTc { get; set; }
    }
}
