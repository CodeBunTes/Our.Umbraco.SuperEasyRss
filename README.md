# Super Easy RSS

This is a simple package for Umbraco v10+ designed to allow easy adding of an RSS feed to an existing blog or media/news section.

It is designed to be as unobtrusive and minimal in code, so as to not add too much in to existing projects.

## Project Makeup

The solution consists of:-
* Document Type 'Rss Feed Page'
* Template for rendering this

All logic is performed within the template and no additional models, controllers or c# code files are used. This is deliberately done to keep everything as self-contained as possible.

## How To Use

1) Add the package to your project.
2) Run Umbraco back office.
3) Configure any doctypes you'd like 'Rss Feed Page' to be available beneath. This will usually be the root folder of a blog or news section.
4) Create a new page of type 'Rss Feed Page' where you want the RSS feed to sit.
5) It is recommended, but not necessary, to manually add to the public HTML a reference to the RSS feed using the link tag.

`<link el="alternate" type="application/rss+xml" href="/url/to/feedpage" title="RSS Feed">`

By default the RSS feed will use the immediate parent as the 'root' of the feed, and include all descendent documents unless they have an 'Exclude From Rss' True/False field set to false. Titles and descriptions will search for sensibly named fields by default, and published date and creator will take details from the published node.

Different roots, restrictions to certain doctypes or fields to read can be configured on the created RSS page.

The page cannot be used at the site root unless an explicit alternative root node has been picked as it will otherwise have no parent in that case.
