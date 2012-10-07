﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcSiteMapProvider.Extensibility;

namespace MvcMusicStore.Code
{
    /// <summary>
    /// Only displays nodes when a user is not authenticated.
    /// </summary>
    public class NonAuthenticatedVisibilityProvider
        : ISiteMapNodeVisibilityProvider
    {
        #region ISiteMapNodeVisibilityProvider Members

        /// <summary>
        /// Determines whether the node is visible.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="context">The context.</param>
        /// <param name="sourceMetadata">The source metadata.</param>
        /// <returns>
        /// 	<c>true</c> if the specified node is visible; otherwise, <c>false</c>.
        /// </returns>
        public bool IsVisible(SiteMapNode node, HttpContext context, IDictionary<string, object> sourceMetadata)
        {
            return !HttpContext.Current.Request.IsAuthenticated;
        }

        #endregion
    }
}