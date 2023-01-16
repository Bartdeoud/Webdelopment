namespace backend;

using System;

class EvenementHadler
{

    private ArrayList Evenementen = new ArrayList();

    string TitelVoorstelling,Artiest,zaal,LinkToImg;
    DateTime dateTime;

    public EvenementHadler(string TitelVoorstelling, string Artiest, DateTime dateTime, string zaal, string LinkToImg){
        this.TitelVoorstelling = TitelVoorstelling;
        this.Artiest = Artiest;
        this.dateTime = dateTime;
        this.zaal = zaal;
        this.LinkToImg = LinkToImg;
    }

    public static 
}