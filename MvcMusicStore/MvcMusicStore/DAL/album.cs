using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:album
	/// </summary>
	public partial class album
	{
		public album()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("AlbumId", "album"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AlbumId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from album");
			strSql.Append(" where AlbumId=@AlbumId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AlbumId", MySqlDbType.Int32,11)			};
			parameters[0].Value = AlbumId;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.album model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into album(");
			strSql.Append("AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl)");
			strSql.Append(" values (");
			strSql.Append("@AlbumId,@GenreId,@ArtistId,@Title,@Price,@AlbumArtUrl)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AlbumId", MySqlDbType.Int32,11),
					new MySqlParameter("@GenreId", MySqlDbType.Int32,11),
					new MySqlParameter("@ArtistId", MySqlDbType.Int32,11),
					new MySqlParameter("@Title", MySqlDbType.VarChar,160),
					new MySqlParameter("@Price", MySqlDbType.Decimal,10),
					new MySqlParameter("@AlbumArtUrl", MySqlDbType.VarChar,1024)};
			parameters[0].Value = model.AlbumId;
			parameters[1].Value = model.GenreId;
			parameters[2].Value = model.ArtistId;
			parameters[3].Value = model.Title;
			parameters[4].Value = model.Price;
			parameters[5].Value = model.AlbumArtUrl;

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
		public bool Update(Maticsoft.Model.album model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update album set ");
			strSql.Append("GenreId=@GenreId,");
			strSql.Append("ArtistId=@ArtistId,");
			strSql.Append("Title=@Title,");
			strSql.Append("Price=@Price,");
			strSql.Append("AlbumArtUrl=@AlbumArtUrl");
			strSql.Append(" where AlbumId=@AlbumId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@GenreId", MySqlDbType.Int32,11),
					new MySqlParameter("@ArtistId", MySqlDbType.Int32,11),
					new MySqlParameter("@Title", MySqlDbType.VarChar,160),
					new MySqlParameter("@Price", MySqlDbType.Decimal,10),
					new MySqlParameter("@AlbumArtUrl", MySqlDbType.VarChar,1024),
					new MySqlParameter("@AlbumId", MySqlDbType.Int32,11)};
			parameters[0].Value = model.GenreId;
			parameters[1].Value = model.ArtistId;
			parameters[2].Value = model.Title;
			parameters[3].Value = model.Price;
			parameters[4].Value = model.AlbumArtUrl;
			parameters[5].Value = model.AlbumId;

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
		public bool Delete(int AlbumId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from album ");
			strSql.Append(" where AlbumId=@AlbumId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AlbumId", MySqlDbType.Int32,11)			};
			parameters[0].Value = AlbumId;

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
		public bool DeleteList(string AlbumIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from album ");
			strSql.Append(" where AlbumId in ("+AlbumIdlist + ")  ");
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
		public Maticsoft.Model.album GetModel(int AlbumId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl from album ");
			strSql.Append(" where AlbumId=@AlbumId ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AlbumId", MySqlDbType.Int32,11)			};
			parameters[0].Value = AlbumId;

			Maticsoft.Model.album model=new Maticsoft.Model.album();
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
		public Maticsoft.Model.album DataRowToModel(DataRow row)
		{
			Maticsoft.Model.album model=new Maticsoft.Model.album();
			if (row != null)
			{
				if(row["AlbumId"]!=null && row["AlbumId"].ToString()!="")
				{
					model.AlbumId=int.Parse(row["AlbumId"].ToString());
				}
				if(row["GenreId"]!=null && row["GenreId"].ToString()!="")
				{
					model.GenreId=int.Parse(row["GenreId"].ToString());
				}
          
				if(row["ArtistId"]!=null && row["ArtistId"].ToString()!="")
				{
					model.ArtistId=int.Parse(row["ArtistId"].ToString());
				}
               
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["AlbumArtUrl"]!=null)
				{
					model.AlbumArtUrl=row["AlbumArtUrl"].ToString();
				}
                if (row.Table.Columns.Contains("genrename"))
                {
                    if (row["genrename"] != null)
                    {
                        model.genrename = row["genrename"].ToString();
                    }
                    if (row["artistname"] != null)
                    {
                        model.artistname = row["artistname"].ToString();
                    }
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
			strSql.Append("select AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl ");
			strSql.Append(" FROM album ");
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
			strSql.Append("select count(1) FROM album ");
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
				strSql.Append("order by T.AlbumId desc");
			}
			strSql.Append(")AS Row, T.*  from album T ");
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
			parameters[0].Value = "album";
			parameters[1].Value = "AlbumId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        public DataSet GetAllList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT AlbumId,a.GenreId,g.`Name` as genrename,a.ArtistId,ar.`Name` as artistname,Title,Price,AlbumArtUrl FROM album as a LEFT JOIN genre  as g ON a.GenreId=g.GenreId LEFT JOIN artist as ar ON a.ArtistId=ar.ArtistId");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public Maticsoft.Model.album GetModelAll(int id)
        {
            DataSet ds = GetAllList("AlbumId=" + id);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }         
        }
         public DataSet GetTopSellingAlbums(int count)
        {
             StringBuilder strSql=new StringBuilder();
             strSql.Append("SELECT  a.*, COUNT(o.AlbumId) as c from orderdetail as o LEFT JOIN album as a ON a.AlbumId=o.AlbumId GROUP BY o.AlbumId order by c DESC LIMIT " + count);
			return DbHelperMySQL.Query(strSql.ToString());
           
        }
		#endregion  ExtensionMethod
	}
}

