using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.PageObjects
{

    public class AmazonPageObject
    {
        public const string Url = "https://www.amazon.in/";
        public const string SerachBoxXpath = "//input[@id='twotabsearchtextbox']";
        public const string SearchButtonXpath = "//input[@id='nav-search-submit-button']";
        public const string ReviewButton = "//div[@aria-label='4 Stars & Up']//span[@class='a-size-small a-color-base'][normalize-space()='& Up']";
        public const string MobileXpath = "//a[@class='a-link-normal s-underline-text s-underline-link-text s-link-style a-text-normal']//span[text()='Samsung Galaxy S21 FE 5G (Graphite, 8GB, 128GB Storage)']";
        public const string SeeAllReviewButtonXpath = "//div[@id='cr-pagination-footer-0']//a[@class='a-link-emphasis a-text-bold'][normalize-space()='See all reviews']";
        public const string NextButtonXpath = "//a[text()='Next page']";
    }
}
