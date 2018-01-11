using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
using System.Collections.Generic;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:cart
	/// </summary>
	public partial class cart
	{
		public cart()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("RecordId", "cart"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int RecordId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from cart");
			strSql.Append(" where RecordId=@RecordId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@RecordId", MySqlDbType.Int32,11)			};
			parameters[0].Value = RecordId;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.cart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into cart(");
			strSql.Append("RecordId,CartId,AlbumId,Count,DateCreated)");
			strSql.Append(" values (");
			strSql.Append("@RecordId,@CartId,@AlbumId,@Count,@DateCreated)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@RecordId", MySqlDbType.Int32,11),
					new MySqlParameter("@CartId", MySqlDbType.VarChar,50),
					new MySqlParameter("@AlbumId", MySqlDbType.Int32,11),
					new MySqlParameter("@Count", MySqlDbType.Int32,11),
					new MySqlParameter("@DateCreated", MySqlDbType.DateTime)};
			parameters[0].Value = model.RecordId;
			parameters[1].Value = model.CartId;
			parameters[2].Value = model.AlbumId;
			parameters[3].Value = model.Count;
			parameters[4].Value = model.DateCreated;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.cart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update cart set ");
			strSql.Append("CartId=@CartId,");
			strSql.Append("AlbumId=@AlbumId,");
			strSql.Append("Count=@Count,");
			strSql.Append("DateCreated=@DateCreated");
			strSql.Append(" where RecordId=@RecordId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CartId", MySqlDbType.VarChar,50),
					new MySqlParameter("@AlbumId", MySqlDbType.Int32,11),
					new MySqlParameter("@Count", MySqlDbType.Int32,11),
					new MySqlParameter("@DateCreated", MySqlDbType.DateTime),
					new MySqlParameter("@RecordId", MySqlDbType.Int32,11)};
			parameters[0].Value = model.CartId;
			parameters[1].Value = model.AlbumId;
			parameters[2].Value = model.Count;
			parameters[3].Value = model.DateCreated;
			parameters[4].Value = model.RecordId;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int RecordId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from cart ");
			strSql.Append(" where RecordId=@RecordId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@RecordId", MySqlDbType.Int32,11)			};
			parameters[0].Value = RecordId;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string RecordIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from cart ");
			strSql.Append(" where RecordId in ("+RecordIdlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.cart GetModel(int RecordId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RecordId,CartId,AlbumId,Count,DateCreated from cart ");
			strSql.Append(" where RecordId=@RecordId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@RecordId", MySqlDbType.Int32,11)			};
			parameters[0].Value = RecordId;

			Maticsoft.Model.cart model=new Maticsoft.Model.cart();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.cart DataRowToModel(DataRow row)
		{
			Maticsoft.Model.cart model=new Maticsoft.Model.cart();
			if (row != null)
			{
				if(row["RecordId"]!=null && row["RecordId"].ToString()!="")
				{
					model.RecordId=int.Parse(row["RecordId"].ToString());
				}
				if(row["CartId"]!=null)
				{
					model.CartId=row["CartId"].ToString();
				}
				if(row["AlbumId"]!=null && row["AlbumId"].ToString()!="")
				{
					model.AlbumId=int.Parse(row["AlbumId"].ToString());
				}
				if(row["Count"]!=null && row["Count"].ToString()!="")
				{
					model.Count=int.Parse(row["Count"].ToString());
				}
				if(row["DateCreated"]!=null && row["DateCreated"].ToString()!="")
				{
					model.DateCreated=DateTime.Parse(row["DateCreated"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RecordId,CartId,AlbumId,Count,DateCreated ");
			strSql.Append(" FROM cart ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM cart ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.RecordId desc");
			}
			strSql.Append(")AS Row, T.*  from cart T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "cart";
			parameters[1].Value = "RecordId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public Maticsoft.Model.cart ExistsCart(string CartId,int AlbumId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RecordId,CartId,AlbumId,Count,DateCreated from cart ");
            strSql.Append(" where CartId=@CartId ");
            strSql.Append("and AlbumId=@AlbumId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@CartId", MySqlDbType.String,50),
                     new MySqlParameter("@AlbumId", MySqlDbType.Int32,11)                     
                                          };
            parameters[0].Value = "'"+CartId+"'";
            parameters[1].Value = AlbumId;

            Maticsoft.Model.cart model = new Maticsoft.Model.cart();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        public Maticsoft.Model.cart GetModel(List<SqlWhereClass> lssqlwhere)
        {
            String sqlcmd = SqlWhereClass.GetListSqlWhereString(lssqlwhere, false);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RecordId,CartId,AlbumId,Count,DateCreated from cart where ");
            strSql.Append(sqlcmd);
            Maticsoft.Model.cart model = new Maticsoft.Model.cart();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        ///获得购物车中专辑数量的总数
        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetCartCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(Count) FROM cart ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        //得到订单的总价
        public decimal GetTotalPrice(string CartId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(c.Count*a.Price ) as totalPrice from cart as c LEFT JOIN Album as a ON c.AlbumId=a.AlbumId  WHERE c.CartId='"+CartId+"'");

            object obj = DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        //得到订单中物品的单价
        public decimal GetUnitprice(int AlbumId)
        {
            Maticsoft.DAL.album albumdal = new Maticsoft.DAL.album();
            
            var albumModel=  albumdal.GetModel(AlbumId);
            return albumModel.Price;
        }
        //得到带album表数据
        public DataSet GetListWithAlbum(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * from cart as c LEFT JOIN album as a ON c.AlbumId=a.AlbumId");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod
	}
}

