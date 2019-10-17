using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_3_29834643.Models.Repository
{
    public class OrdersCollection
    {
        internal MongoDBReps repo = new MongoDBReps("mongodb://127.0.0.1:27017", "superStoredb");

        public string[] shipmethods;
       public long[] Totals = new long[4];
        public string[] prodCategory;
        public string[] yearname = { "2012", "2013", "2014", "2015" };
        //Collection name in the database
        private const string _collectionName = "Orders";

        //Contains all documents inside the collection
        public IMongoCollection<SuperstoreOrders> Collection;

        public OrdersCollection()
        {
            this.Collection = repo.Db.GetCollection<SuperstoreOrders>(_collectionName);
        }

        public List<SuperstoreOrders> SelectAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
            
        }
        public void datalabels()
        {
            List<SuperstoreOrders> myorders = this.Collection.AsQueryable<SuperstoreOrders>().ToList();
            //shipment modes/type of shipment
            shipmethods = this.Collection.AsQueryable<SuperstoreOrders>().Select(e => e.Ship_Mode).Distinct();
            prodCategory = this.Collection.AsQueryable<SuperstoreOrders>().Select(e => e.Category).Distinct();
            ptype = this.Collection.AsQueryable<SuperstoreOrders>().Select(e => e.Sub_Category).Distinct();


        }
        public int[] OrdersTotals()

        {

            List<SuperstoreOrders> myorders = this.Collection.AsQueryable<SuperstoreOrders>().ToList();
            int[] yearTotals = new int[4];
        

            for (int k = 0; k < 4; k++)
            {
                string yr = yearname[k];
                int total2012 = (from x in myorders.Where(x => x.Order_Date.Contains(yr)) select x.Order_Date).Count();
                yearTotals[k] = total2012;
            }

            return yearTotals;
            
        }
        public int[] ShipmentMode()
        {
            List<SuperstoreOrders> myorders = this.Collection.AsQueryable<SuperstoreOrders>().ToList();
            int[] Shiptot = new int[4];


            for (int k = 0; k < 4; k++)
            {
                string ty = shipmethods[k];
                int mode = (from x in myorders.Where(x => x.Ship_Mode.Contains(ty)) select x.Ship_Mode).Count();
                Shiptot[k] = mode;
            }
           
            
            
            return Shiptot;


        }
        public int[] first = new int[4];
        public int[] second = new int[4];
        public int[] standard = new int[4];
        public int[] same = new int[4];
        public string[] ptype;
        public void ShipmentPriority()
        {
           
            List<SuperstoreOrders> myorders = this.Collection.AsQueryable<SuperstoreOrders>().ToList();
            for (int k = 0; k < 4; k++)
            {

                string priority = shipmethods[k];
                first[k] = (from x in myorders.Where(x => x.Ship_Mode.Contains("High") && x.Order_Priority.Contains(priority)) select x.Order_Date).Count();

            }
            for (int k = 0; k < 4; k++)
            {

                string priority = shipmethods[k];
                second[k] = (from x in myorders.Where(x => x.Ship_Mode.Contains("Medium") && x.Order_Priority.Contains(priority)) select x.Order_Date.Contains(priority)).Count();

            }
            for (int k = 0; k < 4; k++)
            {

                string priority = shipmethods[k];
                standard[k] = (from x in myorders.Where(x => x.Ship_Mode.Contains("Low") && x.Order_Priority.Contains(priority)) select x.Order_Date.Contains(priority)).Count();

            }
            for (int k = 0; k < 4; k++)
            {

                string priority = shipmethods[k];
                same[k] = (from x in myorders.Where(x => x.Ship_Mode.Contains("Critical") && x.Order_Priority.Contains(priority)) select x.Order_Date.Contains(priority)).Count();

            }
            

        }
        public long[] ShipmentCost()
        {
            List<SuperstoreOrders> myorders = this.Collection.AsQueryable<SuperstoreOrders>().ToList();
            long []totalcost =new long [4];
            //var Total = _collection.AsQueryable().Where(x => x.ClientId == 2).Sum(x => x.Cash);
            for (int k = 0; k < 4; k++)
            {
               // string ty = shipmethods[k];
                //string cost = this.Collection.AsQueryable().Where(x => x.Ship_Mode == ty).Sum(x => x.Shipping_Cost);
                //totalcost[k] = cost;
            }



            return totalcost;
        }

        public int[] Totals2012 = new int[4];
        public int[] Totals2013 = new int[4];
        public int[] Totals2014 = new int[4];
        public int[] Totals2015 = new int[4];
        public void ProductTypesSold()
        {
            List<SuperstoreOrders> myorders = this.Collection.AsQueryable<SuperstoreOrders>().ToList();
          
            for (int k = 0; k < 4; k++)
            {

                string categ = yearname[k];
                Totals2012[k] = (from x in myorders.Where(x => x.Category.Contains("Technology") && x.Order_Date.Contains(categ)) select x.Order_Date).Count();
               
            }
            for (int k = 0; k < 4; k++)
            {

                string categ = yearname[k];
                Totals2013[k] = (from x in myorders.Where(x => x.Category.Contains("Office Supplies") && x.Order_Date.Contains(categ)) select x.Order_Date.Contains(categ)).Count();
                
            }
            for (int k = 0; k < 4; k++)
            {

                string categ = yearname[k];
                Totals2014[k] = (from x in myorders.Where(x => x.Category.Contains("Furniture") && x.Order_Date.Contains(categ)) select x.Order_Date.Contains(categ)).Count();
               
            }
           
          

        }
        }
}
