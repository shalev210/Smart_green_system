using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.Configuration;
using MongoDB.Bson;

namespace Smart_green_system
{
    public partial class new_client_form : Form
    {
        static MongoCRUD db = new MongoCRUD("SmartGreen");
        public new_client_form()
        {
            InitializeComponent();

        }




        private void add_new_client_button_Click(object sender, EventArgs e)
        {
            if(Display_Qrcodr.Text != string.Empty)
            {
                double qrcode_text = double.Parse(Display_Qrcodr.Text);
                bool isQrcodeExists = IsQrcodeExists(qrcode_text);
                if (isQrcodeExists)
                {
                    MessageBox.Show("קיים לקוח כבר במערכת");
                    Display_Qrcodr.Text = string.Empty;
                }
                else
                {
                    QRcode mycode = new QRcode { qrcode = qrcode_text, shop_total = 0, price = 11 };
                    Console.WriteLine(mycode);
                    db.insertRecord("Users", mycode); ;
                    MessageBox.Show("לקוח הוכנס בהצלחה");
                    Display_Qrcodr.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("הכנס ברקוד");
            }
            

        }
        private bool IsQrcodeExists(double qrcode)
        {
            var filter = Builders<QRcode>.Filter.Eq(x => x.qrcode, qrcode);
            var collection = db.GetCollection<QRcode>("Users");

            return collection.Find(filter).Any();
        }



    }
    public class QRcode
    {
        [BsonId]
        public Guid Id { get; set; }
        public double qrcode { get; set; }
        public double price { get; set; }
        public double shop_total {  get; set; }
        public Guid GetId()
        {
            return Id;
        }

    }
    public class MongoCRUD
    {
        public IMongoDatabase db;
        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }
        public IMongoCollection<T> GetCollection<T>(string table)
        {
            return db.GetCollection<T>(table);
        }

        public void insertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }
        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

       



    }
}

