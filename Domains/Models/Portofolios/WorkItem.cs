using System;
using System.Collections.Generic;

namespace Domains.Models.Portofolios
{
    public class WorkItem
    {
        public WorkItem(string id, string name, string subtitle, string description, string useLanguages, string useInfrastructures, string url, string sourceCodeUrl, string thumbNailUrl, List<string> imageUrls)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentException(nameof(id));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(nameof(name));
            if (string.IsNullOrWhiteSpace(subtitle)) throw new ArgumentException(nameof(subtitle));
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException(nameof(description));
            if (string.IsNullOrWhiteSpace(useLanguages)) throw new ArgumentException(nameof(useLanguages));
            if (string.IsNullOrWhiteSpace(useInfrastructures)) throw new ArgumentException(nameof(useInfrastructures));
            if (string.IsNullOrWhiteSpace(url)) throw new ArgumentException(nameof(url));
            if (string.IsNullOrWhiteSpace(sourceCodeUrl)) throw new ArgumentException(nameof(sourceCodeUrl));
            if (string.IsNullOrWhiteSpace(thumbNailUrl)) throw new ArgumentException(nameof(thumbNailUrl));
            if (imageUrls == null) throw new ArgumentException(nameof(imageUrls));

            Id = id;
            Name = name;
            SubTitle = subtitle;
            Description = description;
            UseLanguages = useLanguages;
            UseInfrastructures = useInfrastructures;
            Url = url;
            SourceCodeUrl = sourceCodeUrl;
            ThumbNailUrl = thumbNailUrl;
            ImageUrls = imageUrls;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }

        public string SubTitle { get; private set; }
        public string Description { get; private set; }

        public string UseLanguages { get; private set; }

        public string UseInfrastructures { get; private set; }

        public string Url { get; private set; }

        public string SourceCodeUrl { get; private set; }

        public string ThumbNailUrl { get; private set; }

        public List<string> ImageUrls { get; private set; }
    }
}