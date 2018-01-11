using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:artist
	/// </summary>
	public partial class artist
	{
		public artist()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("ArtistId", "artist"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ArtistId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from artist");
			strSql.Append(" where ArtistId=@ArtistId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ArtistId", MySqlDbType.Int32,11)			};
			parameters[0].Value = ArtistId;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.artist model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into artist(");
			strSql.Append("ArtistId,Name)");
			strSql.Append(" values (");
			strSql.Append("@ArtistId,@Name)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ArtistId", MySqlDbType.Int32,11),
					new MySqlParameter("@Name", MySqlDbType.VarChar,120)};
			parameters[0].Value = model.ArtistId;
			parameters[1].Value = model.Name;

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
		public bool Update(Maticsoft.Model.artist model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update artist set ");
			strSql.Append("Name=@Name");
			strSql.Append(" where ArtistId=@ArtistId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Name", MySqlDbType.VarChar,120),
					new MySqlParameter("@ArtistId", MySqlDbType.Int32,11)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.ArtistId;

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
		public bool Delete(int ArtistId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from artist ");
			strSql.Append(" where ArtistId=@ArtistId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ArtistId", MySqlDbType.Int32,11)			};
			parameters[0].Value = ArtistId;

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
		public bool DeleteList(string ArtistIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from artist ");
			strSql.Append(" where ArtistId in ("+ArtistIdlist + ")  ");
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
		public Maticsoft.Model.artist GetModel(int ArtistId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ArtistId,Name from artist ");
			strSql.Append(" where ArtistId=@ArtistId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ArtistId", MySqlDbType.Int32,11)			};
			parameters[0].Value = ArtistId;

			Maticsoft.Model.artist model=new Maticsoft.Model.artist();
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
		public Maticsoft.Model.artist DataRowToModel(DataRow row)
		{
			Maticsoft.Model.artist model=new Maticsoft.Model.artist();
			if (row != null)
			{
				if(row["ArtistId"]!=null && row["ArtistId"].ToString()!="")
				{
					model.ArtistId=int.Parse(row["ArtistId"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
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
			strSql.Append("select ArtistId,Name ");
			strSql.Append(" FROM artist ");
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
			strSql.Append("select count(1) FROM artist ");
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
				strSql.Append("order by T.ArtistId desc");
			}
			strSql.Append(")AS Row, T.*  from artist T ");
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
			parameters[0].Value = "artist";
			parameters[1].Value = "ArtistId";
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

