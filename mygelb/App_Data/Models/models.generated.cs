//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.2.93
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly, System.Reflection.AssemblyVersion("0.0.0.2")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Homepage</summary>
	[PublishedContentModel("homepage")]
	public partial class Homepage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "homepage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Homepage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Homepage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// HomePageSlideShow
		///</summary>
		[ImplementPropertyType("homePageSlideShow")]
		public object HomePageSlideShow
		{
			get { return this.GetPropertyValue("homePageSlideShow"); }
		}
	}

	/// <summary>About</summary>
	[PublishedContentModel("about")]
	public partial class About : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "about";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public About(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<About, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Contact</summary>
	[PublishedContentModel("contact")]
	public partial class Contact : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contact";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Contact(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Contact, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Portfolio</summary>
	[PublishedContentModel("portfolio")]
	public partial class Portfolio : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "portfolio";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Portfolio(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Portfolio, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Subpage</summary>
	[PublishedContentModel("subpage")]
	public partial class Subpage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "subpage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Subpage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Subpage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// HomePageSlideShow
		///</summary>
		[ImplementPropertyType("homePageSlideShow")]
		public string HomePageSlideShow
		{
			get { return this.GetPropertyValue<string>("homePageSlideShow"); }
		}
	}

	/// <summary>SmartBlog Master</summary>
	[PublishedContentModel("SmartBlogMaster")]
	public partial class SmartBlogMaster : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "SmartBlogMaster";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SmartBlogMaster(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SmartBlogMaster, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Disable Sub Navigation: Disables sub-navigation from this page in the menu.
		///</summary>
		[ImplementPropertyType("disableSubNavigation")]
		public bool DisableSubNavigation
		{
			get { return this.GetPropertyValue<bool>("disableSubNavigation"); }
		}

		///<summary>
		/// External Redirect: Redirect this page to an external URL.
		///</summary>
		[ImplementPropertyType("umbracoExternalUrl")]
		public string UmbracoExternalUrl
		{
			get { return this.GetPropertyValue<string>("umbracoExternalUrl"); }
		}

		///<summary>
		/// Hide from menu: Use this property if you want to hide this page from every menu.
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}

		///<summary>
		/// Internal Redirect: Pick a node you want to redirect this page to an internal page.
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public object UmbracoRedirect
		{
			get { return this.GetPropertyValue("umbracoRedirect"); }
		}

		///<summary>
		/// URL Alias: Use this to give a node multiple URLs.
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return this.GetPropertyValue<string>("umbracoUrlAlias"); }
		}

		///<summary>
		/// URL Name: If you want to change the URL of the node without changing the node name fill this in.
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return this.GetPropertyValue<string>("umbracoUrlName"); }
		}
	}

	/// <summary>Page</summary>
	[PublishedContentModel("SmartBlogPage")]
	public partial class SmartBlogPage : SmartBlogMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "SmartBlogPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SmartBlogPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SmartBlogPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description: The text to place within the page description tags.
		///</summary>
		[ImplementPropertyType("smartBlogDescription")]
		public string SmartBlogDescription
		{
			get { return this.GetPropertyValue<string>("smartBlogDescription"); }
		}

		///<summary>
		/// Keywords: The keywords to place within the page keywords tag.
		///</summary>
		[ImplementPropertyType("smartBlogSeoKeywords")]
		public string SmartBlogSeoKeywords
		{
			get { return this.GetPropertyValue<string>("smartBlogSeoKeywords"); }
		}

		///<summary>
		/// Title: The text to display within the page title tags.
		///</summary>
		[ImplementPropertyType("smartBlogSeoTitle")]
		public string SmartBlogSeoTitle
		{
			get { return this.GetPropertyValue<string>("smartBlogSeoTitle"); }
		}

		///<summary>
		/// Summary: The page summary text.
		///</summary>
		[ImplementPropertyType("smartBlogSummary")]
		public string SmartBlogSummary
		{
			get { return this.GetPropertyValue<string>("smartBlogSummary"); }
		}

		///<summary>
		/// Title: The page title text.
		///</summary>
		[ImplementPropertyType("smartBlogTitle")]
		public string SmartBlogTitle
		{
			get { return this.GetPropertyValue<string>("smartBlogTitle"); }
		}
	}

	/// <summary>Article</summary>
	[PublishedContentModel("SmartBlogArticle")]
	public partial class SmartBlogArticle : SmartBlogPage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "SmartBlogArticle";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SmartBlogArticle(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SmartBlogArticle, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Body: The main body text to display on this post.
		///</summary>
		[ImplementPropertyType("smartBlogBody")]
		public IHtmlString SmartBlogBody
		{
			get { return this.GetPropertyValue<IHtmlString>("smartBlogBody"); }
		}
	}

	/// <summary>Comment</summary>
	[PublishedContentModel("SmartBlogComment")]
	public partial class SmartBlogComment : SmartBlogMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "SmartBlogComment";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SmartBlogComment(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SmartBlogComment, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Comment: The comment text.
		///</summary>
		[ImplementPropertyType("smartBlogComment1")]
		public string SmartBlogComment1
		{
			get { return this.GetPropertyValue<string>("smartBlogComment1"); }
		}

		///<summary>
		/// Email: The email address of the person who made the comment.
		///</summary>
		[ImplementPropertyType("smartBlogEmail")]
		public string SmartBlogEmail
		{
			get { return this.GetPropertyValue<string>("smartBlogEmail"); }
		}

		///<summary>
		/// Name: The name of the person who posted the comment.
		///</summary>
		[ImplementPropertyType("smartBlogName")]
		public string SmartBlogName
		{
			get { return this.GetPropertyValue<string>("smartBlogName"); }
		}

		///<summary>
		/// Website: The website address of the person who made this comment.
		///</summary>
		[ImplementPropertyType("smartBlogWebsite")]
		public string SmartBlogWebsite
		{
			get { return this.GetPropertyValue<string>("smartBlogWebsite"); }
		}
	}

	/// <summary>Date</summary>
	[PublishedContentModel("SmartBlogDate")]
	public partial class SmartBlogDate : SmartBlogMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "SmartBlogDate";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SmartBlogDate(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SmartBlogDate, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("SmartBlogFolder")]
	public partial class SmartBlogFolder : SmartBlogMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "SmartBlogFolder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SmartBlogFolder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SmartBlogFolder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Month</summary>
	[PublishedContentModel("SmartBlogMonth")]
	public partial class SmartBlogMonth : SmartBlogDate
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "SmartBlogMonth";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SmartBlogMonth(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SmartBlogMonth, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Post</summary>
	[PublishedContentModel("SmartBlogPost")]
	public partial class SmartBlogPost : SmartBlogArticle
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "SmartBlogPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SmartBlogPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SmartBlogPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Author: The name of the author of this post. (Try to avoid spelling mistakes because all author names will be listed on the right side of the blog.)
		///</summary>
		[ImplementPropertyType("smartBlogAuthor")]
		public string SmartBlogAuthor
		{
			get { return this.GetPropertyValue<string>("smartBlogAuthor"); }
		}

		///<summary>
		/// Category: The categories this post falls under.
		///</summary>
		[ImplementPropertyType("smartBlogCategory")]
		public object SmartBlogCategory
		{
			get { return this.GetPropertyValue("smartBlogCategory"); }
		}

		///<summary>
		/// Date: The date and time this post was created.
		///</summary>
		[ImplementPropertyType("smartBlogDate")]
		public DateTime SmartBlogDate
		{
			get { return this.GetPropertyValue<DateTime>("smartBlogDate"); }
		}

		///<summary>
		/// Disable Comments: Disables comments for this post, existing comments will not be shown.
		///</summary>
		[ImplementPropertyType("smartBlogDisableComments")]
		public bool SmartBlogDisableComments
		{
			get { return this.GetPropertyValue<bool>("smartBlogDisableComments"); }
		}

		///<summary>
		/// Tags: Tags associated with this post.
		///</summary>
		[ImplementPropertyType("smartBlogTags")]
		public object SmartBlogTags
		{
			get { return this.GetPropertyValue("smartBlogTags"); }
		}
	}

	/// <summary>RSS</summary>
	[PublishedContentModel("SmartBlogRSS")]
	public partial class SmartBlogRss : SmartBlogMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "SmartBlogRSS";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SmartBlogRss(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SmartBlogRss, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Copyright: The copyright text to accompany this RSS feed.
		///</summary>
		[ImplementPropertyType("smartBlogRssCopyright")]
		public string SmartBlogRssCopyright
		{
			get { return this.GetPropertyValue<string>("smartBlogRssCopyright"); }
		}

		///<summary>
		/// Description: The description of this RSS feed.
		///</summary>
		[ImplementPropertyType("smartBlogRssDescription")]
		public string SmartBlogRssDescription
		{
			get { return this.GetPropertyValue<string>("smartBlogRssDescription"); }
		}

		///<summary>
		/// Image: The image to associate with this RSS feed.
		///</summary>
		[ImplementPropertyType("smartBlogRssImage")]
		public object SmartBlogRssImage
		{
			get { return this.GetPropertyValue("smartBlogRssImage"); }
		}

		///<summary>
		/// Title: The title of this RSS feed.
		///</summary>
		[ImplementPropertyType("smartBlogRssTitle")]
		public string SmartBlogRssTitle
		{
			get { return this.GetPropertyValue<string>("smartBlogRssTitle"); }
		}
	}

	/// <summary>SmartBlog Blog</summary>
	[PublishedContentModel("SmartBlogBlog")]
	public partial class SmartBlogBlog : SmartBlogArticle
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "SmartBlogBlog";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SmartBlogBlog(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SmartBlogBlog, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Disable Global Comments: Disable global comments on this blog.
		///</summary>
		[ImplementPropertyType("disableGlobalComments")]
		public bool DisableGlobalComments
		{
			get { return this.GetPropertyValue<bool>("disableGlobalComments"); }
		}
	}

	/// <summary>Year</summary>
	[PublishedContentModel("SmartBlogYear")]
	public partial class SmartBlogYear : SmartBlogDate
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "SmartBlogYear";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SmartBlogYear(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SmartBlogYear, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Sitemap</summary>
	[PublishedContentModel("sitemap")]
	public partial class Sitemap : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sitemap";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Sitemap(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Sitemap, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// SiteMapBody
		///</summary>
		[ImplementPropertyType("siteMapBody")]
		public IHtmlString SiteMapBody
		{
			get { return this.GetPropertyValue<IHtmlString>("siteMapBody"); }
		}
	}

	/// <summary>SearchResults</summary>
	[PublishedContentModel("searchResults")]
	public partial class SearchResults : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "searchResults";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SearchResults(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SearchResults, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// SearchResultsBody
		///</summary>
		[ImplementPropertyType("searchResultsBody")]
		public IHtmlString SearchResultsBody
		{
			get { return this.GetPropertyValue<IHtmlString>("searchResultsBody"); }
		}
	}

	/// <summary>Slide</summary>
	[PublishedContentModel("slide")]
	public partial class Slide : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "slide";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Slide(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Slide, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Image: An image that will be displayed as the masthead on the frontpage
		///</summary>
		[ImplementPropertyType("slideBanner")]
		public object SlideBanner
		{
			get { return this.GetPropertyValue("slideBanner"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
