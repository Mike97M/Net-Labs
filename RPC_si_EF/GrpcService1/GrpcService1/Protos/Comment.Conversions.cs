using System;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace GrpcService1
{
    public partial class Comment
    {
        public static implicit operator Comment(global::PostComment.Comment src)
        {
            var value = new Comment {
                CommentId = src.CommentId,
                Text = src.Text,
                PostPostId = src.PostPostId,
                Post = (Post)src.Post,
            };
            return value;
        }


        public static implicit operator global::PostComment.Comment(Comment src)
        {
            var value = new global::PostComment.Comment {
                CommentId = src.CommentId,
                Text = src.Text,
                PostPostId = src.PostPostId,
                Post = (global::PostComment.Post)src.Post,
            };
            return value;
        }

    }
}

