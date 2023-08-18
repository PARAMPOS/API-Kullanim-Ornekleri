using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.turkpos.apitest.tr.com.ew.dmzws;
using System.Data;
using System.Diagnostics;

namespace com.turkpos.apitest.TestClasses {

    [TestClass]
    public class ProductionWebServiceTests {

        private ST_WS_Guvenlik GuvenlikNesnesi() {

            var stws = new ST_WS_Guvenlik() {
                CLIENT_CODE = "10738",
                CLIENT_USERNAME = "Test",
                CLIENT_PASSWORD = "Test"
            };
            return stws;

        }


        [TestMethod]
        public void OzelOranListeProd() {

            var service = new TurkPosWSTEST();
            var ozelOranListe =
                service.TP_Ozel_Oran_Liste(GuvenlikNesnesi(), "0c13d406-873b-403b-9c09-a5766840d98c");
            var s = Convert.ToInt32(ozelOranListe.Sonuc);
            Console.WriteLine(ozelOranListe.Sonuc_Str);
            if (s > 0) {
                foreach (DataRow row in ozelOranListe.DT_Bilgi.Rows) {
                    Console.WriteLine(row["Ozel_Oran_ID"]);
                    Console.WriteLine(row["GUID"]);
                    Console.WriteLine(row["Tarih_Bas"]);
                    Console.WriteLine(row["Tarih_Bit"]);
                    Console.WriteLine(row["SanalPOS_ID"]);
                    Console.WriteLine(row["Kredi_Karti_Banka"]);
                    Console.WriteLine(row["Kredi_Karti_Banka_Gorsel"]);
                    Console.WriteLine(row["MO_01"]);
                    Console.WriteLine(row["MO_02"]);
                    Console.WriteLine(row["MO_03"]);
                    Console.WriteLine(row["MO_04"]);
                    Console.WriteLine(row["MO_05"]);
                    Console.WriteLine(row["MO_06"]);
                    Console.WriteLine(row["MO_07"]);
                    Console.WriteLine(row["MO_08"]);
                    Console.WriteLine(row["MO_09"]);
                }
            }
            Assert.IsTrue(s > 0);

        }

        [TestMethod]
        public void OzelOranSKListeProd() {

            var service = new TurkPosWSTEST();
            var ozelOranSKListe =
                service.TP_Ozel_Oran_SK_Liste(GuvenlikNesnesi(), "0c13d406-873b-403b-9c09-a5766840d98c");
            var s = Convert.ToInt32(ozelOranSKListe.Sonuc);
            Console.WriteLine(ozelOranSKListe.Sonuc_Str);
            if (s > 0) {
                foreach (DataColumn col in ozelOranSKListe.DT_Bilgi.Columns) {
                    Console.WriteLine(col.ColumnName);
                }
                foreach (DataRow row in ozelOranSKListe.DT_Bilgi.Rows) {
                    Console.WriteLine(row["Ozel_Oran_SK_ID"]);
                    Console.WriteLine(row["GUID"]);
                    Console.WriteLine(row["SanalPOS_ID"]);
                    Console.WriteLine(row["Kredi_Karti_Banka"]);
                    Console.WriteLine(row["Kredi_Karti_Banka_Gorsel"]);
                    Console.WriteLine(row["MO_01"]);
                    Console.WriteLine(row["MO_02"]);
                    Console.WriteLine(row["MO_03"]);
                    Console.WriteLine(row["MO_04"]);
                    Console.WriteLine(row["MO_05"]);
                    Console.WriteLine(row["MO_06"]);
                    Console.WriteLine(row["MO_07"]);
                    Console.WriteLine(row["MO_08"]);
                    Console.WriteLine(row["MO_09"]);
                }
            }
            Assert.IsTrue(s > 0);

        }

        [TestMethod]
        public void OzelOranSKGuncelleProd() {

            var service = new TurkPosWSTEST();
            var ozelOranSKListe =
                service.TP_Ozel_Oran_SK_Liste(GuvenlikNesnesi(), "0c13d406-873b-403b-9c09-a5766840d98c");
            var ozelOranSKID = ozelOranSKListe.DT_Bilgi.Rows[1]["Ozel_Oran_SK_ID"].ToString();
            var stSonuc =
                service.TP_Ozel_Oran_SK_Guncelle(GuvenlikNesnesi(), "0c13d406-873b-403b-9c09-a5766840d98c",
                    ozelOranSKID,
                    "1,6600",
                    "0,6600",
                    "0,6600",
                    "0,6600",
                    "0,6600",
                    "0,6600",
                    "0,6600",
                    "0,6600",
                    "0,6600",
                    "0,6600",
                    "0,6600",
                    "0,6600"
                );
            var s = Convert.ToInt32(stSonuc.Sonuc);
            Console.WriteLine(stSonuc.Sonuc_Str);
            if (s > 0) {
                Console.WriteLine("İşlem Başarılı");
                var dt = service.TP_Ozel_Oran_SK_Liste(GuvenlikNesnesi(), "0c13d406-873b-403b-9c09-a5766840d98c").DT_Bilgi;
                foreach (DataRow row in dt.Rows) {
                    Assert.AreEqual("1,6600", row["MO_01"].ToString());
                    Assert.AreEqual("0,6600", row["MO_02"].ToString());
                    Assert.AreEqual("0,6600", row["MO_04"].ToString());
                    Assert.AreEqual("0,6600", row["MO_05"].ToString());
                    Assert.AreEqual("0,6600", row["MO_06"].ToString());
                    Assert.AreEqual("0,6600", row["MO_07"].ToString());
                    Assert.AreEqual("0,6600", row["MO_08"].ToString());
                    Assert.AreEqual("0,6600", row["MO_09"].ToString());
                    Assert.AreEqual("0,6600", row["MO_10"].ToString());
                    Assert.AreEqual("0,6600", row["MO_12"].ToString());
                }
            } else {
                Assert.Fail(stSonuc.Sonuc_Str);
            }
        }

        /*
        / int SanalPOS_ID, 
            string GUID, 
            string KK_Sahibi, 
            string KK_No, 
            string KK_SK_Ay, 
            string KK_SK_Yil, 
            string KK_CVC, 
            string KK_Sahibi_GSM, 
            string Hata_URL, 
            string Basarili_URL, 
            string Siparis_ID, 
            string Siparis_Aciklama, 
            int Taksit, 
            string Islem_Tutar, 
            string Toplam_Tutar, 
            string Islem_Hash, 
            string Islem_ID, 
            string IPAdr, 
            string Ref_URL, 
            string Data1, 
            string Data2, 
            string Data3, 
            string Data4, 
            string Data5
        */
        [TestMethod]
        public void IslemOdemeProd() {

            var service = new TurkPosWSTEST();
            var hataUrl = "http://google.com.tr?q=hatali";
            var basariliUrl = "http://google.com.tr?q=basarili";
            var odemeUrl = "http://google.com.tr?q=odeme";
            var ozelOranListeSonuc = service.TP_Ozel_Oran_Liste(GuvenlikNesnesi(), "0c13d406-873b-403b-9c09-a5766840d98c");
            if (Convert.ToInt32(ozelOranListeSonuc.Sonuc) > 0) {
                var stSonucPreIslemOdeme =
               service.TP_Islem_Odeme(GuvenlikNesnesi(), Convert.ToInt32(ozelOranListeSonuc.DT_Bilgi.Rows[0]["SanalPOS_ID"]), "0c13d406-873b-403b-9c09-a5766840d98c", "Albert Einstein", "4444444444444444", "04", "14", "444", "5360331719"
               , hataUrl, basariliUrl, "sipariş1", "sipariş açıklama", 1, "10,50", "5", "2", "1000,50", "127.0.0.1",
               odemeUrl, "", "", "", "", "");
                var s = Convert.ToInt32(stSonucPreIslemOdeme.Sonuc);
                if (s > 0) {
                    Console.WriteLine("3d Url: " + stSonucPreIslemOdeme.UCD_URL);
                    Console.WriteLine(String.Format(@"PostParam: {0}\n{1}\n{2}\n{3}\n{4}\n{5}\n",
                        "TURKPOS_RETVAL_Sonuc", "TURKPOS_RETVAL_Sonuc_Str", "TURKPOS_RETVAL_Dekont_ID",
                        "TURKPOS_RETVAL_Tahsilat_Tutari", "TURKPOS_RETVAL_Odeme_Tutari", "TURKPOS_RETVAL_Siparis_ID"));
                }
                Console.WriteLine(stSonucPreIslemOdeme.Sonuc_Str);
                Assert.AreNotEqual(0, s);
            }

        }

        [TestMethod]
        public void SHA2B64Prod() {

            var service = new TurkPosWSTEST();
            var response = service.SHA2B64("TURKPOS");
            Assert.AreNotEqual(0, response.Length);
            Debug.Write(response);

        }

        [TestMethod]
        public void BINSanalPosProd() {

            var service = new TurkPosWSTEST();
            var bins = service.BIN_SanalPos(GuvenlikNesnesi(), "");
            Assert.IsTrue(Convert.ToInt32(bins.Sonuc) > 0);

            Assert.AreNotEqual(0, bins.DT_Bilgi.Rows.Count);
            var bin = bins.DT_Bilgi.Rows[0];
            Assert.IsNotNull(bin);
            Assert.AreNotEqual(0, bins.DT_Bilgi.Columns);
            Debug.Write(bin["BIN"] + "\n");
            Debug.Write(bin["SanalPOS_ID"] + "\n");
            Debug.Write(bin["Kart_Banka"] + "\n");
            Debug.Write(bin["DKK"] + "\n");
            var found = service.BIN_SanalPos(GuvenlikNesnesi(), bin["BIN"].ToString());
            Assert.IsTrue(Convert.ToInt32(found.Sonuc) > 0);
            Assert.AreEqual(found.DT_Bilgi.Rows[0]["BIN"], bin["BIN"]);
        }

        [TestMethod]
        public void TPMutabakatOzetProd() {

            var service = new TurkPosWSTEST();
            var response = service.TP_Mutabakat_Ozet(GuvenlikNesnesi(), "0c13d406-873b-403b-9c09-a5766840d98c", DateTime.Now.AddMonths(-2).ToString("dd.MM.yyyy HH:mm:ss"), DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            Assert.IsTrue(Convert.ToInt32(response.Sonuc) > 0);
            Assert.IsTrue(response.DT_Bilgi.Rows.Count > 0);
            foreach (DataRow row in response.DT_Bilgi.Rows) {
                Debug.Write("\n");
                Debug.Write(row["Basarili_Islem_Sayi"] + "\n");
                Debug.Write(row["Basarili_Islem_Toplam_Tutar"] + "\n");
                Debug.Write(row["Iptal_Islem_Sayi"] + "\n");
                Debug.Write(row["Iptal_Islem_Toplam_Tutar"] + "\n");
                Debug.Write(row["Iade_Islem_Sayi"] + "\n");
                Debug.Write(row["Iade_Islem_Toplam_Tutar"] + "\n");
            }
        }

        [TestMethod]
        public void TPIslemIptalIadeProd() {
            var service = new TurkPosWSTEST();
            var response = service.TP_Islem_Iptal_Iade(GuvenlikNesnesi(), "0c13d406-873b-403b-9c09-a5766840d98c", "IADE", "1009917293");
            Assert.IsTrue(Convert.ToInt32(response.Sonuc) > 0, response.Sonuc_Str);
            Debug.Write(response.Sonuc_Str);
        }

        [TestMethod]
        public void TPIslemDekontGonderProd() {
            var service = new TurkPosWSTEST();
            var response = service.TP_Islem_Dekont_Gonder(GuvenlikNesnesi(), "0c13d406-873b-403b-9c09-a5766840d98c", "1009917293", "huseyin.sari@turuncuholding.com.tr");
            Assert.IsTrue(Convert.ToInt32(response.Sonuc) > 0, response.Sonuc_Str + "\nsonuc: " + response.Sonuc);
            Debug.Write(response.Sonuc_Str);
        }

        [TestMethod]
        public void TP_Islem_SorgulamaProd() {

            var service = new TurkPosWSTEST();
            var response = service.TP_Islem_Sorgulama(GuvenlikNesnesi(), "0c13d406-873b-403b-9c09-a5766840d98c", "1009917293", "", "");
            Assert.IsTrue(Convert.ToInt32(response.Sonuc) > 0, response.Sonuc_Str + "\nsonuc: " + response.Sonuc);
            Assert.IsTrue(response.DT_Bilgi.Rows.Count > 0);
            foreach (DataRow row in response.DT_Bilgi.Rows) {
                Debug.Write("\n");
                Debug.Write(row["Odeme_Sonuc"] + "\n");
                Debug.Write(row["Odeme_Sonuc_Aciklama"] + "\n");
                Debug.Write(row["Tarih"] + "\n");
                Debug.Write(row["Dekont_ID"] + "\n");
                Debug.Write(row["Siparis_ID"] + "\n");
                Debug.Write(row["Islem_ID"] + "\n");
                Debug.Write(row["Komisyon_Oran"] + "\n");
                Debug.Write(row["Komisyon_Tutar"] + "\n");
                Debug.Write(row["Toplam_Tutar"] + "\n");
                Debug.Write(row["Taksit"] + "\n");
            }
        }

    }

}
