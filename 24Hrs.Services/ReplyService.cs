using _24Hrs.Data;
using _24Hrs.Model.Reply;
using _24HrsProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hrs.Services
{
    public class ReplyService
    {
        private readonly Guid _UserId;
        public ReplyService(Guid userId)
        {
            _UserId = userId;
        }

        public bool  CreateRepy(ReplyCreate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var comment = ctx
                                    .Comments
                                    .Find(model.CommentId);
                if(comment != null)
                {
                    var entity = new Reply()
                    {
                        Text = model.Text,
                        CommentId = model.CommentId,
                        CreatedUTc = DateTime.Now,

                    };
                    ctx.Replies.Add(entity);
                    return ctx.SaveChanges() == 1;
                }
                return false;
            }
        }
       

       
    }
}
