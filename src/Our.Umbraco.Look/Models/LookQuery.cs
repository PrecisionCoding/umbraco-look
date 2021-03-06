﻿namespace Our.Umbraco.Look.Models
{
    /// <summary>
    /// Object used to specify a search query
    /// </summary>
    public class LookQuery
    {
        /// <summary>
        /// Search text, and configuration options for highlighting (if required)
        /// </summary>
        public TextQuery TextQuery { get; set; } = new TextQuery();

        /// <summary>
        /// Search tags, configuring collections that are 'required', and/or 'grouped ors'
        /// </summary>
        public TagQuery TagQuery { get; set; } = new TagQuery();

        /// <summary>
        /// Specify (optional) docType aliases to include, or node ids to exclude
        /// </summary>
        public NodeQuery NodeQuery { get; set; } = new NodeQuery();

        /// <summary>
        /// specifify criteria to perform a location distance query
        /// </summary>
        public LocationQuery LocationQuery { get; set; } = new LocationQuery();

        /// <summary>
        /// Specify the field to sort on
        /// </summary>
        public SortOn SortOn { get; set; } = SortOn.Score;

        /// <summary>
        /// Constructor
        /// </summary>
        public LookQuery()
        {
        }

        //public SearchQuery(string text)
        //{
        //	this.TextQuery.Text = text;
        //}

        //public SearchQuery(string text, string nodeType)
        //{
        //	this.TextQuery.Text = text;
        //	this.NodeQuery.NodeTypes.Add(nodeType);
        //}

        //public SearchQuery(string[] tags)
        //{
        //	this.TagQuery.AllTags.AddRange(tags);
        //}

        //public SearchQuery(string[] tags, string nodeType)
        //{
        //	this.TagQuery.AllTags.AddRange(tags);
        //	this.NodeQuery.NodeTypes.Add(nodeType);
        //}

        //public SearchQuery(string nodeType, SortOn sortOn)
        //{
        //	this.NodeQuery.NodeTypes.Add(nodeType);
        //	this.SortOn = sortOn;
        //}
    }
}
