using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;

using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(alloy.ReactConfig), "Configure")]

namespace alloy
{
    public static class ReactConfig
	{
		public static void Configure()
		{
            ReactSiteConfiguration.Configuration
                .SetLoadBabel(false)
                .SetLoadReact(true)
                .AddScriptWithoutTransform("~/Frontend/dist/components.bundle.js");

            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();

        }
	}
}