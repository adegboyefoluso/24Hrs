using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hrs.Services
{
    public class CommentService
    {// this section will push and pull comments to the database

        private readonly Guid _commentId;

        public CommentService(Guid commentId)
        {
            _commentId = commentId;
        }

        public bool CreateComment(CommentService model)
        {
            var entity =
                new Comment()
                {
                    AuthorId = _commentId,
                    Text = model.
                }
        }
    }
}
