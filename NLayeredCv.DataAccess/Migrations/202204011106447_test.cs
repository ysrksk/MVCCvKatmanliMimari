namespace NLayeredCv.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblAdmin",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TblDeneyimlerims",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        AltBaslik = c.String(),
                        Aciklama = c.String(),
                        Tarih = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TblEgitimlerims",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        AltBaslik1 = c.String(),
                        AltBaslik2 = c.String(),
                        GNO = c.String(),
                        Tarih = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TblHakkindas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Adres = c.String(),
                        Telefon = c.String(),
                        Mail = c.String(),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TblHobilerims",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Açıklama1 = c.String(),
                        Açıklama2 = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TblIletisims",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Mail = c.String(),
                        Konu = c.String(),
                        Mesaj = c.String(),
                        Tarih = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TblSertifikalarims",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Açıklama = c.String(),
                        Baslik = c.String(),
                        Tarih = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TblYeteneklerims",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Yetenek = c.String(),
                        Oran = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblYeteneklerims");
            DropTable("dbo.TblSertifikalarims");
            DropTable("dbo.TblIletisims");
            DropTable("dbo.TblHobilerims");
            DropTable("dbo.TblHakkindas");
            DropTable("dbo.TblEgitimlerims");
            DropTable("dbo.TblDeneyimlerims");
            DropTable("dbo.TblAdmin");
        }
    }
}
