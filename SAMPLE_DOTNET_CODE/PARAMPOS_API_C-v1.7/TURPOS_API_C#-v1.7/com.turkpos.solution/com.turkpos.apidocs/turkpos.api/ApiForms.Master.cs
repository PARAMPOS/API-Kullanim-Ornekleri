using com.turkpos.apidocs.tr.com.ew.dmzws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace com.turkpos.apidocs.turkpos.api {
    public partial class ApiForms : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {

        }

        public ST_WS_Guvenlik GuvenlikNesnesi() {

            var stws = new ST_WS_Guvenlik() {
                CLIENT_CODE = "10738",
                CLIENT_USERNAME = "Test",
                CLIENT_PASSWORD = "Test"
            };
            return stws;

        }
        public com.turkpos.apidocs.tr.com.ew.dmzws.ST_WS_Guvenlik GuvenlikNesnesiProd() {

            var stws = new com.turkpos.apidocs.tr.com.ew.dmzws.ST_WS_Guvenlik() {
                CLIENT_CODE = "10738",
                CLIENT_USERNAME = "Test",
                CLIENT_PASSWORD = "Test"
            };
            return stws;

        }

        public com.turkpos.apidocs.tr.com.ew.dmzws1.ST_WS_Guvenlik GuvenlikNesnesiKSProd()
        {

            var stws = new com.turkpos.apidocs.tr.com.ew.dmzws1.ST_WS_Guvenlik()
            {
                CLIENT_CODE = 10738,
                CLIENT_USERNAME = "Test",
                CLIENT_PASSWORD = "Test"
            };
            return stws;

        }

        public void Info(String info) {

            lblError.Text = "";
            lblInfo.Text = info;

        }

        public void Error(String error) {

            lblInfo.Text = "";
            lblError.Text = error;

        }

    }
}