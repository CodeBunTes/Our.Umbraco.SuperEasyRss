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
5) It is recommended, but not necessary, to manually add to the HTML for the publically viewable root page of the blog or news section a reference back to the RSS feed using the link tag. ie:-

`<link rel="alternate" type="application/rss+xml" href="/url/to/feedpage" title="RSS Feed for x">`


By default the RSS feed will use the immediate parent as the 'root' of the feed, and include all descendent documents unless they have an 'Exclude From Rss' True/False field set to true. Titles and descriptions will search for sensibly named fields by default, and published date and creator will take details from the published node.

Different roots, restrictions to certain doctypes or fields to read can be configured on the created RSS page.

The page cannot be used at the site root unless an explicit alternative root node has been picked as it will otherwise have no parent in that case.

## Use with xStatic

This can be used with the static site generator package xStatic from Sam Mullins, however by default the feed page will be generated as an HTML file which returns a text/html mime type by default. Some feed readers will be fine with this, however ideally it should be marked as containing XML. There are more involved ways of doing this in code in xStatic, however one of the simplest methods is with the back office tooling for actions it provides.

Once you know the URL your feed page will appear on simply set up a new FileRenameAction action to rename the default generated .html file as a .xml file as renames are performed at the end.

For example:-
**FilePath:** blog/rss/index.html
**NewFilePath:** blog/rss/index.xml