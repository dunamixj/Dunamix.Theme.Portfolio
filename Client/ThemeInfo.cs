using System.Collections.Generic;
using Oqtane.Models;
using Oqtane.Themes;
using Oqtane.Shared;

namespace Dunamix.Theme.Portfolio
{
    public class ThemeInfo : ITheme
    {
        public Oqtane.Models.Theme Theme => new Oqtane.Models.Theme
        {
            Name = "Dunamix Portfolio",
            Version = "1.0.0",
            PackageName = "Dunamix.Theme.Portfolio",
            ThemeSettingsType = "Dunamix.Theme.Portfolio.ThemeSettings, Dunamix.Theme.Portfolio.Client.Oqtane",
            ContainerSettingsType = "Dunamix.Theme.Portfolio.ContainerSettings, Dunamix.Theme.Portfolio.Client.Oqtane",
            Resources = new List<Resource>()
            {
		        // obtained from https://cdnjs.com/libraries
                //new Resource { ResourceType = ResourceType.Stylesheet, Url = "https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.2/css/bootstrap.min.css", Integrity = "sha512-b2QcS5SsA8tZodcDtGRELiGv5SaKSk1vDHDaQRda0htPYWZ6046lr3kJ5bAAQdpV2mmA/4v0wQF9MyU6/pDIAg==", CrossOrigin = "anonymous" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "~/css/style.css" },
                new Resource { ResourceType = ResourceType.Script, Url = "~/js/scripts.js" },
                new Resource { ResourceType = ResourceType.Script, Url = "https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.2/js/bootstrap.bundle.min.js", Integrity = "sha512-X/YkDZyjTf4wyc2Vy16YGCPHwAY8rZJY+POgokZjQB2mhIRFJCckEGc6YyX9eNsPfn0PzThEuNs+uaomE5CO6A==", CrossOrigin = "anonymous" }
            }
        };

    }
}
