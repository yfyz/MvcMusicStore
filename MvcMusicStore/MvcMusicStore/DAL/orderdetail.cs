using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:orderdetail
	/// </summary>
	public partial class orderdetail
	{
		public orderdetail()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("OrderDetailId", "orderdetail"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OrderDetailId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from orderdetail");
			strSql.Append(" where OrderDetailId=@OrderDetailId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OrderDetailId", MySqlDbType.Int32,11)			};
			parameters[0].Value = OrderDetailId;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.orderdetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into orderdetail(");
			strSql.Append("OrderDetailId,OrderId,AlbumId,Quantity,UnitPrice)");
			strSql.Append(" values (");
			strSql.Append("@OrderDetailId,@OrderId,@AlbumId,@Quantity,@UnitPrice)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OrderDetailId", MySqlDbType.Int32,11),
					new MySqlParameter("@OrderId", MySqlDbType.Int32,11),
					new MySqlParameter("@AlbumId", MySqlDbType.Int32,11),
					new MySqlParameter("@Quantity", MySqlDbType.Int32,11),
					new MySqlParameter("@UnitPrice", MySqlDbType.Decimal,10)};
			parameters[0].Value = model.OrderDetailId;
			parameters[1].Value = model.OrderId;
			parameters[2].Value = model.AlbumId;
			parameters[3].Value = model.Quantity;
			parameters[4].Value = model.UnitPrice;

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
		public bool Update(Maticsoft.Model.orderdetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update orderdetail set ");
			strSql.Append("OrderId=@OrderId,");
			strSql.Append("AlbumId=@AlbumId,");
			strSql.Append("Quantity=@Quantity,");
			strSql.Append("UnitPrice=@UnitPrice");
			strSql.Append(" where OrderDetailId=@OrderDetailId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OrderId", MySqlDbType.Int32,11),
					new MySqlParameter("@AlbumId", MySqlDbType.Int32,11),
					new MySqlParameter("@Quantity", MySqlDbType.Int32,11),
					new MySqlParameter("@UnitPrice", MySqlDbType.Decimal,10),
					new MySqlParameter("@OrderDetailId", MySqlDbType.Int32,11)};
			parameters[0].Value = model.OrderId;
			parameters[1].Value = model.AlbumId;
			parameters[2].Value = model.Quantity;
			parameters[3].Value = model.UnitPrice;
			parameters[4].Value = model.OrderDetailId;

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
		public bool Delete(int OrderDetailId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from orderdetail ");
			strSql.Append(" where OrderDetailId=@OrderDetailId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OrderDetailId", MySqlDbType.Int32,11)			};
			parameters[0].Value = OrderDetailId;

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
		public bool DeleteList(string OrderDetailIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from orderdetail ");
			strSql.Append(" where OrderDetailId in ("+OrderDetailIdlist + ")  ");
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
		public Maticsoft.Model.orderdetail GetModel(int OrderDetailId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OrderDetailId,OrderId,AlbumId,Quantity,UnitPrice from orderdetail ");
			strSql.Append(" where OrderDetailId=@OrderDetailId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OrderDetailId", MySqlDbType.Int32,11)			};
			parameters[0].Value = OrderDetailId;

			Maticsoft.Model.orderdetail model=new Maticsoft.Model.orderdetail();
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
		public Maticsoft.Model.orderdetail DataRowToModel(DataRow row)
		{
			Maticsoft.Model.orderdetail model=new Maticsoft.Model.orderdetail();
			if (row != null)
			{
				if(row["OrderDetailId"]!=null && row["OrderDetailId"].ToString()!="")
				{
					model.OrderDetailId=int.Parse(row["OrderDetailId"].ToString());
				}
				if(row["OrderId"]!=null && row["OrderId"].ToString()!="")
				{
					model.OrderId=int.Parse(row["OrderId"].ToString());
				}
				if(row["AlbumId"]!=null && row["AlbumId"].ToString()!="")
				{
					model.AlbumId=int.Parse(row["AlbumId"].ToString());
				}
				if(row["Quantity"]!=null && row["Quantity"].ToString()!="")
				{
					model.Quantity=int.Parse(row["Quantity"].ToString());
				}
				if(row["UnitPrice"]!=null && row["UnitPrice"].ToString()!="")
				{
					model.UnitPrice=decimal.Parse(row["UnitPrice"].ToString());
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
			strSql.Append("select OrderDetailId,OrderId,AlbumId,Quantity,UnitPrice ");
			strSql.Append(" FROM orderdetail ");
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
			strSql.Append("select count(1) FROM orderdetail ");
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
				strSql.Append("order by T.OrderDetailId desc");
			}
			strSql.Append(")AS Row, T.*  from orderdetail T ");
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
			parameters[0].Value = "orderdetail";
			parameters[1].Value = "OrderDetailId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

