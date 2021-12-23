using System;
using System.Collections.Generic;
using System.Text;

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
    }
}