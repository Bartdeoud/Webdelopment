namespace backend;

using System;

public class Evenement
{
    string TitelVoorstelling,Artiest,zaal,LinkToImg;
    DateTime dateTime;

    public Evenement(string TitelVoorstelling, string Artiest, DateTime dateTime, string zaal, string LinkToImg){
        this.TitelVoorstelling = TitelVoorstelling;
        this.Artiest = Artiest;
        this.dateTime = dateTime;
        this.zaal = zaal;
        this.LinkToImg = LinkToImg;
    }
}