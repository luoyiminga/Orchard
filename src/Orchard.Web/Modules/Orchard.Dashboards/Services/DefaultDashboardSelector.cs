﻿using Orchard.ContentManagement;
using Orchard.Core.Title.Models;
using Orchard.Dashboards.Models;
using Orchard.Layouts.Models;

namespace Orchard.Dashboards.Services {
    public class DefaultDashboardSelector : IDashboardSelector {
        private readonly IOrchardServices _services;
        public const string DefaultLayout = "{\"elements\":[{\"typeName\":\"Orchard.Layouts.Elements.Canvas\",\"data\":\"\",\"exportableData\":\"\",\"index\":0,\"elements\":[{\"typeName\":\"Orchard.Layouts.Elements.Grid\",\"data\":\"\",\"exportableData\":\"\",\"index\":0,\"elements\":[{\"typeName\":\"Orchard.Layouts.Elements.Row\",\"data\":\"\",\"exportableData\":\"\",\"index\":0,\"elements\":[{\"typeName\":\"Orchard.Layouts.Elements.Column\",\"data\":\"Width=2&Offset=0&Collapsible=null\",\"exportableData\":\"\",\"index\":0,\"elements\":[{\"typeName\":\"Orchard.Layouts.Elements.Html\",\"data\":\"TypeName=Orchard.Layouts.Elements.Html&Text=%3ch2%3e%3ci+class%3d%22fa+fa-cog%22%3e%3c%2fi%3e+Get+up+and+running%3c%2fh2%3e%0d%0a%3cp%3eStart+by+exploring+the+menu+on+the+left+and+familiarize+yourself+with+Orchard.+As+for+the+basics%2c+we+suggest+%3ca+href%3d%22%23%7bUrl.Action%3aIndex%2cAdmin%2carea%3dOrchard.Themes%7d%22%3echanging+the+theme%3c%2fa%3e%2c+%3ca+href%3d%22%23%7bUrl.Action%3aCreate%2cAdmin%2carea%3dContents%7d%22%3eadding+some+pages%3c%2fa%3e%2c+%3ca+href%3d%22%23%7bUrl.Action%3aCreate%2cBlogAdmin%2carea%3dOrchard.Blogs%7d%22%3esetup+up+a+blog%3c%2fa%3e%2c+and+%3ca+href%3d%22%23%7bUrl.Action%3aIndex%2cAdmin%2carea%3dSettings%2cgroupInfoId%3dIndex%7d%22%3econfiguring+basic+settings%3c%2fa%3e.%3c%2fp%3e&Content=%3ch2%3e%3ci+class%3d%22fa+fa-cog%22%3e%3c%2fi%3e+Get+up+and+running%3c%2fh2%3e%0d%0a%3cp%3eStart+by+exploring+the+menu+on+the+left+and+familiarize+yourself+with+Orchard.+As+for+the+basics%2c+we+suggest+%3ca+href%3d%22%23%7bUrl.Action%3aIndex%2cAdmin%2carea%3dOrchard.Themes%7d%22%3echanging+the+theme%3c%2fa%3e%2c+%3ca+href%3d%22%23%7bUrl.Action%3aCreate%2cAdmin%2carea%3dContents%7d%22%3eadding+some+pages%3c%2fa%3e%2c+%3ca+href%3d%22%23%7bUrl.Action%3aCreate%2cBlogAdmin%2carea%3dOrchard.Blogs%7d%22%3esetup+up+a+blog%3c%2fa%3e%2c+and+%3ca+href%3d%22%23%7bUrl.Action%3aIndex%2cAdmin%2carea%3dSettings%2cgroupInfoId%3dIndex%7d%22%3econfiguring+basic+settings%3c%2fa%3e.%3c%2fp%3e\",\"exportableData\":\"\",\"index\":0,\"elements\":[],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"}],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"},{\"typeName\":\"Orchard.Layouts.Elements.Column\",\"data\":\"Width=2&Offset=0&Collapsible=null\",\"exportableData\":\"\",\"index\":1,\"elements\":[{\"typeName\":\"Orchard.Layouts.Elements.Html\",\"data\":\"TypeName=Orchard.Layouts.Elements.Html&Text=%3ch2%3e%3ci+class%3d%22fa+fa-th-large%22%3e%3c%2fi%3eGet+more+goodies%3c%2fh2%3e%0d%0a%3cp%3eChange+the+way+your+site+works+and+looks+with+%3ca+href%3d%22%23%7bUrl.Action%3aThemes%2cGallery%2carea%3dOrchard.Packaging%7d%22%3ethemes%3c%2fa%3e+and+%3ca+href%3d%22%23%7bUrl.Action%3aModules%2cGallery%2carea%3dOrchard.Packaging%7d%22%3emodules%3c%2fa%3e.+There%26rsquo%3bs+plenty+to+choose+from+in+the+%3ca+href%3d%22http%3a%2f%2fgallery.orchardproject.net%22%3eOrchard+Gallery%3c%2fa%3e.+We%26rsquo%3bre+always+adding+things%2c+so+be+sure+to+check+back+often+to+see+what%26rsquo%3bs+new.%3c%2fp%3e&Content=%3ch2%3e%3ci+class%3d%22fa+fa-th-large%22%3e%3c%2fi%3eGet+more+goodies%3c%2fh2%3e%0d%0a%3cp%3eChange+the+way+your+site+works+and+looks+with+%3ca+href%3d%22%23%7bUrl.Action%3aThemes%2cGallery%2carea%3dOrchard.Packaging%7d%22%3ethemes%3c%2fa%3e+and+%3ca+href%3d%22%23%7bUrl.Action%3aModules%2cGallery%2carea%3dOrchard.Packaging%7d%22%3emodules%3c%2fa%3e.+There%26rsquo%3bs+plenty+to+choose+from+in+the+%3ca+href%3d%22http%3a%2f%2fgallery.orchardproject.net%22%3eOrchard+Gallery%3c%2fa%3e.+We%26rsquo%3bre+always+adding+things%2c+so+be+sure+to+check+back+often+to+see+what%26rsquo%3bs+new.%3c%2fp%3e\",\"exportableData\":\"\",\"index\":0,\"elements\":[],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"}],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"},{\"typeName\":\"Orchard.Layouts.Elements.Column\",\"data\":\"Width=2&Offset=0&Collapsible=null\",\"exportableData\":\"\",\"index\":2,\"elements\":[{\"typeName\":\"Orchard.Layouts.Elements.Html\",\"data\":\"TypeName=Orchard.Layouts.Elements.Html&Text=%3ch2%3e%3ci+class%3d%22fa+fa-book%22%3e%3c%2fi%3eRead+the+Docs%3c%2fh2%3e%0d%0a%3cp%3eAre+you+ready+to+go+deeper+and+become+an+Orchard+expert%3f+Take+a+look+at+the+%3ca+href%3d%22http%3a%2f%2fdocs.orchardproject.net%22%3eOrchard+Documentation%3c%2fa%3e+to+learn+about+how+everything+connects+together+and+what+makes+Orchard+tick.%3c%2fp%3e&Content=%3ch2%3e%3ci+class%3d%22fa+fa-book%22%3e%3c%2fi%3eRead+the+Docs%3c%2fh2%3e%0d%0a%3cp%3eAre+you+ready+to+go+deeper+and+become+an+Orchard+expert%3f+Take+a+look+at+the+%3ca+href%3d%22http%3a%2f%2fdocs.orchardproject.net%22%3eOrchard+Documentation%3c%2fa%3e+to+learn+about+how+everything+connects+together+and+what+makes+Orchard+tick.%3c%2fp%3e\",\"exportableData\":\"\",\"index\":0,\"elements\":[],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"}],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"},{\"typeName\":\"Orchard.Layouts.Elements.Column\",\"data\":\"Width=2&Offset=0&Collapsible=null\",\"exportableData\":\"\",\"index\":3,\"elements\":[{\"typeName\":\"Orchard.Layouts.Elements.Html\",\"data\":\"TypeName=Orchard.Layouts.Elements.Html&Text=%3ch2%3e%3ci+class%3d%22fa+fa-users%22%3e%3c%2fi%3eMake+friends%3c%2fh2%3e%0d%0a%3cp%3eFind+friends+that+share+your+interest+of+Orchard.+There+are+a+couple+ways+that+you+can%26nbsp%3b%3ca+href%3d%22http%3a%2f%2forchardproject.net%2fdiscussions%22%3ediscuss+and+get+connected%3c%2fa%3e+to+the+project+including+mailing+lists%2c+forums+and+IRC.%3c%2fp%3e&Content=%3ch2%3e%3ci+class%3d%22fa+fa-users%22%3e%3c%2fi%3eMake+friends%3c%2fh2%3e%0d%0a%3cp%3eFind+friends+that+share+your+interest+of+Orchard.+There+are+a+couple+ways+that+you+can%26nbsp%3b%3ca+href%3d%22http%3a%2f%2forchardproject.net%2fdiscussions%22%3ediscuss+and+get+connected%3c%2fa%3e+to+the+project+including+mailing+lists%2c+forums+and+IRC.%3c%2fp%3e\",\"exportableData\":\"\",\"index\":0,\"elements\":[],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"}],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"},{\"typeName\":\"Orchard.Layouts.Elements.Column\",\"data\":\"Width=2&Offset=0&Collapsible=null\",\"exportableData\":\"\",\"index\":4,\"elements\":[{\"typeName\":\"Orchard.Layouts.Elements.Html\",\"data\":\"TypeName=Orchard.Layouts.Elements.Html&Text=%3ch2%3e%3ci+class%3d%22fa+fa-pencil%22%3e%3c%2fi%3eContribute+back%3c%2fh2%3e%0d%0a%3cp%3eHelp+grow+Orchard.+We+encourage+contributions+of+all+sorts%2c+including+code+submissions%2c+documentation%2c+translations%2c+feature+recommendations%2c+and+more.Here+are+some+ways+to+%3ca+href%3d%22http%3a%2f%2forchardproject.net%2fcontribution%22%3egive+back+to+the+project%3c%2fa%3e.%3c%2fp%3e&Content=%3ch2%3e%3ci+class%3d%22fa+fa-pencil%22%3e%3c%2fi%3eContribute+back%3c%2fh2%3e%0d%0a%3cp%3eHelp+grow+Orchard.+We+encourage+contributions+of+all+sorts%2c+including+code+submissions%2c+documentation%2c+translations%2c+feature+recommendations%2c+and+more.Here+are+some+ways+to+%3ca+href%3d%22http%3a%2f%2forchardproject.net%2fcontribution%22%3egive+back+to+the+project%3c%2fa%3e.%3c%2fp%3e\",\"exportableData\":\"\",\"index\":0,\"elements\":[],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"}],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"},{\"typeName\":\"Orchard.Layouts.Elements.Column\",\"data\":\"Width=2&Offset=0&Collapsible=null\",\"exportableData\":\"\",\"index\":5,\"elements\":[],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"}],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"},{\"typeName\":\"Orchard.Layouts.Elements.Row\",\"data\":\"\",\"exportableData\":\"\",\"index\":1,\"elements\":[{\"typeName\":\"Orchard.Layouts.Elements.Column\",\"data\":\"Width=4&Offset=0&Collapsible=null\",\"exportableData\":\"\",\"index\":0,\"elements\":[{\"typeName\":\"Orchard.Layouts.Elements.Html\",\"data\":\"TypeName=Orchard.Layouts.Elements.Html&Text=%3ch2%3e%3ci+class%3d%22fa+fa-clock-o%22%3e%3c%2fi%3eStay+up+to+date%3c%2fh2%3e%0d%0a%3cp%3e%3ciframe+width%3d%22100%25%22+height%3d%22100%25%22+scrolling%3d%22no%22+frameborder%3d%220%22+src%3d%22http%3a%2f%2fwww.orchardproject.net%2fadvisory%22+id%3d%22advisory%22%3e%0d%0a+%26lt%3bp%26gt%3bYour+browser+does+not+support+iframes.+You+can%27t+see+advisory+messages.%26lt%3b%2fp%26gt%3b%3c%2fiframe%3e%3c%2fp%3e&Content=%3ch2%3e%3ci+class%3d%22fa+fa-clock-o%22%3e%3c%2fi%3eStay+up+to+date%3c%2fh2%3e%0d%0a%3cp%3e%3ciframe+width%3d%22100%25%22+height%3d%22100%25%22+scrolling%3d%22no%22+frameborder%3d%220%22+src%3d%22http%3a%2f%2fwww.orchardproject.net%2fadvisory%22+id%3d%22advisory%22%3e%0d%0a+%26lt%3bp%26gt%3bYour+browser+does+not+support+iframes.+You+can%27t+see+advisory+messages.%26lt%3b%2fp%26gt%3b%3c%2fiframe%3e%3c%2fp%3e\",\"exportableData\":\"\",\"index\":0,\"elements\":[],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"}],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"},{\"typeName\":\"Orchard.Layouts.Elements.Column\",\"data\":\"Width=8&Offset=0&Collapsible=null\",\"exportableData\":\"\",\"index\":1,\"elements\":[],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"}],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"}],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"}],\"isTemplated\":false,\"htmlId\":\"\",\"htmlClass\":\"\",\"htmlStyle\":\"\",\"rule\":\"\"}]}";

        public DefaultDashboardSelector(IOrchardServices services) {
            _services = services;
        }

        public DashboardDescriptor GetDashboardDescriptor() {
            var settings = _services.WorkContext.CurrentSite.As<DashboardSiteSettingsPart>();
            var dashboardId = settings.DefaultDashboardId;
            var dashboard = dashboardId != null ? _services.ContentManager.Get(dashboardId.Value, VersionOptions.Latest) : default(ContentItem);
            var descriptor = new DashboardDescriptor { Priority = -10 };

            if (dashboard == null)
                dashboard = CreateDefaultDashboard();

            descriptor.Display = shapeFactory => {
                var published = _services.ContentManager.Get(dashboard.Id, VersionOptions.Published);
                return _services.ContentManager.BuildDisplay(published, displayType: "Dashboard");
            };

            descriptor.Editor = shapeFactory => {
                var latest = _services.ContentManager.Get(dashboard.Id, VersionOptions.Latest);
                return _services.ContentManager.BuildEditor(latest);
            };

            descriptor.UpdateEditor = (shapeFactory, updater) => {
                var draft = _services.ContentManager.Get(dashboard.Id, VersionOptions.DraftRequired);
                return _services.ContentManager.UpdateEditor(draft, updater);
            };

            return descriptor;
        }

        private ContentItem CreateDefaultDashboard() {
            var dashboard = _services.ContentManager.Create("Dashboard");
            var settings = _services.WorkContext.CurrentSite.As<DashboardSiteSettingsPart>();
            var titlePart = dashboard.As<TitlePart>();
            var layoutPart = dashboard.As<LayoutPart>();

            titlePart.Title = "Welcome to Orchard";
            layoutPart.LayoutData = DefaultLayout;
            settings.DefaultDashboardId = dashboard.Id;

            return dashboard;
        }
    }
}