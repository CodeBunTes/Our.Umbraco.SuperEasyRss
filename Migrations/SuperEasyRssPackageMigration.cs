using Microsoft.Extensions.Options;
using Umbraco.Cms.Core.Configuration.Models;
using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Infrastructure.Migrations;
using Umbraco.Cms.Infrastructure.Packaging;

namespace Our.Umbraco.SuperEasyRss.Migrations
{
    public class SuperEasyRssPackageMigration : PackageMigrationBase
    {
        private readonly IFileService _fileService;

        public SuperEasyRssPackageMigration(
            IPackagingService packagingService,
            IMediaService mediaService,
            MediaFileManager mediaFileManager,
            MediaUrlGeneratorCollection mediaUrlGenerators,
            IShortStringHelper shortStringHelper,
            IContentTypeBaseServiceProvider contentTypeBaseServiceProvider,
            IMigrationContext context,
            IFileService fileService,
            IOptions<PackageMigrationSettings> packageMigrationsSettings)
            : base(
                packagingService,
                mediaService,
                mediaFileManager,
                mediaUrlGenerators,
                shortStringHelper,
                contentTypeBaseServiceProvider,
                context,
                packageMigrationsSettings)
        {
            _fileService = fileService;
        }

        protected override void Migrate()
        {
            var template = _fileService.GetTemplate("rssFeedPage") ?? _fileService.CreateTemplateWithIdentity("RSS Feed Page", "RssFeedPage", null);
            ImportPackage.FromEmbeddedResource<SuperEasyRssPackageMigration>().Do();
        }
    }
}
