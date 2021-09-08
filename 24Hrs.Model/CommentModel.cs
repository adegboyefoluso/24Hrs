using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hrs.Model
{
    public class CommentModel
    {

<<<<<<< HEAD:24Hrs.Model/CommentModel.cs
=======
        public int Id { get; set; }
        public string Text { get; set; }
        public Guid AuthorId { get; set; }
        public virtual List<Reply> Replies { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
>>>>>>> develop:24Hrs.Data/Comment.cs
    }
}
