using PostData.Entities;
namespace Laboratorium_3___PostApp.Models
{
    public class PostMapper
    {
        public static Post FromEntity(PostEntity entity)
        {
            return new Post()
            {
                Id = entity.Id,
                Content = entity.Content,
                Autor = entity.Autor,
                PostDate = entity.PostDate,
                Tag = entity.Tag,
                Comment = entity.Comment,
            };
        }

        public static PostEntity ToEntity(Post model)
        {
            return new PostEntity()
            {
                Id = model.Id,
                Content = model.Content,
                Autor = model.Autor,
                PostDate = model.PostDate,
                Tag = model.Tag,
                Comment = model.Comment,
            };
        }
    }
}
