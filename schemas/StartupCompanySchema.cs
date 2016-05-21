public Company
{
    public _Id _id { get; set; }
    public string name { get; set; }
    public string permalink { get; set; }
    public string crunchbase_url { get; set; }
    public string homepage_url { get; set; }
    public string blog_url { get; set; }
    public string blog_feed_url { get; set; }
    public string twitter_username { get; set; }
    public string category_code { get; set; }
    public int number_of_employees { get; set; }
    public int founded_year { get; set; }
    public int founded_month { get; set; }
    public int founded_day { get; set; }
    public int deadpooled_year { get; set; }
    public string tag_list { get; set; }
    public string alias_list { get; set; }
    public string email_address { get; set; }
    public string phone_number { get; set; }
    public string description { get; set; }
    public Created_At created_at { get; set; }
    public string updated_at { get; set; }
    public string overview { get; set; }
    public Image image { get; set; }
    public Product[] products { get; set; }
    public Relationship[] relationships { get; set; }
    public Competition[] competitions { get; set; }
    public object[] providerships { get; set; }
    public string total_money_raised { get; set; }
    public Funding_Rounds[] funding_rounds { get; set; }
    public object[] investments { get; set; }
    public Acquisition acquisition { get; set; }
    public object[] acquisitions { get; set; }
    public Office[] offices { get; set; }
    public Milestone[] milestones { get; set; }
    public object[] video_embeds { get; set; }
    public Screenshot[] screenshots { get; set; }
    public External_Links[] external_links { get; set; }
    public object[] partners { get; set; }
}

public class _Id
{
    public string oid { get; set; }
}

public class Created_At
{
    public long date { get; set; }
}

public class Image
{
    public object[][] available_sizes { get; set; }
}

public class Acquisition
{
    public int price_amount { get; set; }
    public string price_currency_code { get; set; }
    public string term_code { get; set; }
    public string source_url { get; set; }
    public string source_description { get; set; }
    public int acquired_year { get; set; }
    public int acquired_month { get; set; }
    public int acquired_day { get; set; }
    public Acquiring_Company acquiring_company { get; set; }
}

public class Acquiring_Company
{
    public string name { get; set; }
    public string permalink { get; set; }
}

public class Product
{
    public string name { get; set; }
    public string permalink { get; set; }
}

public class Relationship
{
    public bool is_past { get; set; }
    public string title { get; set; }
    public Person person { get; set; }
}

public class Person
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string permalink { get; set; }
}

public class Competition
{
    public Competitor competitor { get; set; }
}

public class Competitor
{
    public string name { get; set; }
    public string permalink { get; set; }
}

public class Funding_Rounds
{
    public int id { get; set; }
    public string round_code { get; set; }
    public string source_url { get; set; }
    public string source_description { get; set; }
    public int raised_amount { get; set; }
    public string raised_currency_code { get; set; }
    public int funded_year { get; set; }
    public int funded_month { get; set; }
    public int funded_day { get; set; }
    public Investment[] investments { get; set; }
}

public class Investment
{
    public object company { get; set; }
    public Financial_Org financial_org { get; set; }
    public object person { get; set; }
}

public class Financial_Org
{
    public string name { get; set; }
    public string permalink { get; set; }
}

public class Office
{
    public string description { get; set; }
    public string address1 { get; set; }
    public string address2 { get; set; }
    public string zip_code { get; set; }
    public string city { get; set; }
    public string state_code { get; set; }
    public string country_code { get; set; }
    public float latitude { get; set; }
    public float longitude { get; set; }
}

public class Milestone
{
    public int id { get; set; }
    public string description { get; set; }
    public int stoned_year { get; set; }
    public int stoned_month { get; set; }
    public int stoned_day { get; set; }
    public string source_url { get; set; }
    public object source_text { get; set; }
    public string source_description { get; set; }
    public string stoneable_type { get; set; }
    public object stoned_value { get; set; }
    public object stoned_value_type { get; set; }
    public object stoned_acquirer { get; set; }
    public Stoneable stoneable { get; set; }
}

public class Stoneable
{
    public string name { get; set; }
    public string permalink { get; set; }
}

public class Screenshot
{
    public object[][] available_sizes { get; set; }
    public object attribution { get; set; }
}

public class External_Links
{
    public string external_url { get; set; }
    public string title { get; set; }
}
