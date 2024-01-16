using MongoDB.Driver;
using MongoDB.Driver.Core.Operations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Smart_green_system
{
    public partial class client_info : Form
    {
        static MongoCRUD db = new MongoCRUD("SmartGreen");
        public client_info()
        {
            InitializeComponent();
        }
        
        private bool IsBarcodeExists(string barcode)
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

        private void sumbit_Click(object sender, EventArgs e)
        {
            if(barcode_info.Text != string.Empty)
            {
                if (!IsBarcodeExists(barcode_info.Text))
                {
                    MessageBox.Show("לקום לא קיים במערכת");
                }
                else
                {
                    //ייבוא נתונים מהדאטה בייס
                    var collection = db.GetCollection<BsonDocument>("Users");
                    var convert = Convert.ToDouble(barcode_info.Text);
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
                    shop.Text = shop_res;
                    var ans = code - shop_t;
                    var ans_res = ans.ToString();
                    code_label.Text = ans_res;
                }

                
            }
            else
            {
                MessageBox.Show("הכנס ברקוד");
            }
          
        }

        private void code_label_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void shop_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
           
            if(barcode_info.Text != string.Empty)
            {
                if (MessageBox.Show("האם אתה רוצה למחוק את המשתמש?", "אזהרה", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var collection = db.GetCollection<BsonDocument>("Users");
                    var convert = Convert.ToDouble(barcode_info.Text);
                    var filter = Builders<BsonDocument>.Filter.Eq("qrcode", convert);
                    collection.DeleteOne(filter);
                    barcode_info.Text = string.Empty;
                    code_label.Text = string.Empty;
                    shop.Text = string.Empty;
                    MessageBox.Show("נמחק בהצלחה");
                }
                else
                {
                    MessageBox.Show("בוטל מחיקת משתמש");
                }
            }
            else
            {
                MessageBox.Show("תכניס ברקוד");
            }
           
           
        }

        private void add_shop_Click(object sender, EventArgs e)
        {
            if(barcode_info.Text != string.Empty)
            {
                var collection = db.GetCollection<BsonDocument>("Users");
                var convert = Convert.ToDouble(barcode_info.Text);
                var filter = Builders<BsonDocument>.Filter.Eq("qrcode", convert);
                var update = Builders<BsonDocument>.Update.Inc("shop_total", 1);
                var result = collection.UpdateOne(filter, update);
                code_label.Text = string.Empty;
                shop.Text = string.Empty;
                MessageBox.Show("עודכן בהצלחה");
            }
            else
            {
                MessageBox.Show("תכניס ברקוד");
            }
        }

        private void min_shop_Click(object sender, EventArgs e)
        {
            if(barcode_info.Text!= string.Empty)
            {
                
                var collection = db.GetCollection<BsonDocument>("Users");
                var convert = Convert.ToDouble(barcode_info.Text);
                var filter = Builders<BsonDocument>.Filter.Eq("qrcode", convert);
                var res = collection.Find(filter).FirstOrDefault();
                var shoptotal = res["shop_total"];
                var shoptotal_ans = Convert.ToDouble(shoptotal);

                if(shoptotal_ans > 0)
                {
                    var update = Builders<BsonDocument>.Update.Inc("shop_total", -1);
                    var result = collection.UpdateOne(filter, update);
                    code_label.Text = string.Empty;
                    shop.Text = string.Empty;
                    MessageBox.Show("עודכן בהצלחה");
                }
                else
                {
                    MessageBox.Show("כמות הקניות לא יכולה להיות קטנה מ0", "אזהרה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
    
             }
            else
            {
                MessageBox.Show("הכנס ברקוד");
            }
            
        }
    }
}
