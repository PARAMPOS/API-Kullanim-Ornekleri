package org.example;

import org.example.STGenelSonuc;
import org.example.STWSGuvenlik;

import javax.xml.bind.Element;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.soap.MessageFactory;
import javax.xml.soap.SOAPBody;
import javax.xml.soap.SOAPException;
import javax.xml.soap.SOAPMessage;
import javax.xml.transform.TransformerConfigurationException;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import javax.xml.ws.Service;

import javax.net.ssl.HttpsURLConnection;
import javax.net.ssl.SSLContext;
import javax.net.ssl.TrustManager;
import javax.net.ssl.X509TrustManager;
import javax.xml.namespace.QName;

import java.io.StringWriter;
import java.net.URL;

import java.security.cert.X509Certificate;



public class ParamPosIntegrationClient {

    URL wsdlURL;
    QName serviceName;

    Service service;

    TurkPosX0020WSX0020TESTSoap client;

    STWSGuvenlik sec;
    public ParamPosIntegrationClient(){

        try {

            // Sertifikaları doğrulamayı devre dışı bırakmak için güvenilirlik yöneticisi oluşturun
            TrustManager[] trustAllCerts = new TrustManager[]{
                    new X509TrustManager() {
                        public X509Certificate[] getAcceptedIssuers() {
                            return null;
                        }
                        public void checkClientTrusted(X509Certificate[] certs, String authType) {
                        }
                        public void checkServerTrusted(X509Certificate[] certs, String authType) {
                        }
                    }
            };

            // SSL bağlantılarında güvenilirlik yöneticisini kullanarak güvenilirlik kontrolünü devre dışı bırakın
            SSLContext sslContext = SSLContext.getInstance("TLS");
            sslContext.init(null, trustAllCerts, new java.security.SecureRandom());
            HttpsURLConnection.setDefaultSSLSocketFactory(sslContext.getSocketFactory());
            HttpsURLConnection.setDefaultHostnameVerifier((hostname, session) -> true);

            // Web servis istemcisini kullanarak isteklerinizi gönderin
            // ...

        } catch (Exception e) {
            e.printStackTrace();
        }

        try {
            // Web servis WSDL dosyasının URL'sini belirtin
             wsdlURL = new URL("https://test-dmz.param.com.tr/turkpos.ws/service_turkpos_test.asmx?wsdl");

            // Web servis adını ve namespace'ini belirtin
             serviceName = new QName("https://turkpos.com.tr/", "TurkPos_x0020_WS_x0020_TEST");
            // Servis nesnesini oluşturun
             service = Service.create(wsdlURL, serviceName);

            // İstemci arabirimini alın
             client = service.getPort(TurkPosX0020WSX0020TESTSoap.class);


             //her metotda kullanacağımız güvenlik nesnemizi global olarak tanımlayıp değerlerini veriyoruz

            sec=new STWSGuvenlik();
            sec.clientcode="10738";
            sec.clientpassword ="test";
            sec.clientusername="test";




        } catch (Exception e) {
            e.printStackTrace();
        }

    }
    public void tpIslemOdemeOnProvKapat(){

        // Aşağıdaki parametreleri, ödeme işleminin sonuç parametrelerine bulabilirsiniz.
        String guid  ="Ödeme işleminden dönen guid değeri";
        String provID ="Ödeme işleminden dönen provId dğeri";
        String tutar =" Ödemeye çevrilecek tutar";
        String siparisId ="Ödeme işleminin siparisId değeri";

        STTPIslemOdemeOnProvKapa result= client.tpIslemOdemeOnProvKapa(sec,guid,provID,tutar,siparisId);
        System.out.println(result.sonucStr);
        System.out.println(result.provID);
        System.out.println(result.sonuc);
        System.out.println(result.bankaSonucKod);
        System.out.println(result.bankAuthCode);
        System.out.println(result.bankExtra);;
        System.out.println(result.bankHostMsg);
        System.out.println(result.bankHostRefNum);
        System.out.println(result.bankTransID);
        System.out.println(result.dekontID);
        System.out.println(result.siparisID);
    }
    public void tpIslemIptalOnProv(){

        // Aşağıdaki parametreleri, ödeme işleminin sonuç parametrelerine bulabilirsiniz.
        String guid  ="Ödeme işleminden dönen guid değeri";
        String provID ="Ödeme işleminden dönen provId dğeri";
        String siparisId ="Ödeme işleminin siparisId değeri";
        STSonuc result = client.tpIslemIptalOnProv(sec,guid,provID,siparisId);
        System.out.println(result.bankaSonucKod);
        System.out.println(result.sonucStr);
        System.out.println(result.sonuc);
    }
    public void kkSaklama(){

        // Kart bilgileri test kart bilgileridir.

        STKKSaklama result= client.kkSaklama(sec,"4546711234567894","Nikola Tesla",
                "4546711234567894","12","26","000","","","");


        System.out.println(result.sonucStr);
        System.out.println(result.guid);
        System.out.println(result.guid);


        // Kart saklama metodundan geriye guid değer dönecektir. Bu guid değerin saklanması gerekmektedir.
        // Saklanmış olan kartı kullanabilmek için bu guid değerine ihtiyaç olacaktır.

    }
    public void kk_Sakli_Liste(){
        // Kart saklamadan dönen guid değeri ile saklanmış kartı geri çağırabilirsiniz

        STGenelSonuc result =  client.kkSakliListe(sec,"4546711234567894",
                "Kart saklama metodundan dönen guid değeri yazılmalıdır.");

        System.out.println(result.sonucStr);
        System.out.println(result.sonuc);
        System.out.println(result.dtBilgi);
    }
    public void ks_Kart_Sil(){

        // ks kart sil
    }
    public void kartDogrulama(){

        String creditCard = "4546711234567894";
        String month  = "12";
        String year = "26";
        String cvv="000";

        //ReturnURL doğrulama yapıldıktan sonra dönülecek bir web uygulaması adresidir. Bu adrese gelen Forms değeri kontrol edilmelidir.
        String returnUrl="http://localhost:8080";

        STTPIslemOdeme result= client.tpKKVerify(sec,creditCard,month,year,cvv,returnUrl,"","","","","");
    }
    public void tp_OzelOran_Liste(){

        String guid = "Firma Guid değeri";
        STGenelSonuc result= client.tpOzelOranListe(sec,guid);

        System.out.println(result.dtBilgi.any);
        System.out.println(result.sonucStr);
        System.out.println(result.sonuc);
    };

    public void TP_Islem_Izleme(){

        String guid = java.util.UUID.randomUUID().toString();
        String dateStart="";
        String dateEnd="";
        String transactionType="";
        String transactionState ="";
        
        client.tpIslemIzleme(sec,guid,dateStart,dateEnd,transactionType,transactionState);

    }
    public void TP_Islem_Sorgulama4(){

        String guid = java.util.UUID.randomUUID().toString();
        String receiptId="";
        String orderId="";
        String transactionId="";

        STGenelSonuc2 result = client.tpIslemSorgulama4(sec,guid,receiptId,orderId,transactionId);
        System.out.println(result.sonuc);
        System.out.println(result.sonucStr);

    }
    public void TP_Islem_Iptal_Iade_Kismi2(){

        String state = "IADE";
        String guid =java.util.UUID.randomUUID().toString();
        String order_Id = "";
        Double amount = 10.0;

        STSonucII result= client.tpIslemIptalIadeKismi2(sec,guid,state,order_Id,amount);
        System.out.println(result.sonucStr);
        System.out.println(result.sonuc);
        System.out.println(result.bankaSonucKod);
        System.out.println(result.bankExtra);
        System.out.println(result.bankAuthCode);
        System.out.println(result.bankHostRefNum);
        System.out.println(result.bankTransID);

    }
    public void tp_MutabakatOzet(){

        String start ="20.11.2015 00:00:00";
        String end = "20.11.2015 00:00:00";
        String guid =java.util.UUID.randomUUID().toString();
        STGenelSonuc result =client.tpMutabakatOzet(sec,guid,start,end);
        System.out.println(result.sonuc);
        System.out.println(result.sonucStr);

    }
    public void tp_OzelOranSK_Guncelle(){

        String guid = "Kullanıcı Guid değeri";
        String ozelOranSKID="";
        STSonuc result= client.tpOzelOranSKGuncelle(sec,guid,ozelOranSKID,"","","","","","","","","","","","");
        System.out.println(result.sonucStr);
        System.out.println(result.sonuc);
        System.out.println(result.bankaSonucKod);
    };
    public void tpMutabakatOzet(){

        String guid ="";
        String dateStart="20.11.2015 00:00:00";
        String dateEnd="20.11.2015 15:15:00";

        STGenelSonuc result= client.tpMutabakatOzet(sec,guid,dateStart,dateEnd);

        System.out.println(result.sonucStr);
        System.out.println(result.sonuc);
        System.out.println(result.dtBilgi.any);


    }
    public void tpIslemIptalIadeIsmi2(){

        //STSonucII result= client.tpIslemIptalIadeKismi2();

    }

    public void ReadXml(STGenelSonuc value) throws JAXBException {


        JAXBContext context = JAXBContext.newInstance(value.dtBilgi.any.getClass());
        Marshaller marshaller = context.createMarshaller();
        marshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);

        StringWriter writer = new StringWriter();
        marshaller.marshal(value.dtBilgi.any, writer);
        String result =writer.toString();
        //int a = 10;

    }
    public void BinSanalPos() throws JAXBException, ParserConfigurationException {

        STWSGuvenlik sec = new STWSGuvenlik();
        sec.setCLIENTCODE("10738");
        sec.setCLIENTPASSWORD("test");
        sec.setCLIENTUSERNAME("test");
        String bin ="454360";
        STGenelSonuc result = client.binSanalPos(sec,bin);
        //result.dtBilgi.any
        ReadXml(result);
        System.out.println(result.sonucStr);
    }
    public void il_Liste(){
       STSonucDT result = client.ilListe(sec);
        System.out.println(result.sonucStr);
        System.out.println(result.sonuc);
        System.out.println(result.dt.any);
    }





}
