﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using vuvansang_2080600626.DTOs;
using vuvansang_2080600626.Models;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace vuvansang_2080600626.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;
        
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if(_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
            {
                return BadRequest("Following already exists!");
            }
            var following = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FolloweeId
            };
            _dbContext.Followings.Add(following);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}