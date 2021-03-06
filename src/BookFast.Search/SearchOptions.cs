﻿using Microsoft.Extensions.Options;

namespace BookFast.Search
{
    public class SearchOptions : IOptions<SearchOptions>
    {
        public string AdminKey { get; set; }
        public string QueryKey { get; set; }
        public string ServiceName { get; set; }
        public string IndexName { get; set; }
        public SearchOptions Value => this;
    }
}