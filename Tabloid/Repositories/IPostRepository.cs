﻿using System.Collections.Generic;
using Tabloid.Models;

namespace Tabloid.Repositories
{
    public interface IPostRepository
    {
        List<Post> GetAll();

        List<Post> GetUserPosts(int userProfileId);

        Post GetPostById(int PostId);

        void Add(Post post);

        void Update(Post post);

        void Delete(int postId);

    }
}