using System;
using Umbraco.Cms.Core.Packaging;
using Umbraco.Cms.Infrastructure.Packaging;

namespace Our.Umbraco.SuperEasyRss.Migrations
{
    public class SuperEasyRssPackageMigrationPlan : PackageMigrationPlan
    {
        public SuperEasyRssPackageMigrationPlan() : base("Super Easy RSS")
        {
        }

        protected override void DefinePlan()
        {
            To<SuperEasyRssPackageMigration>(new Guid("fafa5772-03bd-4c5c-89b7-d8f5f8709b7f"));
        }
    }
}
