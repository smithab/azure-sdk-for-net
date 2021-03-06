// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters for filtering, sorting, faceting, paging, and other search
    /// query behaviors.
    /// </summary>
    public partial class SearchParametersPayload
    {
        /// <summary>
        /// Initializes a new instance of the SearchParametersPayload class.
        /// </summary>
        public SearchParametersPayload() { }

        /// <summary>
        /// Initializes a new instance of the SearchParametersPayload class.
        /// </summary>
        public SearchParametersPayload(bool? count = default(bool?), IList<string> facets = default(IList<string>), string filter = default(string), string highlight = default(string), string highlightPostTag = default(string), string highlightPreTag = default(string), double? minimumCoverage = default(double?), string orderBy = default(string), QueryType? queryType = default(QueryType?), IList<string> scoringParameters = default(IList<string>), string scoringProfile = default(string), string search = default(string), string searchFields = default(string), SearchMode? searchMode = default(SearchMode?), string select = default(string), int? skip = default(int?), int? top = default(int?))
        {
            Count = count;
            Facets = facets;
            Filter = filter;
            Highlight = highlight;
            HighlightPostTag = highlightPostTag;
            HighlightPreTag = highlightPreTag;
            MinimumCoverage = minimumCoverage;
            OrderBy = orderBy;
            QueryType = queryType;
            ScoringParameters = scoringParameters;
            ScoringProfile = scoringProfile;
            Search = search;
            SearchFields = searchFields;
            SearchMode = searchMode;
            Select = select;
            Skip = skip;
            Top = top;
        }

        /// <summary>
        /// Gets or sets a value that specifies whether to fetch the total
        /// count of results. Default is false. Setting this value to true
        /// may have a performance impact. Note that the count returned is an
        /// approximation.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public bool? Count { get; set; }

        /// <summary>
        /// Gets or sets the list of facet expressions to apply to the search
        /// query. Each facet expression contains a field name, optionally
        /// followed by a comma-separated list of name:value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "facets")]
        public IList<string> Facets { get; set; }

        /// <summary>
        /// Gets or sets the OData $filter expression to apply to the search
        /// query.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets the comma-separated list of field names to use for
        /// hit highlights. Only searchable fields can be used for hit
        /// highlighting.
        /// </summary>
        [JsonProperty(PropertyName = "highlight")]
        public string Highlight { get; set; }

        /// <summary>
        /// Gets or sets a string tag that is appended to hit highlights. Must
        /// be set with HighlightPreTag. Default is &amp;lt;/em&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "highlightPostTag")]
        public string HighlightPostTag { get; set; }

        /// <summary>
        /// Gets or sets a string tag that is prepended to hit highlights.
        /// Must be set with HighlightPostTag. Default is &amp;lt;em&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "highlightPreTag")]
        public string HighlightPreTag { get; set; }

        /// <summary>
        /// Gets or sets a number between 0 and 100 indicating the percentage
        /// of the index that must be covered by a search query in order for
        /// the query to be reported as a success. This parameter can be
        /// useful for ensuring search availability even for services with
        /// only one replica. The default is 100.
        /// </summary>
        [JsonProperty(PropertyName = "minimumCoverage")]
        public double? MinimumCoverage { get; set; }

        /// <summary>
        /// Gets or sets the comma-separated list of OData $orderby
        /// expressions by which to sort the results. Each expression can be
        /// either a field name or a call to the geo.distance() function.
        /// Each expression can be followed by asc to indicate ascending, and
        /// desc to indicate descending. The default is ascending order. Ties
        /// will be broken by the match scores of documents. If no OrderBy is
        /// specified, the default sort order is descending by document match
        /// score. There can be at most 32 Orderby clauses.
        /// </summary>
        [JsonProperty(PropertyName = "orderby")]
        public string OrderBy { get; set; }

        /// <summary>
        /// Gets or sets gets or sets a value that specifies the syntax of the
        /// search query. The default is 'simple'. Use 'full' if your query
        /// uses the Lucene query syntax. Possible values include: 'simple',
        /// 'full'
        /// </summary>
        [JsonProperty(PropertyName = "queryType")]
        public QueryType? QueryType { get; set; }

        /// <summary>
        /// Gets or sets the list of parameter values to be used in scoring
        /// functions (for example, referencePointParameter) using the format
        /// name:value. For example, if the scoring profile defines a
        /// function with a parameter called 'mylocation' the parameter
        /// string would be "mylocation:-122.2,44.8"(without the quotes).
        /// </summary>
        [JsonProperty(PropertyName = "scoringParameters")]
        public IList<string> ScoringParameters { get; set; }

        /// <summary>
        /// Gets or sets the name of a scoring profile to evaluate match
        /// scores for matching documents in order to sort the results.
        /// </summary>
        [JsonProperty(PropertyName = "scoringProfile")]
        public string ScoringProfile { get; set; }

        /// <summary>
        /// Gets or sets a full-text search query expression; Use null or "*"
        /// to match all documents.
        /// </summary>
        [JsonProperty(PropertyName = "search")]
        public string Search { get; set; }

        /// <summary>
        /// Gets or sets the comma-separated list of field names to include in
        /// the full-text search.
        /// </summary>
        [JsonProperty(PropertyName = "searchFields")]
        public string SearchFields { get; set; }

        /// <summary>
        /// Gets or sets a value that specifies whether any or all of the
        /// search terms must be matched in order to count the document as a
        /// match. Possible values include: 'any', 'all'
        /// </summary>
        [JsonProperty(PropertyName = "searchMode")]
        public SearchMode? SearchMode { get; set; }

        /// <summary>
        /// Gets or sets the comma-separated list of fields to retrieve. If
        /// unspecified, all fields marked as retrievable in the schema are
        /// included.
        /// </summary>
        [JsonProperty(PropertyName = "select")]
        public string Select { get; set; }

        /// <summary>
        /// Gets or sets the number of search results to skip. This value
        /// cannot be greater than 100,000. If you need to scan documents in
        /// sequence, but cannot use Skip due to this limitation, consider
        /// using OrderBy on a totally-ordered key and Filter with a range
        /// query instead.
        /// </summary>
        [JsonProperty(PropertyName = "skip")]
        public int? Skip { get; set; }

        /// <summary>
        /// Gets or sets the number of search results to retrieve. This can be
        /// used in conjunction with Skip to implement client-side paging of
        /// search results. If results are truncated due to server-side
        /// paging, the response will include a continuation token that can
        /// be passed to ContinueSearch to retrieve the next page of results.
        /// See DocumentSearchResponse.ContinuationToken for more information.
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public int? Top { get; set; }

    }
}
