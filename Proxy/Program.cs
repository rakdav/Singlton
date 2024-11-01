ISite mySite = new SiteProxy(new Site());
Console.WriteLine(mySite.GetPage(1));
Console.WriteLine(mySite.GetPage(2));
Console.WriteLine(mySite.GetPage(3));
Console.WriteLine(mySite.GetPage(4));

interface ISite
{
    string GetPage(int num);
}
class Site : ISite
{
    public string GetPage(int num) => "page " + num;
}
class SiteProxy : ISite
{
    private ISite site;
    private Dictionary<int, string> cashe;

    public SiteProxy(ISite site)
    {
        this.site = site;
        this.cashe = new Dictionary<int, string>();
    }

    public string GetPage(int num)
    {
        string page;
        if (cashe.ContainsKey(num))
        {
            page = cashe[num];
            page = "from cashe" + page;
        }
        else
        {
            page = site.GetPage(num);
            cashe.Add(num, page);
        }
        return page;
    }
}
