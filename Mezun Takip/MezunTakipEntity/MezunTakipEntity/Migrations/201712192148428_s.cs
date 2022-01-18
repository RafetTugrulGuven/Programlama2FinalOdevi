namespace MezunTakipEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bolumlers",
                c => new
                    {
                        bolum_id = c.Int(nullable: false, identity: true),
                        bolum_adi = c.String(nullable: false, maxLength: 8000, unicode: false),
                        bolum_kodu = c.Int(nullable: false),
                        bolum_FakulteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.bolum_id)
                .ForeignKey("dbo.Fakultelers", t => t.bolum_FakulteId, cascadeDelete: true)
                .Index(t => t.bolum_FakulteId);
            
            CreateTable(
                "dbo.CalismaAlanlaris",
                c => new
                    {
                        calismaAlani_id = c.Int(nullable: false, identity: true),
                        calismaAlani_adi = c.String(nullable: false, maxLength: 8000, unicode: false),
                        bolum_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.calismaAlani_id)
                .ForeignKey("dbo.Bolumlers", t => t.bolum_Id, cascadeDelete: true)
                .Index(t => t.bolum_Id);
            
            CreateTable(
                "dbo.DuyuruKapsamis",
                c => new
                    {
                        duyuruKapsam_id = c.Int(nullable: false, identity: true),
                        duyuru_id = c.Int(nullable: false),
                        calismaAlani_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.duyuruKapsam_id)
                .ForeignKey("dbo.Duyurulars", t => t.duyuru_id, cascadeDelete: true)
                .ForeignKey("dbo.CalismaAlanlaris", t => t.calismaAlani_id, cascadeDelete: true)
                .Index(t => t.duyuru_id)
                .Index(t => t.calismaAlani_id);
            
            CreateTable(
                "dbo.Duyurulars",
                c => new
                    {
                        duyuru_id = c.Int(nullable: false, identity: true),
                        duyuru_Basligi = c.String(nullable: false, maxLength: 8000, unicode: false),
                        duyuru_Metin = c.String(nullable: false, maxLength: 8000, unicode: false),
                        duyuru_Resim = c.Binary(storeType: "image"),
                        duyuru_yayinTarihi = c.DateTime(),
                        duyuru_bitisTarihi = c.DateTime(),
                        duyuru_sahibiTc = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.duyuru_id)
                .ForeignKey("dbo.Uyelers", t => t.duyuru_sahibiTc)
                .Index(t => t.duyuru_sahibiTc);
            
            CreateTable(
                "dbo.DuyuruBasvurus",
                c => new
                    {
                        duyuruBasvuru_id = c.Int(nullable: false, identity: true),
                        duyuruBasvuru_durum = c.Int(),
                        duyuru_id = c.Int(nullable: false),
                        uye_tc = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.duyuruBasvuru_id)
                .ForeignKey("dbo.Uyelers", t => t.uye_tc)
                .ForeignKey("dbo.Duyurulars", t => t.duyuru_id, cascadeDelete: true)
                .Index(t => t.duyuru_id)
                .Index(t => t.uye_tc);
            
            CreateTable(
                "dbo.Uyelers",
                c => new
                    {
                        uye_tc = c.String(nullable: false, maxLength: 128, unicode: false),
                        uye_id = c.Int(nullable: false, identity: true),
                        uye_ad = c.String(nullable: false, maxLength: 8000, unicode: false),
                        uye_soyad = c.String(maxLength: 8000, unicode: false),
                        uye_sifre = c.String(maxLength: 8000, unicode: false),
                        uye_dogumTarihi = c.DateTime(),
                        uye_cinsiyet = c.Int(nullable: false),
                        uye_askerlikDurumu = c.Int(),
                        uye_foto = c.Binary(storeType: "image"),
                        uye_dogumYeri_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.uye_tc)
                .ForeignKey("dbo.Ilcelers", t => t.uye_dogumYeri_id, cascadeDelete: true)
                .Index(t => t.uye_dogumYeri_id);
            
            CreateTable(
                "dbo.Ilcelers",
                c => new
                    {
                        ilce_id = c.Int(nullable: false, identity: true),
                        ilce_adi = c.String(nullable: false, maxLength: 8000, unicode: false),
                        ilce_SehirId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ilce_id)
                .ForeignKey("dbo.Sehirlers", t => t.ilce_SehirId, cascadeDelete: true)
                .Index(t => t.ilce_SehirId);
            
            CreateTable(
                "dbo.Sehirlers",
                c => new
                    {
                        sehir_id = c.Int(nullable: false, identity: true),
                        sehir_adi = c.String(nullable: false, maxLength: 8000, unicode: false),
                        sehir_kodu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.sehir_id);
            
            CreateTable(
                "dbo.UyeCalismaAlanis",
                c => new
                    {
                        uyeCalismaAlani_id = c.Int(nullable: false, identity: true),
                        calismaAlani_id = c.Int(nullable: false),
                        uye_tc = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.uyeCalismaAlani_id)
                .ForeignKey("dbo.Uyelers", t => t.uye_tc)
                .ForeignKey("dbo.CalismaAlanlaris", t => t.calismaAlani_id, cascadeDelete: true)
                .Index(t => t.calismaAlani_id)
                .Index(t => t.uye_tc);
            
            CreateTable(
                "dbo.UyeOgrenimDurumus",
                c => new
                    {
                        uyeOgrenimD_id = c.Int(nullable: false, identity: true),
                        ogrenimD_durum = c.Int(nullable: false),
                        ogrenimD_id = c.Int(nullable: false),
                        uye_tc = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.uyeOgrenimD_id)
                .ForeignKey("dbo.OgrenimDurumlaris", t => t.ogrenimD_id, cascadeDelete: true)
                .ForeignKey("dbo.Uyelers", t => t.uye_tc)
                .Index(t => t.ogrenimD_id)
                .Index(t => t.uye_tc);
            
            CreateTable(
                "dbo.OgrenimDurumlaris",
                c => new
                    {
                        ogrenimD_id = c.Int(nullable: false, identity: true),
                        ogrenimD_tanim = c.String(nullable: false, maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.ogrenimD_id);
            
            CreateTable(
                "dbo.Fakultelers",
                c => new
                    {
                        fakulte_id = c.Int(nullable: false, identity: true),
                        fakulte_adi = c.String(nullable: false, maxLength: 8000, unicode: false),
                        fakulte_kodu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.fakulte_id);
            
            CreateTable(
                "dbo.SirketAdres",
                c => new
                    {
                        sirketAdres_id = c.Int(nullable: false, identity: true),
                        sirket_adres = c.String(nullable: false, maxLength: 8000, unicode: false),
                        sirket_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.sirketAdres_id)
                .ForeignKey("dbo.Sirketlers", t => t.sirket_Id, cascadeDelete: true)
                .Index(t => t.sirket_Id);
            
            CreateTable(
                "dbo.Sirketlers",
                c => new
                    {
                        sirket_id = c.Int(nullable: false, identity: true),
                        sirket_adi = c.String(nullable: false, maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.sirket_id);
            
            CreateTable(
                "dbo.SirketTels",
                c => new
                    {
                        sirketTel_id = c.Int(nullable: false, identity: true),
                        sirket_tel = c.String(nullable: false, maxLength: 8000, unicode: false),
                        sirket_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.sirketTel_id)
                .ForeignKey("dbo.Sirketlers", t => t.sirket_Id, cascadeDelete: true)
                .Index(t => t.sirket_Id);
            
            CreateTable(
                "dbo.SirketWebs",
                c => new
                    {
                        sirketWeb_id = c.Int(nullable: false, identity: true),
                        sirket_web = c.String(nullable: false, maxLength: 8000, unicode: false),
                        sirket_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.sirketWeb_id)
                .ForeignKey("dbo.Sirketlers", t => t.sirket_Id, cascadeDelete: true)
                .Index(t => t.sirket_Id);
            
            CreateTable(
                "dbo.UyeAdres",
                c => new
                    {
                        uyeAdres_id = c.Int(nullable: false, identity: true),
                        uye_adres = c.String(nullable: false, maxLength: 8000, unicode: false),
                        uye_tc = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.uyeAdres_id)
                .ForeignKey("dbo.Uyelers", t => t.uye_tc)
                .Index(t => t.uye_tc);
            
            CreateTable(
                "dbo.UyeBolums",
                c => new
                    {
                        uyeBolum_id = c.Int(nullable: false, identity: true),
                        bolum_id = c.Int(nullable: false),
                        uye_tc = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.uyeBolum_id)
                .ForeignKey("dbo.Bolumlers", t => t.bolum_id, cascadeDelete: true)
                .ForeignKey("dbo.Uyelers", t => t.uye_tc)
                .Index(t => t.bolum_id)
                .Index(t => t.uye_tc);
            
            CreateTable(
                "dbo.UyeMails",
                c => new
                    {
                        uyeMail_id = c.Int(nullable: false, identity: true),
                        uyeMail_adres = c.String(nullable: false, maxLength: 8000, unicode: false),
                        uye_tc = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.uyeMail_id)
                .ForeignKey("dbo.Uyelers", t => t.uye_tc)
                .Index(t => t.uye_tc);
            
            CreateTable(
                "dbo.UyeSirkets",
                c => new
                    {
                        uyeSirket_id = c.Int(nullable: false, identity: true),
                        uyeSirket_durum = c.Int(nullable: false),
                        sirket_id = c.Int(nullable: false),
                        uye_tc = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.uyeSirket_id)
                .ForeignKey("dbo.Sirketlers", t => t.sirket_id, cascadeDelete: true)
                .ForeignKey("dbo.Uyelers", t => t.uye_tc)
                .Index(t => t.sirket_id)
                .Index(t => t.uye_tc);
            
            CreateTable(
                "dbo.UyeTels",
                c => new
                    {
                        uyeTel_id = c.Int(nullable: false, identity: true),
                        uye_tel = c.String(nullable: false, maxLength: 8000, unicode: false),
                        uye_tc = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.uyeTel_id)
                .ForeignKey("dbo.Uyelers", t => t.uye_tc)
                .Index(t => t.uye_tc);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UyeTels", "uye_tc", "dbo.Uyelers");
            DropForeignKey("dbo.UyeSirkets", "uye_tc", "dbo.Uyelers");
            DropForeignKey("dbo.UyeSirkets", "sirket_id", "dbo.Sirketlers");
            DropForeignKey("dbo.UyeMails", "uye_tc", "dbo.Uyelers");
            DropForeignKey("dbo.UyeBolums", "uye_tc", "dbo.Uyelers");
            DropForeignKey("dbo.UyeBolums", "bolum_id", "dbo.Bolumlers");
            DropForeignKey("dbo.UyeAdres", "uye_tc", "dbo.Uyelers");
            DropForeignKey("dbo.SirketWebs", "sirket_Id", "dbo.Sirketlers");
            DropForeignKey("dbo.SirketTels", "sirket_Id", "dbo.Sirketlers");
            DropForeignKey("dbo.SirketAdres", "sirket_Id", "dbo.Sirketlers");
            DropForeignKey("dbo.Bolumlers", "bolum_FakulteId", "dbo.Fakultelers");
            DropForeignKey("dbo.CalismaAlanlaris", "bolum_Id", "dbo.Bolumlers");
            DropForeignKey("dbo.UyeCalismaAlanis", "calismaAlani_id", "dbo.CalismaAlanlaris");
            DropForeignKey("dbo.DuyuruKapsamis", "calismaAlani_id", "dbo.CalismaAlanlaris");
            DropForeignKey("dbo.DuyuruKapsamis", "duyuru_id", "dbo.Duyurulars");
            DropForeignKey("dbo.DuyuruBasvurus", "duyuru_id", "dbo.Duyurulars");
            DropForeignKey("dbo.DuyuruBasvurus", "uye_tc", "dbo.Uyelers");
            DropForeignKey("dbo.UyeOgrenimDurumus", "uye_tc", "dbo.Uyelers");
            DropForeignKey("dbo.UyeOgrenimDurumus", "ogrenimD_id", "dbo.OgrenimDurumlaris");
            DropForeignKey("dbo.UyeCalismaAlanis", "uye_tc", "dbo.Uyelers");
            DropForeignKey("dbo.Uyelers", "uye_dogumYeri_id", "dbo.Ilcelers");
            DropForeignKey("dbo.Ilcelers", "ilce_SehirId", "dbo.Sehirlers");
            DropForeignKey("dbo.Duyurulars", "duyuru_sahibiTc", "dbo.Uyelers");
            DropIndex("dbo.UyeTels", new[] { "uye_tc" });
            DropIndex("dbo.UyeSirkets", new[] { "uye_tc" });
            DropIndex("dbo.UyeSirkets", new[] { "sirket_id" });
            DropIndex("dbo.UyeMails", new[] { "uye_tc" });
            DropIndex("dbo.UyeBolums", new[] { "uye_tc" });
            DropIndex("dbo.UyeBolums", new[] { "bolum_id" });
            DropIndex("dbo.UyeAdres", new[] { "uye_tc" });
            DropIndex("dbo.SirketWebs", new[] { "sirket_Id" });
            DropIndex("dbo.SirketTels", new[] { "sirket_Id" });
            DropIndex("dbo.SirketAdres", new[] { "sirket_Id" });
            DropIndex("dbo.UyeOgrenimDurumus", new[] { "uye_tc" });
            DropIndex("dbo.UyeOgrenimDurumus", new[] { "ogrenimD_id" });
            DropIndex("dbo.UyeCalismaAlanis", new[] { "uye_tc" });
            DropIndex("dbo.UyeCalismaAlanis", new[] { "calismaAlani_id" });
            DropIndex("dbo.Ilcelers", new[] { "ilce_SehirId" });
            DropIndex("dbo.Uyelers", new[] { "uye_dogumYeri_id" });
            DropIndex("dbo.DuyuruBasvurus", new[] { "uye_tc" });
            DropIndex("dbo.DuyuruBasvurus", new[] { "duyuru_id" });
            DropIndex("dbo.Duyurulars", new[] { "duyuru_sahibiTc" });
            DropIndex("dbo.DuyuruKapsamis", new[] { "calismaAlani_id" });
            DropIndex("dbo.DuyuruKapsamis", new[] { "duyuru_id" });
            DropIndex("dbo.CalismaAlanlaris", new[] { "bolum_Id" });
            DropIndex("dbo.Bolumlers", new[] { "bolum_FakulteId" });
            DropTable("dbo.UyeTels");
            DropTable("dbo.UyeSirkets");
            DropTable("dbo.UyeMails");
            DropTable("dbo.UyeBolums");
            DropTable("dbo.UyeAdres");
            DropTable("dbo.SirketWebs");
            DropTable("dbo.SirketTels");
            DropTable("dbo.Sirketlers");
            DropTable("dbo.SirketAdres");
            DropTable("dbo.Fakultelers");
            DropTable("dbo.OgrenimDurumlaris");
            DropTable("dbo.UyeOgrenimDurumus");
            DropTable("dbo.UyeCalismaAlanis");
            DropTable("dbo.Sehirlers");
            DropTable("dbo.Ilcelers");
            DropTable("dbo.Uyelers");
            DropTable("dbo.DuyuruBasvurus");
            DropTable("dbo.Duyurulars");
            DropTable("dbo.DuyuruKapsamis");
            DropTable("dbo.CalismaAlanlaris");
            DropTable("dbo.Bolumlers");
        }
    }
}
