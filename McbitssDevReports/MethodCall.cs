using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static McbitssDevReports.Models.ReportModel;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Newtonsoft.Json;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using static McbitssDevReports.Models.IndiaDataModel;

namespace McbitssDevReports
{
    public class MethodCall
    {
      static  string _Country, _Role, _Month, _year,_Emp;
        public List<RootObject> data()
        {
            // Testing Push
            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("spmapi-dev");
            MongoCollection symbolcollection = database.GetCollection<BsonDocument>("swisspayrolls");
            var symbol = symbolcollection.AsQueryable<BsonDocument>().ToList();


            // RootObject rootObject = new RootObject();
            List<RootObject> h = new List<RootObject>();
            // var document = new BsonDocument("_id", ObjectId.GenerateNewId());
            var jsonWriterSettings = new JsonWriterSettings { OutputMode = JsonOutputMode.Strict }; // key part
                                                                                                    // var s = document.ToJson(jsonWriterSettings);
            foreach (BsonDocument document in symbol)
            {
                //  Console.WriteLine(document.ToJson(jsonWriterSettings));
                //  var s = document.ToJson(jsonWriterSettings);
                // JObject json = JObject.Parse(document.ToJson<MongoDB.Bson.BsonDocument>(jsonWriterSettings));
                // var jsonString = JsonConvert.SerializeObject(document.ConvertAll(d => BsonTypeMapper.MapToDotNetValue(d)), Formatting.Indented)
                //var myObj = JsonConvert.DeserializeObject<RootObject>(s.ToString());
                object val = BsonTypeMapper.MapToDotNetValue(document);
                string jsonString = JsonConvert.SerializeObject(val);
                string x = jsonString.Replace("_", string.Empty);
                var myObj = JsonConvert.DeserializeObject<RootObject>(x);
                h.Add(myObj);



            }
            if (_Month==null ||_Month==string.Empty)
            {

                var Swisspayroll = (from p in h
                                    where p.employee == _Emp
                                    select new RootObject()
                                    {
                                        id = p.id,
                                        employee = p.employee,
                                        company = p.company,
                                        branch = p.branch,
                                        payroll = p.payroll.Where(t => t.salaryYear == _year ).ToList(),
                                    }).ToList();

                return Swisspayroll;
            }
            else {
                var Swisspayroll = (from p in h
                                    where p.employee == _Emp
                                    select new RootObject()
                                    {
                                        id = p.id,
                                        employee = p.employee,
                                        company = p.company,
                                        branch = p.branch,
                                        payroll = p.payroll.Where(t => t.salarymonth == _Month && t.salaryYear == _year).ToList(),
                                    }).ToList();

                return Swisspayroll;
            }
        }

        public void userData(string country, string role, string year, string month,string emp)
        {

            _Role = role;
            _Country = country;
            _year = year;
            _Month = month;
            _Emp = emp;
        }

        public List<RootObjectIndia> IndiaData()
        {

            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("spmapi-dev");
            MongoCollection symbolcollection = database.GetCollection<BsonDocument>("payrollprocesses");
            var symbol = symbolcollection.AsQueryable<BsonDocument>().ToList();


            // RootObject rootObject = new RootObject();
            List<RootObjectIndia> h = new List<RootObjectIndia>();
            // var document = new BsonDocument("_id", ObjectId.GenerateNewId());
            var jsonWriterSettings = new JsonWriterSettings { OutputMode = JsonOutputMode.Strict }; // key part
                                                                                                    // var s = document.ToJson(jsonWriterSettings);
            foreach (BsonDocument document in symbol)
            {
                //  Console.WriteLine(document.ToJson(jsonWriterSettings));
                //  var s = document.ToJson(jsonWriterSettings);
                // JObject json = JObject.Parse(document.ToJson<MongoDB.Bson.BsonDocument>(jsonWriterSettings));
                // var jsonString = JsonConvert.SerializeObject(document.ConvertAll(d => BsonTypeMapper.MapToDotNetValue(d)), Formatting.Indented)
                //var myObj = JsonConvert.DeserializeObject<RootObject>(s.ToString());
                object val = BsonTypeMapper.MapToDotNetValue(document);
                string jsonString = JsonConvert.SerializeObject(val);

                string x =jsonString.Replace("_", string.Empty);
                var myObj = JsonConvert.DeserializeObject<RootObjectIndia>(x);
                h.Add(myObj);



            }

            if (_Month == null || _Month == string.Empty)
            {

                var Swisspayroll = (from p in h
                                    where p.employee == _Emp
                                    select new RootObjectIndia()
                                    {
                                        //id = p.id,
                                        employee = p.employee,
                                        company = p.company,
                                        //branch = p.branch,
                                        payroll = p.payroll.Where(t => t.salaryYear == Convert.ToInt32(_year)).ToList(),


                                    }).ToList();

                return Swisspayroll;
            }
            else
            {
                var Swisspayroll = (from p in h
                                    where p.employee == _Emp
                                    select new RootObjectIndia()
                                    {
                                        //id = p.id,
                                        employee = p.employee,
                                        company = p.company,
                                        //branch = p.branch,
                                        payroll = p.payroll.Where(t => t.salarymonth == _Month && t.salaryYear == Convert.ToInt32(_year)).ToList(),


                                    }).ToList();

                return Swisspayroll;
            }

        }

        public List<RootObjectIndia> userData()
        {

            MongoClient client = new MongoClient("mongodb://localhost");
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("spmapi-dev");
            MongoCollection symbolcollection = database.GetCollection<BsonDocument>("employees");
            // TestMongoQuery(symbolcollection);
            List<RootObjectIndia> h = new List<RootObjectIndia>();
           

            var symbol = symbolcollection.AsQueryable<BsonDocument>().ToList();


            // RootObject rootObject = new RootObject();

            // var document = new BsonDocument("_id", ObjectId.GenerateNewId());
            //var jsonWriterSettings = new JsonWriterSettings { OutputMode = JsonOutputMode.Strict }; // key part
            //                                                                                        // var s = document.ToJson(jsonWriterSettings);
            foreach (BsonDocument document in symbol)
            {
                //  Console.WriteLine(document.ToJson(jsonWriterSettings));
                //  var s = document.ToJson(jsonWriterSettings);
                // JObject json = JObject.Parse(document.ToJson<MongoDB.Bson.BsonDocument>(jsonWriterSettings));
                // var jsonString = JsonConvert.SerializeObject(document.ConvertAll(d => BsonTypeMapper.MapToDotNetValue(d)), Formatting.Indented)
                //var myObj = JsonConvert.DeserializeObject<RootObject>(s.ToString());
                object val = BsonTypeMapper.MapToDotNetValue(document);
                string jsonString = JsonConvert.SerializeObject(val);

                string x = jsonString.Replace("_", string.Empty);
                var myObj = JsonConvert.DeserializeObject<RootObjectIndia>(x);
                h.Add(myObj);



            }
            var Swisspayroll = (from p in h
                                where p.employee == "5abb5ccba6a86d39184073d4"
                                select new RootObjectIndia()
                                {
                                    //id = p.id,
                                    employee = p.employee,
                                    company = p.company,
                                    //branch = p.branch,
                                    payroll = p.payroll.Where(t => t.salarymonth == "March" && t.salaryYear == 2018).ToList(),


                                }).ToList();

            return Swisspayroll;
        }

       

        //static async void TestMongoQuery(MongoCollection symbolcollection)
        //{
           
        //    using (var allDocs =  symbolcollection.FindAsync(FilterDefinition<BsonDocument>.Empty))
        //    {
        //        while (allDocs.MoveNext())
        //        {
        //            foreach (var doc in allDocs.Current)
        //            {
        //                var duplicateElements = doc.Elements.Where(c => c.Name == "DuplicateCol");
        //                foreach (var el in duplicateElements)
        //                {
        //                    Console.WriteLine(el.Name + ":" + el.Value);
        //                }
        //            }
        //        }
        //    }
        //}
    }
}