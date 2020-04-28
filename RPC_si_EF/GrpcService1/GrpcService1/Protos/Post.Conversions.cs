using System;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace GrpcService1
{
    public partial class Post
    {
        public static implicit operator Post(global::PostComment.Post src)
        {
            var converted = new Post {
                PostId = src.PostId,
                Description = src.Description,
                Domain = src.Domain,
                Date = Timestamp.FromDateTime(src.Date),
            };
            
            converted.Commets.AddRange(src.Commets.Select(x => (Comment)x));
            
            return converted;
        }


        public static implicit operator global::PostComment.Post(Post src)
        {
            var value = new global::PostComment.Post {
                PostId = src.PostId,
                Description = src.Description,
                Domain = src.Domain,
                Date = src.Date.ToDateTime(),
                Commets = src.Commets.Select(x => (global::PostComment.Comment)x).ToList(),
            };
            return value;
        }

    }
}

