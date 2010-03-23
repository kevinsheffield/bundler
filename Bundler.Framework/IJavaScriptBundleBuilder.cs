namespace Bundler.Framework
{
    public interface IJavaScriptBundleBuilder
    {
        IJavaScriptBundleBuilder Add(string cssPath);        
        string Render(string renderTo);
        string Render(string renderTo, string linkTo);
        void AsNamed(string name, string renderTo);
    }
}