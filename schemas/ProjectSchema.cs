public class Project
{
    public _Id _id { get; set; }
    public int approvalfy { get; set; }
    public string board_approval_month { get; set; }
    public DateTime boardapprovaldate { get; set; }
    public string borrower { get; set; }
    public DateTime closingdate { get; set; }
    public string country_namecode { get; set; }
    public string countrycode { get; set; }
    public string countryname { get; set; }
    public string countryshortname { get; set; }
    public string docty { get; set; }
    public string envassesmentcategorycode { get; set; }
    public int grantamt { get; set; }
    public int ibrdcommamt { get; set; }
    public string id { get; set; }
    public int idacommamt { get; set; }
    public string impagency { get; set; }
    public string lendinginstr { get; set; }
    public string lendinginstrtype { get; set; }
    public int lendprojectcost { get; set; }
    public Majorsector_Percent[] majorsector_percent { get; set; }
    public Mjsector_Namecode[] mjsector_namecode { get; set; }
    public string[] mjtheme { get; set; }
    public Mjtheme_Namecode[] mjtheme_namecode { get; set; }
    public string mjthemecode { get; set; }
    public string prodline { get; set; }
    public string prodlinetext { get; set; }
    public string productlinetype { get; set; }
    public Project_Abstract project_abstract { get; set; }
    public string project_name { get; set; }
    public Projectdoc[] projectdocs { get; set; }
    public string projectfinancialtype { get; set; }
    public string projectstatusdisplay { get; set; }
    public string regionname { get; set; }
    public Sector[] sector { get; set; }
    public Sector1 sector1 { get; set; }
    public Sector2 sector2 { get; set; }
    public Sector3 sector3 { get; set; }
    public Sector4 sector4 { get; set; }
    public Sector_Namecode[] sector_namecode { get; set; }
    public string sectorcode { get; set; }
    public string source { get; set; }
    public string status { get; set; }
    public string supplementprojectflg { get; set; }
    public Theme1 theme1 { get; set; }
    public Theme_Namecode[] theme_namecode { get; set; }
    public string themecode { get; set; }
    public int totalamt { get; set; }
    public int totalcommamt { get; set; }
    public string url { get; set; }
}

public class _Id
{
    public string oid { get; set; }
}

public class Project_Abstract
{
    public string cdata { get; set; }
}

public class Sector1
{
    public string Name { get; set; }
    public int Percent { get; set; }
}

public class Sector2
{
    public string Name { get; set; }
    public int Percent { get; set; }
}

public class Sector3
{
    public string Name { get; set; }
    public int Percent { get; set; }
}

public class Sector4
{
    public string Name { get; set; }
    public int Percent { get; set; }
}

public class Theme1
{
    public string Name { get; set; }
    public int Percent { get; set; }
}

public class Majorsector_Percent
{
    public string Name { get; set; }
    public int Percent { get; set; }
}

public class Mjsector_Namecode
{
    public string name { get; set; }
    public string code { get; set; }
}

public class Mjtheme_Namecode
{
    public string name { get; set; }
    public string code { get; set; }
}

public class Projectdoc
{
    public string DocTypeDesc { get; set; }
    public string DocType { get; set; }
    public string EntityID { get; set; }
    public string DocURL { get; set; }
    public string DocDate { get; set; }
}

public class Sector
{
    public string Name { get; set; }
}

public class Sector_Namecode
{
    public string name { get; set; }
    public string code { get; set; }
}

public class Theme_Namecode
{
    public string name { get; set; }
    public string code { get; set; }
}