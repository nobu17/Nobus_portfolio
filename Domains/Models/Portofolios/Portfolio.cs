﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Models.Portofolios
{
    public class Portfolio : IEquatable<Portfolio>
    {
        public Portfolio(string id, List<WorkItem> workItems)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentException(nameof(id));
            if (workItems == null) throw new ArgumentException(nameof(workItems));

            Id = id;
            WorkItems = workItems;
        }

        public string Id { get; private set; }

        public List<WorkItem> WorkItems { get; private set; }

        public bool Equals(Portfolio other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Portfolio)obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }
    }
}
