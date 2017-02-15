using Nancy;
using System.Collections.Generic;
using FindAndReplaceApp.Objects;

namespace FindAndReplaceApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
        
            Post["/"] = _ => {
                FindAndReplace newFindAndReplace = new FindAndReplace(Request.Form["sentence"], Request.Form["replace"], Request.Form["new"]);
                string finalResult = newFindAndReplace.ReplaceFindWord();
                return View["index.cshtml", finalResult];
            };
        }
    }
}
