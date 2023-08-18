using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.turkpos.apitest.tr.com.ew.dmzws;
using System.Data;
using System.Diagnostics;

namespace com.turkpos.apitest.TestClasses {

    [TestClass]
    public class WebServiceTests {

        private ST_WS_Guvenlik GuvenlikNesnesi() {

            var stws = new ST_WS_Guvenlik() {
                CLIENT_CODE = "10738",
                CLIENT_USERNAME = "Test",
                CLIENT_PASSWORD = "Test"
            };
            return stws;

        }


        [TestMethod]
        public void OzelOranListe() {

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
        public void OzelOranSKListe() {

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
        public void OzelOranSKGuncelle() {

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

        [TestMethod]
        public void ETSPreIslemOdeme() {
            var hash_ = "";
            var service = new TurkPosWSTEST();
            var hataUrl = "http://google.com.tr?q=hatali";
            var basariliUrl = "http://google.com.tr?q=basarili";
            var odemeUrl = "http://google.com.tr?q=odeme";
            var ozelOranListeSonuc = service.TP_Ozel_Oran_SK_Liste(GuvenlikNesnesi(), "0c13d406-873b-403b-9c09-a5766840d98c");
            var Islem_Hash = "10738" + "0c13d406-873b-403b-9c09-a5766840d98c" + Convert.ToInt32(ozelOranListeSonuc.DT_Bilgi.Rows[0]["SanalPOS_ID"]) + "1" + "100,00" + "100,00" + "sipariş1" + hataUrl + basariliUrl;
            if (Convert.ToInt32(ozelOranListeSonuc.Sonuc) > 0) {
                hash_ = service.SHA2B64(Islem_Hash);
                var stSonucPreIslemOdeme = service.TP_Islem_Odeme(GuvenlikNesnesi(), Convert.ToInt32(ozelOranListeSonuc.DT_Bilgi.Rows[0]["SanalPOS_ID"]), "0c13d406-873b-403b-9c09-a5766840d98c", "Albert Einstein", "4444444444444444", "04", "14", "444", "5360331719", hataUrl, basariliUrl, "sipariş1", "sipariş açıklama", 1, "100,00", "100,00", hash_, "", "127.0.0.1", odemeUrl, "", "", "", "", "");
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
        public void SHA2B64() {

            var service = new TurkPosWSTEST();
            var response = service.SHA2B64("TURKPOS");
            Assert.AreNotEqual(0, response.Length);
            Debug.Write(response);

        }

        [TestMethod]
        public void BINSanalPos() {

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
    }

}
