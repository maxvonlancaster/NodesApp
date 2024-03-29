﻿using NodesApp.DAL.Entities;

namespace NodesApp.BLL.Services.Interfaces
{
    public interface INodeService : IService<Node>
    {
        public Node GetNodeByLink(string link);
    }
}
