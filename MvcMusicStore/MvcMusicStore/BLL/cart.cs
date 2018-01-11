using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
using Maticsoft.DAL;
namespace Maticsoft.BLL
{
	/// <summary>
	/// cart
	/// </summary>
	public partial class cart
	{
		private readonly Maticsoft.DAL.cart dal=new Maticsoft.DAL.cart();
		public cart()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int RecordId)
		{
			return dal.Exists(RecordId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.cart model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.cart model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int RecordId)
		{
			
			return dal.Delete(RecordId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string RecordIdlist )
		{
			return dal.DeleteList(RecordIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.cart GetModel(int RecordId)
		{
			
			return dal.GetModel(RecordId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.cart GetModelByCache(int RecordId)
		{
			
			string CacheKey = "cartModel-" + RecordId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(RecordId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.cart)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.cart> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.cart> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.cart> modelList = new List<Maticsoft.Model.cart>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.cart model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod
        public Maticsoft.Model.cart ExistsCart(string CartId, int AlbumId)
        {
            return dal.ExistsCart(CartId, AlbumId);
        }
        public Maticsoft.Model.cart GetModel(List<SqlWhereClass> lssqlwhere)
        {
            return dal.GetModel(lssqlwhere);
        }
         ///获得购物车中专辑数量的总数
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetCartCount(string strWhere)
        {
            return dal.GetCartCount(strWhere);
        }
        public decimal GetTotalPrice(string CartId)
        {
            return dal.GetTotalPrice(CartId);
        }
        //得到订单中物品的单价
        public decimal GetUnitprice(int AlbumId)
        {
            return dal.GetUnitprice(AlbumId);
        }
        public List<Maticsoft.Model.cart> GetListWithAlbum(string strWhere)
        {
            ModelHandler<Maticsoft.Model.cart> tomodel = new ModelHandler<Model.cart>();
            DataSet ds = dal.GetListWithAlbum(strWhere);
            ModelHandler<Maticsoft.Model.album> albummodel = new ModelHandler<Model.album>();
            List<Maticsoft.Model.cart> cartlist = new List<Model.cart>();
            List<Maticsoft.Model.album> albumlist = new List<Model.album>();

             albumlist= albummodel.ConvertToList(ds.Tables[0]);
            cartlist=tomodel.ConvertToList(ds.Tables[0]);
            foreach (var cartitem in cartlist)
            {
                cartitem.Album = albumlist.Find(albumitem => albumitem.AlbumId == cartitem.AlbumId);
            }
            return cartlist;
        }
		#endregion  ExtensionMethod
	}
}

