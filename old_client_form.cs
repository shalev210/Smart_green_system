using MongoDB.Driver;
using MongoDB.Driver.Core.Operations;
using MongoDB.Bson.IO;
using MongoDB.Driver.Core.Events.Diagnostics;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Smart_green_system
{
    public partial class old_client_form : Form
    {
        static MongoCRUD db = new MongoCRUD("SmartGreen");

        public old_client_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(barcode.Text != string.Empty)
            {
                bool barcodeExists = IsBarcodeExists(barcode.Text);
                if (barcodeExists)
                {
                    var collection = db.GetCollection<BsonDocument>("Users");
                    var convert = Convert.ToDouble(barcode.Text);
                    var filter = Builders<BsonDocument>.Filter.Eq("qrcode", convert);
                    var res = collection.Find(filter).FirstOrDefault();

                    var shoptotal = res["shop_total"];
                    var price = res["price"];
                    //להמיר את price
                    var code = Convert.ToDouble(price);
                    var code_res = code.ToString();


                    // להמיר את shoptotal
                    var shop_t = Convert.ToDouble(shoptotal);
                    var shop_res = shop_t.ToString();

                    //הצגה במסך
                    payment_label.Text = code_res;
                    Discount.Text = shop_res;
                    var ans = code - shop_t;
                    var show = ans.ToString();
                    Total_price.Text = show;

                }
                else
                {
                    MessageBox.Show("לא קיים לקוח כזה במערכת");
                    payment_label.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("הכנס ברקוד");
            }
            

        }
        public bool IsBarcodeExists(string barcode)
        {
            if (double.TryParse(barcode, out double barcodeValue))
            {
                var collection = db.GetCollection<QRcode>("Users");
                var exists = collection.AsQueryable().Any(x => x.qrcode == barcodeValue);
                return exists;
            }
            else
            {
                
                return false;
            }
        }
        

        private void updata_Click(object sender, EventArgs e)
        {
            if(barcode.Text != string.Empty)
            {
                var collection = db.GetCollection<BsonDocument>("Users");
                var convert = Convert.ToDouble(barcode.Text);
                var filter = Builders<BsonDocument>.Filter.Eq("qrcode", convert);
                var update = Builders<BsonDocument>.Update.Inc("shop_total", 1);
                var result = collection.UpdateOne(filter, update);
                payment_label.Text = string.Empty;
                Discount.Text = string.Empty;
                Total_price.Text = string.Empty;
                barcode.Text = string.Empty;
                MessageBox.Show("בוצע בהצלחה");
            }
            else
            {
                MessageBox.Show("הכנס ברקוד");
            }
           
        }
    }
}
