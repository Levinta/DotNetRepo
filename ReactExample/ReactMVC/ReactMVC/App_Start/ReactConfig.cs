using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ReactMVC.ReactConfig), "Configure")]

namespace ReactMVC
{
    public static class ReactConfig
    {
        public static void Configure()
        {
            // If you want to use server-side rendering of React components, 
            // add all the necessary JavaScript files here. This includes 
            // your components as well as all of their dependencies.
            // See http://reactjs.net/ for more information. Example:
            ReactSiteConfiguration.Configuration.SetReuseJavaScriptEngines(true)
                .SetAllowJavaScriptPrecompilation(true)
                .AddScript("~/Scripts/React/Tutorial.jsx")
                .AddScript("~/Scripts/React/FirstTable.jsx");
            //	.AddScript("~/Scripts/Second.jsx");
            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();
            // If you use an external build too (for example, Babel, Webpack,
            // Browserify or Gulp), you can improve performance by disabling 
            // ReactJS.NET's version of Babel and loading the pre-transpiled 
            // scripts. Example:
            //ReactSiteConfiguration.Configuration
            //	.SetLoadBabel(false)
            //	.AddScriptWithoutTransform("~/Scripts/bundle.server.js")
        }
    }
}