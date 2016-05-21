public class Email
{
    public _Id _id { get; set; }
    public string sender { get; set; }
    public string[] recipients { get; set; }
    public object[] cc { get; set; }
    public string text { get; set; }
    public string mid { get; set; }
    public string fpath { get; set; }
    public object[] bcc { get; set; }
    public string[] to { get; set; }
    public object replyto { get; set; }
    public string ctype { get; set; }
    public string fname { get; set; }
    public string date { get; set; }
    public string folder { get; set; }
    public string subject { get; set; }
}

public class _Id
{
    public string oid { get; set; }
}