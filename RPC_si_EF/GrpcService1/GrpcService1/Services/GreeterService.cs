using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;


namespace GrpcService1
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }



        public override Task<AddCommentResponse> AddComment(AddCommentRequest request, ServerCallContext context)
        {
            try
            {
                PostComment.Comment comment = new PostComment.Comment();
                var returnValue = comment.AddComment((global::PostComment.Comment)request.Comment);
                var response = new AddCommentResponse { Value = returnValue };
                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error invoking AddComment");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        public override Task<UpdateCommentResponse> UpdateComment(UpdateCommentRequest request, ServerCallContext context)
        {
            try
            {
                PostComment.Comment comment = new PostComment.Comment();
                var returnValue = comment.UpdateComment((global::PostComment.Comment)request.NewComment);
                var response = new UpdateCommentResponse { Value = (Comment)returnValue };
                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error invoking UpdateComment");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        public override Task<GetCommentByIdResponse> GetCommentById(GetCommentByIdRequest request, ServerCallContext context)
        {
            try
            {
                PostComment.Comment comment = new PostComment.Comment();
                var returnValue = comment.GetCommentById(request.Id);
                var response = new GetCommentByIdResponse { Value = (Comment)returnValue };
                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error invoking GetCommentById");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }
        public override Task<AddPostResponse> AddPost(AddPostRequest request, ServerCallContext context)
        {
            try
            {
                var post = new PostComment.Post();
                var returnValue = post.AddPost((global::PostComment.Post)request.Post);
                var response = new AddPostResponse { Value = returnValue };
                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error invoking AddPost");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        public override Task<UpdatePostResponse> UpdatePost(UpdatePostRequest request, ServerCallContext context)
        {
            try
            {
                var post = new PostComment.Post();
                var returnValue = post.UpdatePost((global::PostComment.Post)request.Post);
                var response = new UpdatePostResponse { Value = (Post)returnValue };
                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error invoking UpdatePost");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        public override Task<DeletePostResponse> DeletePost(DeletePostRequest request, ServerCallContext context)
        {
            try
            {
                var post = new PostComment.Post();
                var returnValue = post.DeletePost(request.Id);
                var response = new DeletePostResponse { Value = returnValue };
                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error invoking DeletePost");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        public override Task<GetPostByIdResponse> GetPostById(GetPostByIdRequest request, ServerCallContext context)
        {
            try
            {
                var post = new PostComment.Post();
                var returnValue = post.GetPostById(request.Id);
                var response = new GetPostByIdResponse { Value = (Post)returnValue };
                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error invoking GetPostById");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }

        public override Task<GetPostsResponse> GetPosts(GetPostsRequest request, ServerCallContext context)
        {
            try
            {
                var post = new PostComment.Post();
                var returnValue = post.GetAllPosts();
                var response = new GetPostsResponse();
                response.Values.AddRange(returnValue.Select(x => (Post)x));
                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error invoking GetPosts");
                throw new RpcException(new Status(StatusCode.Internal, ex.Message));
            }
        }
    }
}
