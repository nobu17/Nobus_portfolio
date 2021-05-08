using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Models.Portofolios
{
    public class SkillItem
    {
        public SkillItem(string id, string name, List<SkillSubItem> subItems)
        {
            Id = id;
            Name = name;
            SubItems = subItems;
        }
        public string Id { get; private set; }

        public string Name { get; private set; }

        public List<SkillSubItem> SubItems { get; private set; }
    }

    public class SkillSubItem
    {
        public SkillSubItem(string id, string name, int proficiency)
        {
            Id = id;
            Name = name;
            Proficiency = proficiency;
        }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public int Proficiency { get; private set; }
    }
}
