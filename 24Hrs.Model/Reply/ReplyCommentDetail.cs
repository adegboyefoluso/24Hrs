using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hrs.Model.Reply
{
    public class ReplyCommentDetail
    {
        public int CommentId {get;set;}
        public string Text { get; set; }
        public List<ReplyDetail> Replies { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
