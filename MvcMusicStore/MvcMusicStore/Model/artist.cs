using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// artist:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class artist
	{
		public artist()
		{}
		#region Model
		private int _artistid;
		private string _name;
		/// <summary>
		/// 
		/// </summary>
		public int ArtistId
		{
			set{ _artistid=value;}
			get{return _artistid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		#endregion Model

	}
}

