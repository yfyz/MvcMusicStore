using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Maticsoft.Model;
using System.Data;
namespace MvcMusicStore.Models
{
    public class ShoppingCart
    {
        string ShoppingCartid { get; set; }
        public const String CartSessionKey = "CartId";
        /*
         * 将专辑作为参数加入到购物车中，在 Cart 表中跟踪每个专辑的数量，在这个方法中，我们将会检查是在表中增加一个新行，还是仅仅在用户已经选择的专辑上增加数量。
         */
        public void AddToCart(album album)
        {
            Maticsoft.BLL.cart item=  new Maticsoft.BLL.cart();
            List<Maticsoft.DAL.SqlWhereClass> lssqlwhere = new List<Maticsoft.DAL.SqlWhereClass>();
            Maticsoft.DAL.SqlWhereClass sqlwhere = new Maticsoft.DAL.SqlWhereClass("CartId","CartId",Maticsoft.DAL.NetOperate.EQ,"'"+ShoppingCartid+"'");
            lssqlwhere.Add(sqlwhere);
            sqlwhere = new Maticsoft.DAL.SqlWhereClass("AlbumId", "AlbumId",Maticsoft.DAL.NetOperate.EQ,album.AlbumId.ToString());
            lssqlwhere.Add(sqlwhere);
            var CartItem=  item.GetModel(lssqlwhere);
          
                if(CartItem==null)
                {
                    CartItem = new cart
                    {
                        AlbumId = album.AlbumId,
                        CartId = ShoppingCartid,
                        Count = 1,
                        DateCreated = DateTime.Now

                    };
                    item.Add(CartItem);
                }
                else
                {
                    CartItem.Count++;
                    item.Update(CartItem);
                }
             
        }
        /*通过专辑的标识从用户的购物车中将这个专辑的数量减少 1，如果用户仅仅剩下一个，那么就删除这一行。*/
        public int RemoveFromCart(int id)
        {
            
            Maticsoft.BLL.cart item = new Maticsoft.BLL.cart();
            List<Maticsoft.DAL.SqlWhereClass> lssqlwhere = new List<Maticsoft.DAL.SqlWhereClass>();
            Maticsoft.DAL.SqlWhereClass sqlwhere = new Maticsoft.DAL.SqlWhereClass("CartId", "CartId", Maticsoft.DAL.NetOperate.EQ, "'"+ShoppingCartid+"'");
            lssqlwhere.Add(sqlwhere);
            sqlwhere = new Maticsoft.DAL.SqlWhereClass("RecordId", "RecordId", Maticsoft.DAL.NetOperate.EQ, id.ToString());
         
            var CartItem = item.GetModel(lssqlwhere);
              
            int itemcount = 0;
            if (CartItem != null)
            {
                if (CartItem.Count > 1)
                {
                    CartItem.Count--;
                    itemcount = CartItem.Count;
                }
                else
                {
                    item.Delete(id);
                }
            }
            return itemcount;
        }
        /*
         * 删除用户购物车中所有的项目
         */
        public void EmptyCart()
        {
              Maticsoft.BLL.cart item = new Maticsoft.BLL.cart();
              var cartItems = item.GetModelList("CartId=" + "'"+ShoppingCartid+"'");
              string  recordList="";
              int index = 0;
              foreach (var cartitem in cartItems)
              {
                  if (++index == cartItems.Count)
                  {
                     recordList += cartitem.RecordId.ToString();
                 }
                  else
                  {
                      recordList += cartitem.RecordId.ToString() + ",";
                  }
                
             }
              item.DeleteList(recordList);
        }
        /*
         *获取购物项目的列表用来显示或者处理。 
         */
        public List<cart> GetCartItems()
        {  
            Maticsoft.BLL.cart item = new Maticsoft.BLL.cart();

          //  return item.GetModelList("CartId='" + ShoppingCartid+"'");
            return item.GetListWithAlbum("CartId='" + ShoppingCartid + "'");
        }
        /*
         * 获取用户购物车中专辑的数量
         */
        public int GetCount()
        {
              Maticsoft.BLL.cart item = new Maticsoft.BLL.cart();
            /*
             List<cart> lscart=   item.GetModelList("1=1");
             int total = (from cartItem in lscart
                          where cartItem.CartId == ShoppingCartid
                          select cartItem.Count).Sum();
            */
            int count =item.GetCartCount("CartId='"+ShoppingCartid+"'");
            return count;
        }
        /*
         * 获取购物车中商品的总价
         */
        public decimal GetTotal()
        {
            Maticsoft.BLL.cart item = new Maticsoft.BLL.cart();

            return item.GetTotalPrice(ShoppingCartid);
        }
        /*
         * 将购物车转换为结账处理过程中的订单。
         */
        public int  CreateOrder( musicorder order)
        {
            Maticsoft.BLL.cart itembll = new Maticsoft.BLL.cart();
            var cartItems = GetCartItems();
            
            foreach (var item in cartItems)
            {
                var orderDetail =new orderdetail
                {
                    AlbumId =item.AlbumId,
                    OrderId =order.OrderId,
                    Quantity=item.Count,
                    UnitPrice = itembll.GetUnitprice(item.AlbumId)   
                };
                Maticsoft.BLL.orderdetail orderdetailbll = new Maticsoft.BLL.orderdetail();
                orderdetailbll.Add(orderDetail);
            }
            order.Total = GetTotal();
            EmptyCart();
            return order.OrderId;
        }
        /*
         * 这是一个静态方法，用来获取当前用户的购物车对象，它使用 GetCartId 方法来读取保存当前 Session 中的购物车标识，GetCartId 方法需要 HttpContextBase 以便获取当前的 Session。
         */
        public static ShoppingCart  GetCart( HttpContextBase context)
        {
            var cart =new ShoppingCart();
            cart.ShoppingCartid=cart.GetCartId(context);
            return cart;
        }
        //访问cookies
        public string GetCartId(HttpContextBase context)
        {
            if(context.Session[CartSessionKey] ==null)
            {
                if(!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[CartSessionKey]=context.User.Identity.Name;

                }else
                {
                    Guid tempCartId=Guid.NewGuid();
                    context.Session[CartSessionKey]=tempCartId.ToString();
                }
            }
            return context.Session[CartSessionKey].ToString();
        }
        public void MigrateCart(string userName)
        {
            Maticsoft.BLL.cart cartbll =new Maticsoft.BLL.cart();
            List<Maticsoft.DAL.SqlWhereClass> lssqlwhere = new List<Maticsoft.DAL.SqlWhereClass>();
            Maticsoft.DAL.SqlWhereClass sqlwhere = new Maticsoft.DAL.SqlWhereClass("CartId","CartId",Maticsoft.DAL.NetOperate.EQ,"'"+ShoppingCartid+"'");
            lssqlwhere.Add(sqlwhere);
            var cartitem=  cartbll.GetModel(lssqlwhere);
            if (cartitem == null)
            {
                return;
            }
            cartitem.CartId = userName;
            cartbll.Update(cartitem);
          
        }
    }
}