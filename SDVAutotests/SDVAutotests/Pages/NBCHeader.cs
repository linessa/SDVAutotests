using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDVAutotests.Pages
{
    class NBCHeader
    {
        public static string lnkShows = "a[href='/shows']";
        public static string lnkEpisodes = "a[href='/video']";
        public static string lnkShedule = "a[href='/schedule']";
        public static string btnSports = "//span[contains(text(),'Sports')]/..";
        public static string lnkShop = "a[href='https://www.nbcstore.com/?cid=nbc_global_nav_shop']";
        public static string lnkApp = "a[href='/apps']";
        public static string btnSearch = "li button.navigation__search";
    }
}
