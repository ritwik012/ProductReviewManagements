using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagement
{
    public class Management
    {
        public void Display(List<ProductReview> productList)
        {
            foreach (ProductReview pro in productList)
            {
                Console.WriteLine("ProductId : {0} \t UserId : {1} \t Rating : {2} \t Review : {3} \t IsLike : {4}", pro.ProductID, pro.UserID, pro.Rating, pro.Review, pro.IsLike);
            }
        }
        public void TopThreeRatingRecords(List<ProductReview> productList)
        {
            var records = (from Product in productList orderby Product.Rating descending select Product).Take(3).ToList();
            Display(records);
        }
        public void RetrieveRecordsUsingProductId(List<ProductReview> productList)
        {
            var records = (from Product in productList where (Product.ProductID == 1 || Product.ProductID == 4 || Product.ProductID == 9) && Product.Rating > 3 select Product).ToList();
            Display(records);
        }
        public void RetrieveCountOfRecords(List<ProductReview> productList)
        {
            var records = productList.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var data in records)
            {
                Console.WriteLine("The Number of records for Product ID : {0} are {1}", data.ProductID, data.Count);
            }
        }
        public void RetrieveOnlyProductIdAndReview(List<ProductReview> productList)
        {
            var records = from Product in productList select new { Product.ProductID, Product.Review };
            foreach (var data in records)
            {
                Console.WriteLine("ProductID : " + data.ProductID + "\t" + " Review : " + data.Review);
            }
        }
        public void SkipTopFiveRecords(List<ProductReview> productList)
        {
            var records = (from Product in productList select Product).Skip(5).ToList();
            Display(records);
        }
    }
}