﻿using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;
using NodesApp.DAL.Exceptions;
using System.Linq.Expressions;

namespace NodesApp.BLL.Services
{
    public class ReactionService : IService<Reaction>
    {
        private readonly NodesConext _context;

        public ReactionService(NodesConext context)
        {
            _context = context;
        }

        public long Add(Reaction entity)
        {
            _context.Reactions.Add(entity);
            _context.SaveChanges();
            return entity.ReactionId;
        }

        public void Delete(long id)
        {
            var entity = _context.Reactions.Find(id);
            if (entity == null)
            {
                return;
            }
            _context.Reactions.Remove(entity);
            _context.SaveChanges();
        }

        public Reaction Get(long id)
        {
            var entity = _context.Reactions.Find(id);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(Comment));
            }
            return entity;
        }

        public IEnumerable<Reaction> Get(Expression<Func<Reaction, bool>> condition, int skip, int take)
        {
            return _context.Reactions
                .Where(condition)
                .Skip(skip)
                .Take(take)
                .ToList();
        }

        public int Update(IEnumerable<Reaction> entity)
        {
            _context.Reactions.UpdateRange(entity);
            return _context.SaveChanges();
        }
    }
}
