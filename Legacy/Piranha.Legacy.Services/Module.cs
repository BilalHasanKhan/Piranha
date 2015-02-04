﻿/*
 * Copyright (c) 2015 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * http://github.com/piranhacms/piranha
 * 
 */

using System;
using System.Collections.Generic;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Routing;

[assembly: PreApplicationStartMethod(typeof(Piranha.Legacy.Services.Module), "Init")]

namespace Piranha.Legacy.Services
{
	public class Module
	{
		/// <summary>
		/// Initializes the service module.
		/// </summary>
		public static void Init() {
			// Register the REST services
			RouteTable.Routes.Add("REST_CATEGORY", new ServiceRoute("rest/category", new WebServiceHostFactory(), typeof(CategoryService)));
			RouteTable.Routes.Add("REST_SITEMAP", new ServiceRoute("rest/sitemap", new WebServiceHostFactory(), typeof(SitemapServices)));
			RouteTable.Routes.Add("REST_PAGE", new ServiceRoute("rest/page", new WebServiceHostFactory(), typeof(PageService)));
			RouteTable.Routes.Add("REST_POST", new ServiceRoute("rest/post", new WebServiceHostFactory(), typeof(PostService)));
			RouteTable.Routes.Add("REST_CONTENT", new ServiceRoute("rest/content", new WebServiceHostFactory(), typeof(ContentService)));
			RouteTable.Routes.Add("REST_PAGETEMPLATE", new ServiceRoute("rest/pagetemplate", new WebServiceHostFactory(), typeof(PageTemplateService)));
			RouteTable.Routes.Add("REST_POSTTEMPLATE", new ServiceRoute("rest/posttemplate", new WebServiceHostFactory(), typeof(PostTemplateService)));
			RouteTable.Routes.Add("REST_CHANGES", new ServiceRoute("rest/changes", new WebServiceHostFactory(), typeof(ChangeService)));
		}
	}
}
