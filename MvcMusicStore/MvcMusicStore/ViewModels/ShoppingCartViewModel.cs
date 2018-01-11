using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Maticsoft.Model;
using System.Web.Mvc;
namespace MvcMusicStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<cart> CartItems { get; set; }
        public decimal CartTotal { get; set; } //购物总价
    }
}