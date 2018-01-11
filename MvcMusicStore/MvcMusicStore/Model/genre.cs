using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Maticsoft.Model
{
	/// <summary>
	/// genre:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class genre
	{
		public genre()
		{}
		#region Model
		private int _genreid;
		private string _name;
		private string _description;
		/// <summary>
		/// 
		/// </summary>
        /// 
        [Key]
		public int GenreId
		{
			set{ _genreid=value;}
			get{return _genreid;}
		}
		/// <summary>
		/// 
		/// </summary>
        /// 
        [DisplayName("类型名称")]
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
        /// 
        [DisplayName("描述")]
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
        public List<album> Albums { get; set; }
		#endregion Model

	}
}

