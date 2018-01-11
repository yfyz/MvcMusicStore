using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:musicorder
	/// </summary>
	public partial class musicorder
	{
		public musicorder()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("OrderId", "musicorder"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OrderId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from musicorder");
			strSql.Append(" where OrderId=@OrderId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OrderId", MySqlDbType.Int32,11)			};
			parameters[0].Value = OrderId;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.musicorder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into musicorder(");
			strSql.Append("OrderId,OrderDate,Username,FirstName,LastName,Address,City,State,PostalCode,Country,Phone,Email,Total)");
			strSql.Append(" values (");
			strSql.Append("@OrderId,@OrderDate,@Username,@FirstName,@LastName,@Address,@City,@State,@PostalCode,@Country,@Phone,@Email,@Total)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OrderId", MySqlDbType.Int32,11),
					new MySqlParameter("@OrderDate", MySqlDbType.DateTime),
					new MySqlParameter("@Username", MySqlDbType.VarChar,256),
					new MySqlParameter("@FirstName", MySqlDbType.VarChar,160),
					new MySqlParameter("@LastName", MySqlDbType.VarChar,160),
					new MySqlParameter("@Address", MySqlDbType.VarChar,70),
					new MySqlParameter("@City", MySqlDbType.VarChar,40),
					new MySqlParameter("@State", MySqlDbType.VarChar,40),
					new MySqlParameter("@PostalCode", MySqlDbType.VarChar,10),
					new MySqlParameter("@Country", MySqlDbType.VarChar,40),
					new MySqlParameter("@Phone", MySqlDbType.VarChar,24),
					new MySqlParameter("@Email", MySqlDbType.VarChar,160),
					new MySqlParameter("@Total", MySqlDbType.Decimal,10)};
			parameters[0].Value = model.OrderId;
			parameters[1].Value = model.OrderDate;
			parameters[2].Value = model.Username;
			parameters[3].Value = model.FirstName;
			parameters[4].Value = model.LastName;
			parameters[5].Value = model.Address;
			parameters[6].Value = model.City;
			parameters[7].Value = model.State;
			parameters[8].Value = model.PostalCode;
			parameters[9].Value = model.Country;
			parameters[10].Value = model.Phone;
			parameters[11].Value = model.Email;
			parameters[12].Value = model.Total;

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
		public bool Update(Maticsoft.Model.musicorder model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update musicorder set ");
			strSql.Append("OrderDate=@OrderDate,");
			strSql.Append("Username=@Username,");
			strSql.Append("FirstName=@FirstName,");
			strSql.Append("LastName=@LastName,");
			strSql.Append("Address=@Address,");
			strSql.Append("City=@City,");
			strSql.Append("State=@State,");
			strSql.Append("PostalCode=@PostalCode,");
			strSql.Append("Country=@Country,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Email=@Email,");
			strSql.Append("Total=@Total");
			strSql.Append(" where OrderId=@OrderId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OrderDate", MySqlDbType.DateTime),
					new MySqlParameter("@Username", MySqlDbType.VarChar,256),
					new MySqlParameter("@FirstName", MySqlDbType.VarChar,160),
					new MySqlParameter("@LastName", MySqlDbType.VarChar,160),
					new MySqlParameter("@Address", MySqlDbType.VarChar,70),
					new MySqlParameter("@City", MySqlDbType.VarChar,40),
					new MySqlParameter("@State", MySqlDbType.VarChar,40),
					new MySqlParameter("@PostalCode", MySqlDbType.VarChar,10),
					new MySqlParameter("@Country", MySqlDbType.VarChar,40),
					new MySqlParameter("@Phone", MySqlDbType.VarChar,24),
					new MySqlParameter("@Email", MySqlDbType.VarChar,160),
					new MySqlParameter("@Total", MySqlDbType.Decimal,10),
					new MySqlParameter("@OrderId", MySqlDbType.Int32,11)};
			parameters[0].Value = model.OrderDate;
			parameters[1].Value = model.Username;
			parameters[2].Value = model.FirstName;
			parameters[3].Value = model.LastName;
			parameters[4].Value = model.Address;
			parameters[5].Value = model.City;
			parameters[6].Value = model.State;
			parameters[7].Value = model.PostalCode;
			parameters[8].Value = model.Country;
			parameters[9].Value = model.Phone;
			parameters[10].Value = model.Email;
			parameters[11].Value = model.Total;
			parameters[12].Value = model.OrderId;

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
		public bool Delete(int OrderId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from musicorder ");
			strSql.Append(" where OrderId=@OrderId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OrderId", MySqlDbType.Int32,11)			};
			parameters[0].Value = OrderId;

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
		public bool DeleteList(string OrderIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from musicorder ");
			strSql.Append(" where OrderId in ("+OrderIdlist + ")  ");
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
		public Maticsoft.Model.musicorder GetModel(int OrderId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OrderId,OrderDate,Username,FirstName,LastName,Address,City,State,PostalCode,Country,Phone,Email,Total from musicorder ");
			strSql.Append(" where OrderId=@OrderId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OrderId", MySqlDbType.Int32,11)			};
			parameters[0].Value = OrderId;

			Maticsoft.Model.musicorder model=new Maticsoft.Model.musicorder();
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
		public Maticsoft.Model.musicorder DataRowToModel(DataRow row)
		{
			Maticsoft.Model.musicorder model=new Maticsoft.Model.musicorder();
			if (row != null)
			{
				if(row["OrderId"]!=null && row["OrderId"].ToString()!="")
				{
					model.OrderId=int.Parse(row["OrderId"].ToString());
				}
				if(row["OrderDate"]!=null && row["OrderDate"].ToString()!="")
				{
					model.OrderDate=DateTime.Parse(row["OrderDate"].ToString());
				}
				if(row["Username"]!=null)
				{
					model.Username=row["Username"].ToString();
				}
				if(row["FirstName"]!=null)
				{
					model.FirstName=row["FirstName"].ToString();
				}
				if(row["LastName"]!=null)
				{
					model.LastName=row["LastName"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["City"]!=null)
				{
					model.City=row["City"].ToString();
				}
				if(row["State"]!=null)
				{
					model.State=row["State"].ToString();
				}
				if(row["PostalCode"]!=null)
				{
					model.PostalCode=row["PostalCode"].ToString();
				}
				if(row["Country"]!=null)
				{
					model.Country=row["Country"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["Total"]!=null && row["Total"].ToString()!="")
				{
					model.Total=decimal.Parse(row["Total"].ToString());
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
			strSql.Append("select OrderId,OrderDate,Username,FirstName,LastName,Address,City,State,PostalCode,Country,Phone,Email,Total ");
			strSql.Append(" FROM musicorder ");
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
			strSql.Append("select count(1) FROM musicorder ");
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
				strSql.Append("order by T.OrderId desc");
			}
			strSql.Append(")AS Row, T.*  from musicorder T ");
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
			parameters[0].Value = "musicorder";
			parameters[1].Value = "OrderId";
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

