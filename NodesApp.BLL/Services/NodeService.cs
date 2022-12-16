﻿using Microsoft.EntityFrameworkCore;
using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;
using NodesApp.DAL.Exceptions;

namespace NodesApp.BLL.Services
{
    public class NodeService : INodeService
    {
        private readonly NodesConext _context;

        public NodeService(NodesConext context)
        {
            _context = context;
        }

        public long Add(Node entity)
        {
            _context.Nodes.Add(entity);
            _context.SaveChanges();
            return entity.NodeId;
        }

        public void Delete(long id)
        {
            var entity = _context.Nodes.Find(id);
            if (entity == null)
            {
                return;
            }
            _context.Nodes.Remove(entity);
            _context.SaveChanges();
        }

        public Node Get(long id)
        {
            var entity = _context.Nodes.Find(id);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(Comment));
            }
            return entity;
        }

        public IEnumerable<Node> Get(Predicate<Node> condition)
        {
            return _context.Nodes.Where(x => condition(x)).ToList();
        }

        public Node GetNodeByLink(string link)
        {
            throw new NotImplementedException();
        }

        public int Update(IEnumerable<Node> entity)
        {
            _context.Nodes.UpdateRange(entity);
            return _context.SaveChanges();
        }
    }
}
