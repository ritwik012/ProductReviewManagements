using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Program");
            List<ProductReview> productList = new List<ProductReview>
            {
                new ProductReview() { ProductID = 1, UserID = 32, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() { ProductID = 5, UserID = 56, Rating = 3, Review = "Better", IsLike = true},
                new ProductReview() { ProductID = 86, UserID = 71, Rating = 2, Review = "Poor", IsLike = false},
                new ProductReview() { ProductID = 5, UserID = 99, Rating = 5, Review = "Great", IsLike = true},
                new ProductReview() { ProductID = 66, UserID = 44, Rating = 4, Review = "Good", IsLike = true},
                new ProductReview() { ProductID = 7, UserID = 80, Rating = 3, Review = "Better", IsLike = true},
                new ProductReview() { ProductID = 4, UserID = 71, Rating = 5, Review = "Great", IsLike = true},
                new ProductReview() { ProductID = 56, UserID = 76, Rating = 1, Review = "Bad", IsLike = false},
                new ProductReview() { ProductID = 88, UserID = 32, Rating = 2, Review = "Poor", IsLike = false},
                new ProductReview() { ProductID = 9, UserID = 47, Rating = 4, Review = "Good", IsLike = true},
            };
            bool flag = true;
            Management management = new Management();
            while (flag)
            {
                Console.WriteLine("Enter the Program that you want to be executed : \n 1. Displaying of Products List \n 2. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        management.Display(productList);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}