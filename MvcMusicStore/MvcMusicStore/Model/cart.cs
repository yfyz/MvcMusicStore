using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Maticsoft.Model
{
	/// <summary>
	/// cart:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class cart
	{
		public cart()
		{}
		#region Model
		private int _recordid;
		private string _cartid;
		private int _albumid;
		private int _count;
		private DateTime _datecreated;
		/// <summary>
		/// 
		/// </summary>
        /// 
        [Key]
		public int RecordId
		{
			set{ _recordid=value;}
			get{return _recordid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CartId
		{
			set{ _cartid=value;}
			get{return _cartid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AlbumId
		{
			set{ _albumid=value;}
			get{return _albumid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Count
		{
			set{ _count=value;}
			get{return _count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DateCreated
		{
			set{ _datecreated=value;}
			get{return _datecreated;}
		}
        public album Album { get; set; }
		#endregion Model

	}
}

