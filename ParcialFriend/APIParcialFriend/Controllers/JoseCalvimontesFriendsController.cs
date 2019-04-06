using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using APIParcialFriend.Models;

namespace APIParcialFriend.Controllers
{
    public class JoseCalvimontesFriendsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/JoseCalvimontesFriends
        public IQueryable<JoseCalvimontesFriend> GetJoseCalvimontesFriends()
        {
            return db.JoseCalvimontesFriends;
        }

        // GET: api/JoseCalvimontesFriends/5
        [ResponseType(typeof(JoseCalvimontesFriend))]
        public IHttpActionResult GetJoseCalvimontesFriend(int id)
        {
            JoseCalvimontesFriend joseCalvimontesFriend = db.JoseCalvimontesFriends.Find(id);
            if (joseCalvimontesFriend == null)
            {
                return NotFound();
            }

            return Ok(joseCalvimontesFriend);
        }

        // PUT: api/JoseCalvimontesFriends/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutJoseCalvimontesFriend(int id, JoseCalvimontesFriend joseCalvimontesFriend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != joseCalvimontesFriend.FriendId)
            {
                return BadRequest();
            }

            db.Entry(joseCalvimontesFriend).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JoseCalvimontesFriendExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/JoseCalvimontesFriends
        [ResponseType(typeof(JoseCalvimontesFriend))]
        public IHttpActionResult PostJoseCalvimontesFriend(JoseCalvimontesFriend joseCalvimontesFriend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.JoseCalvimontesFriends.Add(joseCalvimontesFriend);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = joseCalvimontesFriend.FriendId }, joseCalvimontesFriend);
        }

        // DELETE: api/JoseCalvimontesFriends/5
        [ResponseType(typeof(JoseCalvimontesFriend))]
        public IHttpActionResult DeleteJoseCalvimontesFriend(int id)
        {
            JoseCalvimontesFriend joseCalvimontesFriend = db.JoseCalvimontesFriends.Find(id);
            if (joseCalvimontesFriend == null)
            {
                return NotFound();
            }

            db.JoseCalvimontesFriends.Remove(joseCalvimontesFriend);
            db.SaveChanges();

            return Ok(joseCalvimontesFriend);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool JoseCalvimontesFriendExists(int id)
        {
            return db.JoseCalvimontesFriends.Count(e => e.FriendId == id) > 0;
        }
    }
}